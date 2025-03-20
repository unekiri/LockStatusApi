var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/message", () => Results.Json(new { message = "Hello From API!" }));

app.Run();
