using Microsoft.AspNetCore.SignalR;

namespace ServerHub
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // takes the name of the method to be invoked on the client-side
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
