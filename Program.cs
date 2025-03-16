var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/message", () => "Hello From .NET Core API!");

app.Run();
