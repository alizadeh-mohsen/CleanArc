using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CleanArc.MVC.Data;
using CleanArc.Infra.Data.Context;
using Microsoft.Extensions.DependencyModel;
using CleanArc.Infra.IoC; // Added this using directive

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
var universityDbConnectionString = builder.Configuration.GetConnectionString("UniversityDBConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDbContext<UniversityDbContext>(options =>
options.UseSqlServer(universityDbConnectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter(); // This line now works because of the added using directive

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

DependencyContainer.RegisterServices(builder.Services); // Register application services

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

app.Run();
