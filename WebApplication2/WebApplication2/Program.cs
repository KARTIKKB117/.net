var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//app.MapGet("/add/{a}/{b}", (int a, int b) => $"Sum = {a + b}");

app.MapGet("/subtract/{a}/{b}", (int a, int b) => "Difference=" + (a - b));

app.Run();
