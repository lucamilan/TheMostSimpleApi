using System.Globalization;
using System.Reflection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "The Most Simple API", Description = "The most Simple API", Version = "v1" });
});
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
   c.SwaggerEndpoint("/swagger/v1/swagger.json", "Simple API V1");
});
app.MapGet("/", () => "The Ultimate Question of Life, the Universe, and Everything is: 42");
app.MapGet("/version", () => Assembly.GetExecutingAssembly().GetName().Version?.ToString());

app.Run();
