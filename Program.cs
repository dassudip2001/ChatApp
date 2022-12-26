using Chat;

var builder = WebApplication.CreateBuilder(args);

// single R

builder.Services.AddSignalR();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// register 
app.MapHub<ChatHub>("/ChartHub");

app.Run();

// chart application
public record MassageRequest(string Player ,string Text);
