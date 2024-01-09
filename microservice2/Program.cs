var builder = WebApplication.CreateBuilder(args);


builder.AddServiceDefaults();

var app = builder.Build();


app.MapDefaultEndpoints();

app.MapGet("/", () => "This is Microservice 2! This is visible at the '/admin' route!");

app.MapGet("/about", () => "This is Microservice 2 about endpoint! This is visible at the '/admin/about' route!");

app.Run();
