using FourLeafCloverShoe.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using X.PagedList;

namespace FourLeafCloverShoe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManagerOrderController : Controller
    {
        private readonly IOrderService _iorderService;
        private readonly IOrderItemService _iorderItemService;
        private readonly IProductDetailService _productDetailService;
        private readonly IProductService _productService;

        public ManagerOrderController(IOrderService iorderService, IOrderItemService iorderItemService, IProductDetailService productDetailService, IProductService productService)
        {
            _iorderService = iorderService;
            _iorderItemService = iorderItemService;
            _productDetailService = productDetailService;
            _productService = productService;
        }

        public async Task<IActionResult> IndexAsync(int? page, int?[] status, string searchText, DateTime? startDate, DateTime? endDate)
        {
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.SelectedStatuses = status;
            ViewBag.searchText = searchText;
            ViewBag.startDate = startDate;
            ViewBag.endDate = endDate;
            var lst = await _iorderService.Gets();
            var lstOrder = lst.Where(c => c.Id != null);
            if (status != null && status.Length >0)
            {
                lstOrder = lstOrder.Where(c => status.Contains(c.OrderStatus)).ToList();
            }
            if (searchText != null)
            {
                lstOrder =  lstOrder.Where(c => c.OrderCode.ToLower().Contains(searchText.ToLower()));
            }
            if (startDate != null && endDate != null)
            {
                lstOrder = lstOrder.Where(c => c.CreateDate >= startDate && c.CreateDate <= endDate);
            }
            return View(lstOrder.ToPagedList(pageNumber, pageSize));
        }
       
        public async Task<IActionResult> OrderDetail(Guid orderId)
        {
            var lstOrderIterm = await _iorderItemService.GetByIdOrder(orderId);
            return View(lstOrderIterm);
        }
        public async Task<IActionResult> ChangeStatus(Guid orderId)
        {
            var lstOrderIterm = await _iorderItemService.GetByIdOrder(orderId);
            return View(lstOrderIterm);
        }
    }
}
