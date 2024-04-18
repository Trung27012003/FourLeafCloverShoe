using FourLeafCloverShoe.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using Newtonsoft.Json.Linq;

namespace FourLeafCloverShoe.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly ISizeService _sizeService;

        public ProductsController(IProductService productService,IProductDetailService productDetailService,ISizeService sizeService)
        {
            _productService = productService;
            _productDetailService = productDetailService;
            _sizeService = sizeService;
        }
        public async Task<IActionResult> Index()
        {
            var products =await _productService.Gets();
            return View(products.Where(c => c.Status == true).ToList());
        }
        public async Task<IActionResult> ProductDetail(Guid productId)
        {
            var product = await _productService.GetById(productId);
            var lstProductDetail = await _productDetailService.GetByProductId(product.Id);
            var sizes = await _sizeService.Gets();

            var lstSize = sizes.Where(size => lstProductDetail.Any(detail => detail.SizeId == size.Id)).OrderBy(c=>c.Name).ToList();

            ViewBag.lstSize = lstSize;

            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> getdatabysizeid(string sizeId,string productId)
        {
            
            var product = await _productService.GetById(Guid.Parse(productId));
            var lstProductDetail = await _productDetailService.GetByProductId(product.Id);
            var productDetail = lstProductDetail.FirstOrDefault(c=>c.SizeId==Guid.Parse(sizeId));


            return Json(new { productDetailId = productDetail .Id,priceSale = productDetail.PriceSale,quantity=productDetail.Quantity});
        }


    }
}
