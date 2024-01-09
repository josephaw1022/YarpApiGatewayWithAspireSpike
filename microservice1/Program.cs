var builder = WebApplication.CreateBuilder(args);



builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/", () => "Hello, World! This is microservice1! This is visible at the '/' route!");



app.MapDefaultEndpoints();
app.Run();
