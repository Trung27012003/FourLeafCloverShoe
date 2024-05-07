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
using FourLeafCloverShoe.Services;
using FourLeafCloverShoe.Share.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Options;
using X.PagedList;

namespace FourLeafCloverShoe.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly ISizeService _sizeService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly IOrderItemService _orderItemService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductsController(IProductService productService, IOrderItemService orderItemService, IBrandService brandService, ICategoryService categoryService, IProductDetailService productDetailService, ISizeService sizeService, IWebHostEnvironment webHostEnvironment)
        {
            _productService = productService;
            _productDetailService = productDetailService;
            _sizeService = sizeService;
            _categoryService = categoryService;
            _brandService = brandService;
            _orderItemService = orderItemService;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<List<Product>> Filter(string searchString, string sortSelect, string[] size_group, string[] brand_group, string[] category_group, string price_range, List<Product> lstProduct)
        {
            if (!String.IsNullOrWhiteSpace(searchString))
            {
                lstProduct = lstProduct.FindAll(c => c.ProductName.ToLower().Contains(searchString.ToLower()));
            }
            if (size_group.Length > 0)
            {
                lstProduct = lstProduct.FindAll(c => c.ProductDetails.Any(p => size_group.Contains(p.Size.Name)));
            }
            if (brand_group.Length > 0)
            {
                lstProduct = lstProduct.FindAll(c => c.ProductDetails.Any(p => brand_group.Contains(c.Brands.Name)));
            }
            if (category_group.Length > 0)
            {
                lstProduct = lstProduct.FindAll(c => c.ProductDetails.Any(p => category_group.Contains(c.Categories.Name)));
            }
            if (!string.IsNullOrWhiteSpace(price_range))
            {
                switch (price_range)
                {
                    case "duoi100":
                        lstProduct = lstProduct.FindAll(c => c.ProductDetails.Any(p => p.PriceSale <= 100000));
                        break;
                    case "100-200":
                        lstProduct = lstProduct.FindAll(c => c.ProductDetails.Any(p => p.PriceSale >= 100000 && p.PriceSale <= 200000));
                        break;
                    case "200-300":
                        lstProduct = lstProduct.FindAll(c => c.ProductDetails.Any(p => p.PriceSale >= 200000 && p.PriceSale <= 300000));
                        break;
                    case "tren300":
                        lstProduct = lstProduct.FindAll(c => c.ProductDetails.Any(p => p.PriceSale >= 300000));
                        break;

                    default:
                        break;
                }
            }
            if (!String.IsNullOrWhiteSpace(sortSelect))
            {
                switch (sortSelect)
                {
                    case "PRICEASC":
                        lstProduct = lstProduct.OrderBy(c => c.ProductDetails.Min(p => p.PriceSale)).ToList();
                        break;
                    case "PRICEDESC":
                        lstProduct = lstProduct.OrderByDescending(c => c.ProductDetails.Max(p => p.PriceSale)).ToList();
                        break;
                    case "NAMEAZ":
                        lstProduct = lstProduct.OrderBy(c => c.ProductName).ToList();
                        break;
                    case "NAMEZA":
                        lstProduct = lstProduct.OrderByDescending(c => c.ProductName).ToList();
                        break;
                    case "DATENEW":
                        lstProduct = lstProduct.OrderByDescending(c => c.CreateAt).ToList();
                        break;
                    case "DATEOLD":
                        lstProduct = lstProduct.OrderBy(c => c.CreateAt).ToList();
                        break;
                    case "BESTSALE":
                        var lstOrderItem = await _orderItemService.Gets();
                        lstProduct = lstProduct.OrderByDescending(c => lstOrderItem.Where(p => p.ProductDetails.ProductId == c.Id).Sum(p => p.Quantity)).ToList();
                        break;
                    default:
                        break;
                }
            }
            return lstProduct;
        }

        public async Task<IActionResult> Index(int? page,string searchString, string sortSelect, string[] size_group, string[] brand_group, string[] category_group, string price_range)
        {
            if (page == null) page = 1;
            int pageSize = 24;
            int pageNumber = (page ?? 1);

            var lstProduct = (await _productService.Gets()).Where(c => c.Status == true && c.ProductDetails.Where(p => p.Status == 1).Count() > 0).ToList();
            var Size = new List<string>();
            foreach (var size in await _sizeService.Gets())
            {
                Size.Add(size.Name);
            }
            ViewBag.Size = Size;
            ViewBag.SelectedSize = size_group.ToList(); // Lưu trữ các size đã chọn

            var Brand = new List<string>();
            foreach (var brand in await _brandService.Gets())
            {
                Brand.Add(brand.Name);
            }
            ViewBag.Brand = Brand;
            ViewBag.SelectedBrand = brand_group.ToList(); // Lưu trữ các brand đã chọn

            var Category = new List<string>();
            foreach (var cate in await _categoryService.Gets())
            {
                Category.Add(cate.Name);
            }
            ViewBag.Category = Category;
            var sortOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "PRICEASC", Text = "Theo giá: từ thấp đến cao" },
                new SelectListItem { Value = "PRICEDESC", Text = "Theo giá: từ cao đến thấp" },
                new SelectListItem { Value = "NAMEAZ", Text = "Theo tên từ: A-Z" },
                new SelectListItem { Value = "NAMEZA", Text = "Theo tên từ: Z-A" },
                new SelectListItem { Value = "DATENEW", Text = "Sản phẩm mới nhất" },
                new SelectListItem { Value = "DATEOLD", Text = "Sản phẩm cũ" },
                new SelectListItem { Value = "BESTSALE", Text = "Sản phẩm bán chạy" }
                // Thêm các tùy chọn khác tại đây
            };
            ViewBag.SortSelect = new SelectList(sortOptions, "Value", "Text", sortSelect); // Tạo SelectList với giá trị đã chọn
            ViewBag.SelectedCategory = category_group.ToList(); // Lưu trữ các category đã chọn
            ViewBag.PriceRange = price_range;
            ViewBag.SearchString = searchString;

            lstProduct = await Filter(searchString, sortSelect, size_group, brand_group, category_group, price_range, lstProduct); // lọc theo size, brand, category, range price
            return View(lstProduct.ToPagedList(pageNumber, pageSize));
        }

        public async Task<IActionResult> ProductDetail(Guid productId)
        {

            var product = await _productService.GetById(productId);
            var lstProductDetail = await _productDetailService.GetByProductId(product.Id);
            var sizes = await _sizeService.Gets();

            var lstSize = sizes.Where(size => lstProductDetail.Any(detail => detail.SizeId == size.Id)).OrderBy(c => c.Name).ToList();

            var priceMin = lstProductDetail.Where(c => c.Status == 1).Min(c => c.PriceSale);
            var priceMax = lstProductDetail.Where(c => c.Status == 1).Max(c => c.PriceSale);
            var availibleQuantity = lstProductDetail.Where(c => c.Status == 1).Sum(c => c.Quantity);
            ViewBag.lstSize = lstSize;
            ViewBag.priceMin = priceMin;
            ViewBag.priceMax = priceMax;
            ViewBag.availibleQuantity = availibleQuantity;

            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> getdatabysizeid(string sizeId, string productId)
        {


            var product = await _productService.GetById(Guid.Parse(productId));
            var lstProductDetail = await _productDetailService.GetByProductId(product.Id);
            var productDetail = lstProductDetail.FirstOrDefault(c => c.SizeId == Guid.Parse(sizeId));
            var status = productDetail.Status;

            if (productDetail.Products.Status == true && status == 1)
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

            return Json(new { productDetailId = productDetail.Id, priceSale = productDetail.PriceSale, quantity = productDetail.Quantity, status = status, imgQrCode = imgQrCode });
        }


    }
}
