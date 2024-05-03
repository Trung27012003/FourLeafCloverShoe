using FourLeafCloverShoe.Controllers;
using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Share.Models;
using FourLeafCloverShoe.Share.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Net.WebSockets;
using static System.Net.Mime.MediaTypeNames;

namespace FourLeafCloverShoe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BanTaiQuayController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IProductDetailService _productDetailService;
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;
        private readonly IUserVoucherService _userVoucherService;
        private readonly IVoucherService _voucherService;

        public BanTaiQuayController(UserManager<User> userManager,
            IProductDetailService productDetailService,
            IOrderService orderService,
            IOrderItemService orderItemService,
            IUserVoucherService userVoucherService,
            IVoucherService voucherService
            )
        {
            _userManager = userManager;
            _productDetailService = productDetailService;
            _orderService = orderService;
            _orderItemService = orderItemService;
            _userVoucherService = userVoucherService;
            _voucherService = voucherService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetPhoneNumbersAsync()
        {
            var lstUser = await _userManager.Users.ToListAsync();
            // Lấy dữ liệu số điện thoại từ nguồn nào đó
            var phoneNumbers = new List<SelectListItem>();
            foreach (var item in lstUser)
            {
                phoneNumbers.Add(new SelectListItem() { Text = item.PhoneNumber, Value = item.Id });
            }


            // Trả về dữ liệu dưới dạng JSON
            return Json(phoneNumbers);
        }
        public async Task<IActionResult> GetProductDetailsAsync()
        {
            var productDetails = await _productDetailService.Gets();
            var listProductDetail = new List<ProductDeailViewModel>();
            foreach (var item in productDetails)
            {
                bool status = false;
                if (item.Status==1&& item.Products.Status==true)
                {
                    status = true;
                }
                listProductDetail.Add(new ProductDeailViewModel() { Id = item.Id, Quantity = item.Quantity, ImageUrl = item.Products.ProductImages.First().ImageUrl, ProductName = item.Products.ProductName, SizeName = item.Size.Name, Price = item.PriceSale,Status = status });
            }
            // Trả về dữ liệu dưới dạng JSON
            return Json(listProductDetail);
        }
        [HttpPost]
        public async Task<IActionResult> GetOrderItemsAsync(Guid orderId)
        {
            var lstOrderItem = (await _orderItemService.Gets()).Where(c => c.OrderId == orderId);
            // Lấy dữ liệu số điện thoại từ nguồn nào đó

            var listProductDetail = new List<ProductDeailViewModel>();
            foreach (var item in lstOrderItem)
            {
                listProductDetail.Add(new ProductDeailViewModel() { Id = (Guid)item.ProductDetailId, Quantity = item.Quantity, ImageUrl = item.ProductDetails.Products.ProductImages.First().ImageUrl, ProductName = item.ProductDetails.Products.ProductName, SizeName = item.ProductDetails.Size.Name, Price = item.Price, Total = item.Price * item.Quantity });
            }
            // Trả về dữ liệu dưới dạng JSON
            return Json(listProductDetail);
        }
        [HttpPost]
        public async Task<IActionResult> AddUserToOrder(Guid orderId,string userId)
        {
            if (orderId==null||orderId==new Guid())
            {
                return Json(new {message = "Bạn chưa tạo đơn hàng mới!", isSuccess = false });
            }
            var order = await _orderService.GetById(orderId);
            order.UserId = userId;
            var result = await _orderService.Update(order);
            return Json(new { message = "Thêm khách hàng thành công!", isSuccess = result });
        }
        public async Task UpdateTotalAmount(Guid orderId) // tạm
        {
            var order = await _orderService.GetById(orderId);
            var orderItems = (await _orderItemService.Gets()).Where(c => c.OrderId == orderId);
            var total = orderItems.Sum(c => c.Quantity * c.Price);
            order.TotalAmout = total; //  cái này còn phải trừ coin, voucher
            await _orderService.Update(order);
        }
        [HttpPost]
        public async Task<JsonResult> ApplyVoucher(Guid voucherId)
        {
            if (voucherId != new Guid())
            {
                var voucherSelected = (await _voucherService.GetById(voucherId));

                return Json(new { Id = voucherSelected.Id, voucherType = voucherSelected.VoucherType, voucherValue = voucherSelected.VoucherValue, maxDiscount = voucherSelected.MaximumOrderValue, isSuccess = true });
            }
            return Json(new { isSuccess = false });
        }
        public async Task<IActionResult> loadDataUserOrder(Guid orderId)
        {
            if (orderId!=new Guid())
            {
                var order = await _orderService.GetById(orderId);
                var orderItems = (await _orderItemService.Gets()).Where(c => c.OrderId == orderId);
                var total = orderItems.Sum(c => c.Quantity * c.Price);
                var userVouchers = (await _userVoucherService.Gets()).Where(c => c.UserId == order.UserId && c.Status ==1);
                var lstVoucher = new List<SelectListItem>();
                if (order.UserId != null)
                {
                    var user = await _userManager.FindByIdAsync(order.UserId);
                    var vouchers = (await _voucherService.Gets()).Where(c => userVouchers.Any(p => c.Id == p.VoucherId) && c.Quantity > 0 && c.Status == 1&& c.StartDate<=DateTime.Now&& c.EndDate>=DateTime.Now);
                    foreach (var obj in vouchers.Where(c=>c.MinimumOrderValue<=total))
                    {
                        var giamToiDa = obj.MaximumOrderValue;
                        var giaTriVoucher = obj.VoucherValue?.ToString("0.##");
                        string text = "";
                        if (obj.VoucherType == 1)
                        {
                            giaTriVoucher += " %";
                            text = $"Mã giảm {giaTriVoucher} tối đa {giamToiDa?.ToString("N0")} đ đơn từ {obj.MinimumOrderValue?.ToString("N0")}đ ";
                        }
                        else
                        {
                            giaTriVoucher = String.Format("N0", giaTriVoucher) + " đ";
                            text = $"Mã giảm {giamToiDa?.ToString("N0")} đ đơn từ {obj.MinimumOrderValue?.ToString("N0")}đ ";
                        }
                        lstVoucher.Add(new SelectListItem()
                        {
                            Text = text,
                            Value = obj.Id.ToString()
                        });
                    }
                    return Json(new {fullName  = user.FullName, phoneNumber = user.PhoneNumber, coins = user.Coins, total = total, lstVoucher= lstVoucher, voucherValue = order.VoucherValue });
                }
                return Json(new { fullName = "", phoneNumber = "", coins = 0, total = total, lstVoucher = lstVoucher, voucherValue = order.VoucherValue });
            }
            return Json(new { message = "Order null!", isSuccess = false });
        }

        public async Task<IActionResult> GetPendingOrders()
        {
            var lstDonCho = (await _orderService.Gets()).Where(c => c.OrderStatus == -1); // lấy danh sách đơn chờ
            var lstDonChoHetHan = lstDonCho.Where(c => c.CreateDate.Value.Date != DateTime.Today.Date); // lấy danh sách đơn chờ hết hạn
            var lstSanPhamDonChoHetHan = (await _orderItemService.Gets()).Where(c => lstDonChoHetHan.Any(b => b.Id == c.OrderId)); // lấy danh sách orderitem trong đơn chờ hết hạn
            foreach (var item in lstSanPhamDonChoHetHan) // hoàn kho sản phẩm
            {
                var productDetail = await _productDetailService.GetById((Guid)item.ProductDetailId);
                productDetail.Quantity += item.Quantity;
                await _productDetailService.Update(productDetail);
            }
            await _orderItemService.DeleteMany(lstSanPhamDonChoHetHan.ToList()); // xoá sp hết hạn ở orderItem
            await _orderService.DeleteMany(lstDonChoHetHan.ToList()); // xoá đơn hết hạn
            var lstGuid = new List<Guid>();
            foreach (var item in (await _orderService.Gets()).Where(c => c.OrderStatus == -1)) // lưu trữ id đơn hàng
            {
                lstGuid.Add(item.Id);
            }
            return Json(lstGuid);
        }
        [HttpPost]
        public async Task RemovePendingOrder(Guid orderId)
        {
            var order = (await _orderService.Gets()).FirstOrDefault(c => c.Id == orderId);
            if (order != null)
            {
                if (order.OrderStatus == -1)
                {
                    var orderItems = (await _orderItemService.Gets()).Where(c => c.OrderId == orderId);
                   

                    if (orderItems.Count() > 0)
                    {
                        var lstProductDetail = (await _productDetailService.Gets()).Where(c => orderItems.Any(p => p.ProductDetailId == c.Id)); // hoàn lại sp vào kho
                        foreach (var item in lstProductDetail)
                        {
                            item.Quantity += orderItems.FirstOrDefault(c => c.ProductDetailId == item.Id).Quantity;
                            await _productDetailService.UpdateMany(lstProductDetail.ToList());
                        }
                        await _orderItemService.DeleteMany(orderItems.ToList());
                    }
                    await _orderService.Delete(orderId);
                }
            }
        }

        public async Task<IActionResult> CreateNewOrderAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var order = new Order()
            {
                Id = Guid.NewGuid(),
                TotalAmout = 0,
                OrderStatus = -1, // trạng thái đơn chờ
                OrderCode = OrderController.GenerateInvoiceCode("off"),
                StaffId = user.Id,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                CoinsUsed = 0,
                VoucherValue = 0,
                ShippingFee = 0
            };
            var result = await _orderService.Add(order);
            if (result)
            {
                return Json(new { orderId = order.Id });
            }
            return Json(new { orderId = Guid.NewGuid() });

        }
        [HttpPost]
        public async Task<IActionResult> AddProductDetailToOrderAsync(Guid orderId, Guid productDetailId) // cần - số lượng trong db
        {
            if (orderId==null||orderId ==new Guid())
            {

                return Json(new { isSuccess = false, message = "Bạn chưa tạo đơn hàng mới!" });
            }
            var order = await _orderService.GetById(orderId);
            var productDetail = await _productDetailService.GetById(productDetailId);
            if (order != null && productDetail != null)
            {
                if (productDetail.Status != 1 || productDetail.Products.Status != true)
                {

                    return Json(new { isSuccess = false, message = "Sản phẩm ngừng kinh doanh!" });
                }
                else if (productDetail.Quantity <= 0)
                {

                    return Json(new { isSuccess = false, message = "Sản phẩm không đủ số lượng trong kho!" });
                }
                else
                {
                    var lstOrderItems = (await _orderItemService.Gets()).Where(c => c.ProductDetailId == productDetailId && c.OrderId == orderId);
                    if (lstOrderItems.Count() == 0) // nếu orderItem không tồn tại thì thêm mới
                    {
                        var orderItem = new OrderItem()
                        {
                            Id = Guid.NewGuid(),
                            ProductDetailId = productDetail.Id,
                            OrderId = order.Id,
                            Quantity = 1,
                            Price = productDetail.PriceSale
                        };
                        var resultCreateOrderItem = await _orderItemService.Add(orderItem);
                        productDetail.Quantity -= 1;
                        await _productDetailService.Update(productDetail);
                        return Json(new { isSuccess = resultCreateOrderItem , message = "Cập nhật thành công" });
                    }
                    else // cộng dồn số lượng
                    {
                        var orderItem = (await _orderItemService.Gets()).FirstOrDefault(c => c.ProductDetailId == productDetailId && c.OrderId == orderId);
                        orderItem.Quantity += 1;
                        var resultCreateOrderItem = await _orderItemService.Update(orderItem);
                        productDetail.Quantity -= 1;
                        await _productDetailService.Update(productDetail);
                        return Json(new { isSuccess = resultCreateOrderItem , message = "Cập nhật thành công"});
                    }
                }
            }
            return Json(new { isSuccess = false, message = "Lỗi không xác định" });
        }
        public async Task<IActionResult> UpdateQuantityAsync(Guid productDetailId, Guid orderId, int newQuantity) // cần update số lượng trong db và check kho
        {
            var productDetail = await _productDetailService.GetById(productDetailId);
            var orderItem = (await _orderItemService.Gets()).FirstOrDefault(c => c.ProductDetailId == productDetailId && c.OrderId == orderId);
            if (productDetail.Quantity + orderItem.Quantity < newQuantity)
            {
                return Json(new { message = "Sản phẩm vượt quá giới hạn trong kho", isSuccess = false });
            }
            if (newQuantity <= 0)
            {
                return Json(new { message = "Sản phẩm tối thiểu là 1", isSuccess = false });
            }
            if (orderItem != null)
            {
                productDetail.Quantity = productDetail.Quantity + orderItem.Quantity - newQuantity;
                orderItem.Quantity = newQuantity;
                var result = await _orderItemService.Update(orderItem);
                if (result)
                {
                    await _productDetailService.Update(productDetail);
                    return Json(new { message = "Cập nhật thành công", isSuccess = true });
                }
            }
            return Json(new { message = "Lỗi không xác định", isSuccess = false });
        }
        public async Task<IActionResult> RemoveOrderItemAsync(Guid productDetailId, Guid orderId) // cần update lại số lượng trong db
        {
            var orderItem = (await _orderItemService.Gets()).FirstOrDefault(c => c.ProductDetailId == productDetailId && c.OrderId == orderId);
            if (orderItem != null)
            {
                var result = await _orderItemService.Delete(orderItem.Id);
                if (result)
                {
                    var productDetail = await _productDetailService.GetById(productDetailId);
                    productDetail.Quantity += orderItem.Quantity;
                    await _productDetailService.Update(productDetail);
                    return Json(new { message = "Cập nhật thành công", isSuccess = true });
                }
            }
            return Json(new { message = "Lỗi không xác định", isSuccess = false });
        }


    }
}
