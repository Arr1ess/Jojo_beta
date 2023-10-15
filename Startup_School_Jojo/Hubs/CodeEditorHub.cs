using BlazorMonaco.Editor;
using Microsoft.AspNetCore.SignalR;

namespace Startup_School_Jojo.Hubs
{
    public class CodeEditorHub : Hub
    {
        public async Task SendMessage(TextModel message, string text)
        {
            await Clients.All.SendAsync("ReceiveMessage", message, text);
        }
    }
}
