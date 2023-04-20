var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Professor Das. I followed the tutorial.");

app.Run();

