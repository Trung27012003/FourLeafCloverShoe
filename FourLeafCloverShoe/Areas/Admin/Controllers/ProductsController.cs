﻿using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Services;
using FourLeafCloverShoe.Share.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;

namespace FourLeafCloverShoe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISizeService _sizeService;
        private readonly IBrandService _brandService;
        private readonly IProductImageService _productImageService;
        private readonly ICategoryService _categoryService;
        private readonly IProductDetailService _productDetailService;
        private List<IFormFile> _lstIFormFile;

        public ProductsController(  IProductService productService,
                                    ISizeService sizeService,
                                    IBrandService brandService,
                                    IProductImageService productImageService,
                                    IProductDetailService productDetailService,
                                    ICategoryService categoryService)
        {
            _productService = productService;
            _sizeService = sizeService;
            _brandService = brandService;
            _productImageService = productImageService;
            _categoryService = categoryService;
            _productDetailService = productDetailService;
            _lstIFormFile = new List<IFormFile>();

        }
        public async Task<IActionResult> Index()
        {
            await _productService.UpdateStatusQuantity();
            var lstObj = await _productService.Gets();
            return View(  lstObj.OrderByDescending(c => c.Status)) ; // trạng thái đang bán (True);
        }
        public async Task<IActionResult> CreateNewProduct()
        {
            List<SelectListItem> ListCategoryitems = new List<SelectListItem>();
            foreach (var obj in (await _categoryService.Gets()))
            {
                ListCategoryitems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListCategoryitems = ListCategoryitems;
            List<SelectListItem> ListBranditems = new List<SelectListItem>();
            foreach (var obj in await _brandService.Gets())
            {
                ListBranditems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListBranditems = ListBranditems;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewProduct(Product product)
        {
            //var listTags = tags.Split(',').ToList(); // thêm vào chuỗi string 


            List<SelectListItem> ListCategoryitems = new List<SelectListItem>();
            // Giả sử myList là danh sách dữ liệu của bạn
            foreach (var obj in (await _categoryService.Gets()))
            {
                ListCategoryitems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListCategoryitems = ListCategoryitems;
            List<SelectListItem> ListBranditems = new List<SelectListItem>();
            // Giả sử myList là danh sách dữ liệu của bạn
            foreach (var obj in await _brandService.Gets())
            {
                ListBranditems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListBranditems = ListBranditems;


            string imageList = HttpContext.Session.GetString("ImageList");
            if (ModelState.IsValid)
            {
                if (imageList == null)
                {
                    // Trả về view với thông báo lỗi nếu ModelState không hợp lệ hoặc không có tệp nào được tải lên
                    ModelState.AddModelError("", "Vui lòng thêm ảnh.");
                    return View(product);
                }
                product.CreateAt = DateTime.Now;
                product.Description = product.Description;
                product.ProductCode = GetInitials(product.ProductName) + DateTime.Now.ToString("yyMMddHHmmss");
                product.AvailableQuantity = 0;
                product.Status = product.Status;
                var result = await _productService.Add(product);
                if (result)
                {
                    List<string> imageListAsList = imageList.Split(';').ToList();
                    foreach (var item in imageListAsList)
                    {

                        var createProductImageResult = await _productImageService.Add(new ProductImages() { ProductId = product.Id, ImageUrl = item });
                        // Cập nhật đường dẫn hình ảnh cho sản phẩm

                    }
                    HttpContext.Session.Remove("ImageList");
                    return RedirectToAction("Index", "Products", new { @area = "Admin" });
                }

            }
            // Trả về view với thông báo lỗi nếu ModelState không hợp lệ hoặc không có tệp nào được tải lên
            ModelState.AddModelError("", "Vui lòng nhập đầy đủ các trường");
            return View(product);
        }
        public async Task<IActionResult> EditProduct(Guid productId) // edit product
        {
            List<SelectListItem> ListCategoryitems = new List<SelectListItem>();
            // Giả sử myList là danh sách dữ liệu của bạn
            foreach (var obj in (await _categoryService.Gets()))
            {
                ListCategoryitems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListCategoryitems = ListCategoryitems;
            List<SelectListItem> ListBranditems = new List<SelectListItem>();
            // Giả sử myList là danh sách dữ liệu của bạn
            foreach (var obj in await _brandService.Gets())
            {
                ListBranditems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListBranditems = ListBranditems;
            return View(await _productService.GetById(productId));
        }
        [HttpPost]
        public async Task<IActionResult> EditProduct(Product product)
        {

            List<SelectListItem> ListCategoryitems = new List<SelectListItem>();
            // Giả sử myList là danh sách dữ liệu của bạn
            foreach (var obj in (await _categoryService.Gets()))
            {
                ListCategoryitems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListCategoryitems = ListCategoryitems;
            List<SelectListItem> ListBranditems = new List<SelectListItem>();
            // Giả sử myList là danh sách dữ liệu của bạn
            foreach (var obj in await _brandService.Gets())
            {
                ListBranditems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListBranditems = ListBranditems;
            string imageList = HttpContext.Session.GetString("ImageList");
            if (ModelState.IsValid)
            {

                var productDb = await _productService.GetById(product.Id);
                productDb.CategoryId = product.CategoryId;
                productDb.ProductName = product.ProductName;
                productDb.BrandId = product.BrandId;
                productDb.Description = product.Description;
                productDb.UpdateAt = DateTime.Now;
                productDb.Status = product.Status;
                if (imageList == null && productDb.ProductImages.Count() == 0) // check ảnh
                {
                    // Trả về view với thông báo lỗi nếu ModelState không hợp lệ hoặc không có tệp nào được tải lên
                    ModelState.AddModelError("", "Ảnh sản phẩm tối thiểu là 1, vui lòng thêm ảnh.");
                    return View(product);
                }
                if (imageList != null)
                {
                    List<string> imageListAsList = imageList.Split(';').ToList();
                    foreach (var item in imageListAsList)
                    {
                        var createProductImageResult = await _productImageService.Add(new ProductImages() { ProductId = product.Id, ImageUrl = item });
                        // Cập nhật đường dẫn hình ảnh cho sản phẩm

                    }
                }
                var result = await _productService.Update(productDb);
                if (result)
                {

                    HttpContext.Session.Remove("ImageList");
                    return RedirectToAction("Index", "Products", new { @area = "Admin" });
                }

            }

            // Trả về view với thông báo lỗi nếu ModelState không hợp lệ hoặc không có tệp nào được tải lên
            ModelState.AddModelError("", "Vui lòng nhập đầy đủ các trường");
            return RedirectToAction("Edit", null, new { @productId = product.Id });
        }

        public async Task<IActionResult> DeleteProduct(Guid productId)
        {
            var result = await _productService.Delete(productId);
            return RedirectToAction("Index", "Products", new { @area = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName).Trim();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var imageList = HttpContext.Session.GetString("ImageList");
            var updatedImageList = imageList == null ? $"/images/{fileName}" : $"{imageList};/images/{fileName}";

            // Cập nhật danh sách ảnh trong Session
            HttpContext.Session.SetString("ImageList", updatedImageList);

            return Ok();
        }
        [HttpPost]
        public async Task<bool> RemoveImageAsync(string productImageId)
        {
            if (productImageId != null)
            {
                var id = Guid.Parse(productImageId);
                var result = await _productImageService.Delete(id);
                return result;
            }
            return false;
        }
        static string GetInitials(string input) // tạo productcode 
        {
            string[] words = input.Split(' ');
            string initials = "";

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    initials += word[0];
                }
            }

            return initials.ToUpper(); // Chuyển thành chữ hoa
        }

        public async Task<IActionResult> ProductDetail(Guid productId)
        {
            await _productService.UpdateStatusQuantity();
            var lstObj = await _productDetailService.GetByProductId(productId);
            ViewBag.productId = productId;
            return View(lstObj); 
        }
        public async Task<IActionResult> CreateProductDetail(Guid productId)
        {
            List<SelectListItem> ListSizeitems = new List<SelectListItem>();
            foreach (var obj in (await _sizeService.Gets()))
            {
                ListSizeitems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.productId = productId;
            ViewBag.ListSizeitems = ListSizeitems;
            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(ProductDetail productDetail)
        {
            List<SelectListItem> ListSizeitems = new List<SelectListItem>();
            foreach (var obj in (await _sizeService.Gets()))
            {
                ListSizeitems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListSizeitems = ListSizeitems;
            if (ModelState.IsValid)
            {
                var product = await _productService.GetById(productDetail.ProductId);
                var size = await _sizeService.GetById(productDetail.SizeId);
                productDetail.CreateAt = DateTime.Now;
                productDetail.SKU = product.ProductCode +  "-" + size.Name.Trim().Replace(" ", "_").ToUpper();
                productDetail.Status = productDetail.Status;
                var result = await _productDetailService.Add(productDetail);
                if (result)
                {
                    return RedirectToAction("productdetail", null, new { @productId = productDetail.ProductId });
                }
            }
            ModelState.AddModelError("", "Vui lòng nhập đầy đủ các trường");
            return RedirectToAction("CreateProductDetail", null, new { @productId = productDetail.ProductId });
        }
        public async Task<IActionResult> EditProductDetail(Guid productDetailId)
        {
            List<SelectListItem> ListSizeitems = new List<SelectListItem>();
            foreach (var obj in (await _sizeService.Gets()))
            {
                ListSizeitems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListSizeitems = ListSizeitems;
            var productDetail = await _productDetailService.GetById(productDetailId);
            ViewBag.productId = productDetail.ProductId;

            return View(productDetail);
        }
        [HttpPost]
        public async Task<IActionResult> EditProductDetail(ProductDetail productDetail)
        {
            List<SelectListItem> ListSizeitems = new List<SelectListItem>();
            foreach (var obj in (await _sizeService.Gets()))
            {
                ListSizeitems.Add(new SelectListItem()
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
            }
            ViewBag.ListSizeitems = ListSizeitems;
            if (ModelState.IsValid)
            {
                var product = await _productService.GetById(productDetail.ProductId);
                var size = await _sizeService.GetById(productDetail.SizeId);
                productDetail.UpdateAt = DateTime.Now;
                productDetail.SKU = product.ProductCode + "-" + size.Name.Trim().Replace(" ", "_").ToUpper();
                productDetail.Status = productDetail.Status;
                var result = await _productDetailService.Update(productDetail);
                if (result)
                {
                    return RedirectToAction("productdetail", null, new { @productId = productDetail.ProductId });
                }
            }
            ModelState.AddModelError("", "Vui lòng nhập đầy đủ các trường");
            return RedirectToAction("EditProductDetail", null, new { @productId = productDetail.Id });
        }

        public async Task<IActionResult> DeleteProductDetail(Guid Id,Guid productId)
        {
            var result = await _productDetailService.Delete(Id);
            return RedirectToAction("ProductDetail", new { productId = productId });
        }
    }
}