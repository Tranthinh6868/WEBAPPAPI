using Microsoft.EntityFrameworkCore;
using WebApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StoreContext>(p => p.UseSqlServer(builder.Configuration.GetConnectionString("WebStore")));
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();

app.Run();
