using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using APIFINALMOBILE.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<APIFINALMOBILEContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("APIFINALMOBILEContext") ?? throw new InvalidOperationException("Connection string 'APIFINALMOBILEContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
