using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Police_Inspectorate.Repositories;
using Police_Inspectorate.Repositories.Interfaces;
using PoliceInspectorate.Context;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PoliceInspectorateContextConnection") ?? throw new InvalidOperationException("Connection string 'PoliceInspectorateContextConnection' not found.");

builder.Services.AddDbContext<PoliceInspectorateContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddRazorPages();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<PoliceInspectorateContext>();
builder.Services.AddDbContext<PoliceInspectorateContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("PoliceInspectorateContextConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<PoliceInspectorateContext>(options => options.UseSqlServer(
//    builder.Configuration.GetConnectionString("GConnection")
//    ));

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
