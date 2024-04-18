using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Share.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace FourLeafCloverShoe.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly ICartItemItemService _cartItemItemService;
        private readonly IProductDetailService _productDetailService;
        private readonly IProductService _productService;
        private readonly UserManager<User> _userManager;

        public CartController(ICartService cartService, IProductService productService, ICartItemItemService cartItemItemService, IProductDetailService productDetailService, UserManager<User> userManager)
        {
            _cartService = cartService;
            _cartItemItemService = cartItemItemService;
            _productDetailService = productDetailService;
            _productService = productService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var cartItems = await _cartItemItemService.GetsByUserId(user.Id);
                return View(cartItems);
            }
            return View();
        }
        public async Task<IActionResult> addToCart(int quantity, Guid productDetailId)
        {
            var producDetailFromDb = await _productDetailService.GetById(productDetailId);
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var cartItems = await _cartItemItemService.GetsByUserId(user.Id);
                var itemInCart = cartItems.Where(c => c.ProductDetailId == productDetailId);
                if (quantity <= 0) // số lượng phải hợp lệ
                {
                    return Json(new { message = "Số lượng sản phẩm phải lớn hơn 0, vui lòng chọn lại!", isSuccess = false });

                }
                else if (productDetailId == Guid.Parse("00000000-0000-0000-0000-000000000000")) // sản phẩm chi tiết phải hợp lệ
                {
                    return Json(new { message = "Vui lòng chọn kích cỡ hợp lệ, vui lòng chọn lại!", isSuccess = false });
                }
                else if (producDetailFromDb.Status == 0) // sản phẩm chi tiết phải hợp lệ về status
                {
                    return Json(new { message = "Sản phẩm ngừng bán, vui lòng chọn lại!", isSuccess = false });
                }
                else if (producDetailFromDb.Quantity <= 0) // sản phẩm chi tiết phải hợp lệ về số lượng
                {
                    return Json(new { message = "Sản phẩm đã hết hàng, vui lòng chọn lại!", isSuccess = false }); // kho hết hàng
                }
                else if (producDetailFromDb.Quantity < quantity)
                {
                    return Json(new { message = "Kho không đủ số lượng yêu cầu, vui lòng chọn lại!", isSuccess = false }); // kho hết hàng
                }
                else
                {
                    if (itemInCart.Count() < 1)
                    {
                        var item = new CartItem()
                        {
                            CartId = (await _cartService.GetByUserId(user.Id)).Id,
                            ProductDetailId = productDetailId,
                            Quantity = quantity,
                            Price = producDetailFromDb.PriceSale
                        };
                        var result = await _cartItemItemService.Add(item);
                        if (result)
                        {

                            return Json(new { message = "Thêm sản phẩm thành công!", isSuccess = true }); // Done

                        }
                        return Json(new { message = "Lỗi thêm mới sản phẩm!", isSuccess = false });
                    }
                    else
                    {
                        var productInCart = cartItems.FirstOrDefault(c => c.ProductDetailId == productDetailId);
                        if (producDetailFromDb.Quantity < quantity + productInCart.Quantity)
                        {
                            return Json(new { message = "Số lượng sản phẩm trong giỏ hàng và số lượng muốn thêm vào vượt quá số lượng tồn kho. Vui lòng giảm số lượng!", isSuccess = false }); // tổng hàng vượt quá kho
                        }
                        else
                        {
                            productInCart.Quantity += quantity;
                            var result = await _cartItemItemService.Update(productInCart);
                            if (result)
                            {

                                return Json(new { message = "Thêm sản phẩm thành công!", isSuccess = true }); // Done

                            }
                            return Json(new { message = "Thêm sản phẩm thành công!", isSuccess = true }); // Done
                        }
                    }
                }

            }

            return Json(new { message = "Vui lòng đăng nhập!", isSuccess = false });
        }
        public async Task<IActionResult> getMiniCart()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var cartItems = await _cartItemItemService.GetsByUserId(user.Id);
                var lstproductdetail = await _productDetailService.Gets();
                var lstproductdetails = lstproductdetail.Where(c => cartItems.Any(p => p.ProductDetailId == c.Id));
                var settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };
                var serializedCartItems = JsonConvert.SerializeObject(lstproductdetails, settings);
                var tongtien = lstproductdetails.Sum(productDetail =>
cartItems.FirstOrDefault(c => c.ProductDetailId == productDetail.Id)?.Quantity * productDetail.PriceSale ?? 0);
                return Json(new { lstproducts = serializedCartItems, tongtien = tongtien });
            }
            return Json(new { lstproducts = new List<CartItem>(), tongtien = 0 });
        }
        public async Task<IActionResult> removeMiniCartItem(Guid productDetailId)
        {
            if (User.Identity.IsAuthenticated)
            {
                var result = await _cartItemItemService.DeleteByProductDetailId(productDetailId);
                if (result)
                {
                    return Json(new { message = "Xoá thành công!", isSuccess = true });
                }

                return Json(new { message = "Có lỗi xảy ra!", isSuccess = false });
            }
            return Json(new { message = "Chưa đăng nhập!", isSuccess = false });

        }
        public async Task<IActionResult> removeCartItem(Guid productDetailId)
        {
            if (User.Identity.IsAuthenticated)
            {
                var result = await _cartItemItemService.DeleteByProductDetailId(productDetailId);
                if (result)
                {
                    return Json(new { message = "Xoá thành công!", isSuccess = true });
                }

                return Json(new { message = "Có lỗi xảy ra!", isSuccess = false });
            }
            return Json(new { message = "Chưa đăng nhập!", isSuccess = false });

        }

        public async Task<IActionResult> getCountCart()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var cartItems = await _cartItemItemService.GetsByUserId(user.Id);
                var count = cartItems.Count();
                return Json(new { message = "Lấy thành công!", isSuccess = true , count = count });
            }
            return Json(new { message = "Chưa đăng nhập!", isSuccess = false,count=0 });

        }



    }
}
