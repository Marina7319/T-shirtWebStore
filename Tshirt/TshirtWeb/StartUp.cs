using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using T_shirt.Data.Data;
using T_shirt.Data.Repository;
using T_shirt.Data.Repository.IRepository;
using T_shirt.Models.Models;
using T_shirt.Utility;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<TshirtStoreDbContext>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext")));

//builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<TshirtStoreDbContext>()
//.AddDefaultTokenProviders();
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
       options.User.RequireUniqueEmail = true;
       options.Password.RequireDigit = true;
       options.Password.RequireLowercase = true;
      options.Password.RequireUppercase = true;
     options.Password.RequireNonAlphanumeric = true;
     options.Password.RequiredLength = 12;
    options.SignIn.RequireConfirmedEmail = false;
})
    .AddEntityFrameworkStores<TshirtStoreDbContext>()
   .AddDefaultTokenProviders();



builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});
builder.Services.AddAuthentication().AddFacebook(options =>
{
    options.AppId = "629588792648867";
    options.AppSecret = "4517804cfa8338ff3c80927284f87632";
});

builder.Services.AddAuthentication().AddGoogle(options =>
{
    options.ClientId = "888667316056-t0dp2j449c56ap1vdlshaj1t1u32fjfu.apps.googleusercontent.com";
    options.ClientSecret = "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";

});
builder.Services.AddRazorPages();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options => {
    options.IdleTimeout = TimeSpan.FromMinutes(100);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();


var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
   // var db = scope.ServiceProvider.GetRequiredService<TshirtStoreDbContext>();
  //  db.Database.Migrate();
//}


    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // app.UseExceptionHandler("/error");
        app.UseHsts();
    }

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();


app.MapControllerRoute(
    name: "default",
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name:"categoryFilter",
    pattern: "List/{action}/{category?}", defaults: new {Controller = "List", action="List"});

app.Run();

