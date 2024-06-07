using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace AnimeBackend.Hubs
{
    public class VoiceChannelHub : Hub
    {
        public async Task JoinChannel(string channelName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, channelName);
            await Clients.Group(channelName).SendAsync("UserJoined", Context.ConnectionId);
        }

        public async Task LeaveChannel(string channelName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, channelName);
            await Clients.Group(channelName).SendAsync("UserLeft", Context.ConnectionId);
        }
    }
}
