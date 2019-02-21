using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MordenPortfolio.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string colour)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, colour);
        }
    }
}
