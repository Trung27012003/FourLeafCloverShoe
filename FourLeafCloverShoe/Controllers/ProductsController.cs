using FourLeafCloverShoe.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.SignalR;
using FourLeafCloverShoe.Helper;
using Microsoft.AspNetCore.Hosting;
using System.Drawing;
using ZXing;
using System.Diagnostics.Metrics;

namespace FourLeafCloverShoe.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly ISizeService _sizeService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductsController( IProductService productService,IProductDetailService productDetailService,ISizeService sizeService, IWebHostEnvironment webHostEnvironment)
        {
            _productService = productService;
            _productDetailService = productDetailService;
            _sizeService = sizeService;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var products =await _productService.Gets();
            return View(products.Where(c => c.Status == true&&c.ProductDetails.Where(p=>p.Status==1).Count()>0).ToList());
        }
        public async Task<IActionResult> ProductDetail(Guid productId)
        {
            
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

            var writer = new ZXing.QrCode.QRCodeWriter();
            var resultBit = writer.encode(productDetail.Id.ToString(), BarcodeFormat.QR_CODE, 100, 100);
            var matrix = resultBit;
            int scale = 1;
            var result = new Bitmap(matrix.Width * scale, matrix.Height * scale);
            for (int i = 0; i < matrix.Height; i++)
            {
                for (int j = 0; j < matrix.Width; j++)
                {
                    Color pixel = matrix[i, j] ? Color.Black : Color.White;
                    for (int n = 0; n < scale; n++)
                    {
                        for (int m = 0; m < scale; m++)
                        {
                            result.SetPixel(i * scale + n, j * scale + m, pixel);
                        }
                    }
                }


            }
            string webRootPath = _webHostEnvironment.WebRootPath;
            string qrCodeFolderPath = Path.Combine(webRootPath, "images", "qrcode");
                // Lấy danh sách tất cả các tệp trong thư mục QRCode
                string[] files = Directory.GetFiles(qrCodeFolderPath);

                // Xoá từng tệp ảnh trong thư mục
                foreach (string file in files)
                {
                    System.IO.File.Delete(file);
                }
            result.Save(webRootPath + $"\\images\\qrcode\\QRCode{productDetail.Id}.png");
            var imgQrCode = $"\\images\\qrcode\\QRCode{productDetail.Id}.png";

            return Json(new { productDetailId = productDetail .Id,priceSale = productDetail.PriceSale,quantity=productDetail.Quantity,status = status, imgQrCode= imgQrCode });
        }


    }
}
