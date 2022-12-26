using Microsoft.AspNetCore.SignalR;

namespace Chat;
public class ChatHub : Hub
{
    public async Task sendMassageAsync(MassageRequest massage)
    {
     


    //  date time with massage
        // MassageResponse response =
        //  new(massage.Player,massage.Text,DateTimeOffset.UtcNow);
        // norma; massageResponse
        await Clients.All.SendAsync("show massage", massage);
    }
}