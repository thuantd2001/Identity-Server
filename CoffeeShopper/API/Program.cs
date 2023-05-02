using API.Services;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));


#region service
builder.Services.AddScoped<ICoffeeShopService, CoffeeShopService>();
#endregion


var app = builder.Build();

app.MapControllers();

app.Run();
