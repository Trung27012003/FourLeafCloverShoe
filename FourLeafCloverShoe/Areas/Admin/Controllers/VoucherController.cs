using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Share.Models;
using FourLeafCloverShoe.Share.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FourLeafCloverShoe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VoucherController : Controller
    {
        private IUserVoucherService _userVoucherService;
        private IVoucherService _voucherService;
        private readonly IRanksService _ranksService;
        private readonly UserManager<User> _userManager;

        public VoucherController(IVoucherService voucherService,IUserVoucherService userVoucherService,IRanksService ranksService,UserManager<User> userManager)
        {
            _userVoucherService = userVoucherService;
            _voucherService = voucherService;
            _ranksService = ranksService;
            _userManager = userManager;

        }
        public async Task<IActionResult> Index()
        {
            return View((await _voucherService.Gets()).OrderByDescending(c=>c.CreateDate));
        }
        public async Task<IActionResult> Create()
        {
            var ranks = (await _ranksService.Gets()).Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Name
            }).ToList();
            ViewBag.Ranks = ranks;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(VoucherViewModel voucherViewModel)
        {
            var lstVoucherDb = await _voucherService.Gets();
            var ranks = (await _ranksService.Gets()).Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Name
            }).ToList();
            ViewBag.Ranks = ranks;
            if ( !lstVoucherDb.Any(c=>c.VoucherCode== voucherViewModel.VoucherCode))
            {
                if (voucherViewModel.Ranks.Count()<=0)
                {
                    ModelState.AddModelError("Thong bao", "Vui long chon doi tuong ap dung");
                    return View(voucherViewModel);
                }
                var voucherNew = new Voucher()
                {
                    CreateDate = DateTime.Now,
                    StartDate = voucherViewModel.StartDate,
                    EndDate = voucherViewModel.EndDate,
                    Title = voucherViewModel.Title,
                    Status = voucherViewModel.Status,
                    MinimumOrderValue = voucherViewModel.MinimumOrderValue,
                    MaximumOrderValue = voucherViewModel.MaximumOrderValue,
                    Quantity = voucherViewModel.Quantity,
                    VoucherValue = voucherViewModel.VoucherValue,
                    VoucherCode = voucherViewModel.VoucherCode,
                    VoucherType = voucherViewModel.VoucherType
                };
                var result = await _voucherService.Add(voucherNew); // tao voucher
                if (result)
                {
                    var lstUserVoucher = new List<UserVoucher>();
                    var allUser = await _userManager.Users.ToListAsync();
                    var newList = allUser.Where(c => voucherViewModel.Ranks.Any(y => y == c.Ranks.Name));
                    foreach (var item in newList)
                    {
                        var newUserVoucher = new UserVoucher()
                        {
                            Status = 1,
                            UserId = item.Id,
                            VoucherId = voucherNew.Id
                        };
                        lstUserVoucher.Add(newUserVoucher);
                    }
                    var resultAddUserVoucher = await _userVoucherService.AddMany(lstUserVoucher);
                    return RedirectToAction("Index");

                }
            }
            ModelState.AddModelError("Thong bao","Loi trung ma voucher");
            return View(voucherViewModel);
        }

    }
}
