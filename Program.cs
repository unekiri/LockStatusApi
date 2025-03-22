var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/lock-status", () => Results.Json(new { lockstatus = "Hello From API!" }));

app.MapPost("/api/lock-status", async(HttpRequest req) =>
{
   using var reader = new StreamReader(req.Body);
   var body = await reader.ReadToEndAsync();
    Console.WriteLine($"受信データ: {body}");
    return Results.Ok("データ受取完了");
}); 

app.Run();
