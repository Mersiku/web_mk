using Microsoft.EntityFrameworkCore;
using web_mk.DAL;
using web_mk.Models.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FilmsContext>(options=>options.UseSqlServer(
    builder.Configuration.GetConnectionString("LocalDb")));
//// TO SKOPIOWANO Z GORY + nowy context
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IdentityAppContext>(options=>options.UseSqlServer(
    builder.Configuration.GetConnectionString("LocalDb")));

builder.Services.AddSession();

//// dodajemy
builder.Services.AddIdentity<AppUser, AppRole>(options =>
{//zmiana ustawien logowania
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 4;

    options.User.RequireUniqueEmail = true;
}) .AddEntityFrameworkStores<IdentityAppContext>();

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

app.UseAuthorization(); //// to juz jest
app.UseAuthentication(); //// najpierw autoryzacja potem autentykacja
app.UseSession();

app.MapControllerRoute(
    name: "Details",
    pattern: "{action}/{filmId}",
    defaults: new { controller = "Films", action = "Details" }
    );

app.MapControllerRoute(
    name: "StaticSites",
    pattern: "Info/{viewName}",
    defaults: new {controller = "Home", action = "footerSites"}
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Categories",
    pattern: "{categoryName}",
    defaults: new { controller = "Films", action = "FilmsList" }
    );

app.Run();
