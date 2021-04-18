using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SimpleChatAPI.Api.Models;

namespace SimpleChatAPI.Api.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}