var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapMethods("/", new[] { "HEAD" }, () => { });

var responseString = Environment.GetEnvironmentVariable("PING_SERVER_GET_RESPONSE");
app.MapGet("/", async () => { return responseString ?? string.Empty; });

app.Run();
