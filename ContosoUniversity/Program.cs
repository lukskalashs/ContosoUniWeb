using ContosoUniversity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using ContosoUniversity.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

//Configure services
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

//Database Option 1: SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Database Option 2: SQLite 
//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

//Identity Database Option 1: SQL Server
builder.Services.AddDbContext<AppIdentityDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection")));

//Identity Database Option 2: SQLite 
//builder.Services.AddDbContext<AppIdentityDbContext>(options =>
//    options.UseSqlite(builder.Configuration.GetConnectionString("IdentityConnection")));


//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//      .AddEntityFrameworkStores<AppIdentityDbContext>();


builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireDigit = false;
    options.User.RequireUniqueEmail = true;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
   
}).AddEntityFrameworkStores<AppIdentityDbContext>();



builder.Services.AddScoped<IPasswordValidator<IdentityUser>, CustomPasswordValidator>();
builder.Services.AddScoped<IUserValidator<IdentityUser>, CustomUserValidator>();
var app = builder.Build();

//Configure middleware
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "sortingpage",
    pattern: "Students/OrderBy{sortBy}/Page{page}",
    defaults: new { Controller = "Students", action = "Index", page = 1 });

app.MapControllerRoute(
    name: "sorting",
    pattern: "Students/OrderBy{sortBy}",
    defaults: new { Controller = "Students", action = "Index" });

// e.g. /Students/Page2)
app.MapControllerRoute(
    name: "pagination",
    pattern: "Students/Page{page}",
    defaults: new { Controller = "Students", action = "Index", page = 1 });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

SeedData.EnsurePopulated(app);
SeedIdentityData.EnsurePopulated(app);

app.Run();
