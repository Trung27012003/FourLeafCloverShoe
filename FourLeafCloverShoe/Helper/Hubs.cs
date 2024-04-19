using Microsoft.AspNetCore.SignalR;

namespace FourLeafCloverShoe.Helper
{
    public class Hubs : Hub
    {
        public async Task alertToAdmin(string message,bool status)
        {
            await Clients.All.SendAsync("alertToAdmin", message,status);
        }
    }
}
