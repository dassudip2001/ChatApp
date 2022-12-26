using Microsoft.AspNetCore.SignalR;

namespace Chat;
public class ChatHub : Hub
{
    public async Task sendMassageAsync(MassageRequest massage)
    {
        await Clients.All.SendAsync("show massage", massage);
    }
}