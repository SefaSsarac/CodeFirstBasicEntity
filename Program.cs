using CodeFirstBasic.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var connetionString = builder.Configuration.GetConnectionString("default");

builder.Services.AddDbContext<PatikaFirstDbContext>(options => options.UseSqlServer(connetionString));

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
