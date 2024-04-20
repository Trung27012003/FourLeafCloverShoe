using FourLeafCloverShoe.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FourLeafCloverShoe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VoucherController : Controller
    {
        private IUserVoucherService _userVoucherService;
        private IVoucherService _voucherService;

        public VoucherController(IVoucherService voucherService,IUserVoucherService userVoucherService)
        {
            _userVoucherService = userVoucherService;
            _voucherService = voucherService;
        }
        public async Task<IActionResult> Index()
        {
            return View((await _voucherService.Gets()).OrderByDescending(c=>c.CreateDate));
        }
        public async Task<IActionResult> Create()
        {
            return View((await _voucherService.Gets()).OrderByDescending(c=>c.CreateDate));
        }

    }
}
