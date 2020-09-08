using SignalRChatApp.Models;
using System.Threading.Tasks;

namespace SignalRChatApp.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
