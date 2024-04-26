using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Share.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourLeafCloverShoe.Areas.Identity.Pages.Account.Manage
{
    public class OrderDetailModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IOrderService _orderService;
        public Order Order { get; set; }
        public OrderDetailModel(UserManager<User> userManager, IOrderService orderService)
        {

            _userManager = userManager;
            _orderService = orderService;
        }
        public async Task<IActionResult> OnGetAsync(Guid orderId)
        {
            var user = await _userManager.GetUserAsync(User);
            Order = (await _orderService.Gets()).FirstOrDefault(c => c.UserId == user.Id&&c.Id==orderId);
            return Page();
        }
    }
}
