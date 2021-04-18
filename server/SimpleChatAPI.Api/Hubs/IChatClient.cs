using System.Threading.Tasks;
using SimpleChatAPI.Api.Models;

namespace SimpleChatAPI.Api.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}