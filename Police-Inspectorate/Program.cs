using Microsoft.EntityFrameworkCore;
using Police_Inspectorate.Repositories;
using Police_Inspectorate.Repositories.Interfaces;
using PoliceInspectorate.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PoliceInspectorateContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("PoliceInspectorateDb")
    ));

builder.Services.AddScoped<ICaseRepository, CaseRepository>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
