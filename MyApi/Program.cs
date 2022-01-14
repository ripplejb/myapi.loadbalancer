var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var uid = Guid.NewGuid();

app.MapGet("/", () => $"Hello World! {uid.ToString()}");

app.Run();