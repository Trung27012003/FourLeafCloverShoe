using FourLeafCloverShoe.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.SignalR;
using FourLeafCloverShoe.Helper;

namespace FourLeafCloverShoe.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly ISizeService _sizeService;
        private readonly IHubContext<Hubs> _hubContext;

        public ProductsController(IHubContext<Hubs> hubContext, IProductService productService,IProductDetailService productDetailService,ISizeService sizeService)
        {
            _productService = productService;
            _productDetailService = productDetailService;
            _sizeService = sizeService;
            _hubContext = hubContext;

        }
        public async Task<IActionResult> Index()
        {
            var products =await _productService.Gets();
            return View(products.Where(c => c.Status == true&&c.ProductDetails.Where(p=>p.Status==1).Count()>0).ToList());
        }
        public async Task<IActionResult> ProductDetail(Guid productId)
        {
            //await _hubContext.Clients.All.SendAsync("alertToAdmin", $"Trung Trương vừa mua hàng",true);
            var product = await _productService.GetById(productId);
            var lstProductDetail = await _productDetailService.GetByProductId(product.Id);
            var sizes = await _sizeService.Gets();

            var lstSize = sizes.Where(size => lstProductDetail.Any(detail => detail.SizeId == size.Id)).OrderBy(c=>c.Name).ToList();

            var priceMin = lstProductDetail.Where(c => c.Status == 1).Min(c=>c.PriceSale);
            var priceMax = lstProductDetail.Where(c => c.Status == 1).Max(c=>c.PriceSale);
            var availibleQuantity = lstProductDetail.Where(c => c.Status == 1).Sum(c=>c.Quantity);
            ViewBag.lstSize = lstSize;
            ViewBag.priceMin = priceMin;
            ViewBag.priceMax = priceMax;
            ViewBag.availibleQuantity = availibleQuantity;

            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> getdatabysizeid(string sizeId,string productId)
        {
            
            var product = await _productService.GetById(Guid.Parse(productId));
            var lstProductDetail = await _productDetailService.GetByProductId(product.Id);
            var productDetail = lstProductDetail.FirstOrDefault(c=>c.SizeId==Guid.Parse(sizeId));
            var status = productDetail.Status;
            if (productDetail.Products.Status==true&&status==1)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }

            return Json(new { productDetailId = productDetail .Id,priceSale = productDetail.PriceSale,quantity=productDetail.Quantity,status = status });
        }


    }
}
