using Microsoft.AspNetCore.SignalR;
using SignalRChatApp.Hubs.Clients;

namespace SignalRChatApp.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
    }
}
