using Microsoft.AspNetCore.SignalR;

namespace ServerHub
{
    public class ChatHub : Hub
    {
        public async Task SendMessage (string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMEssage", user, message);
        }
    }
}
