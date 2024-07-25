using Microsoft.EntityFrameworkCore;
using Crud_Core_Mvc.Data;
using Crud_Core_Mvc.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Crud_Core_MvcContext>(options => options.UseMySQL("server=localhost;database=Crud1;user=root;password=Dalurabk@24"));


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<DepartmentService>();


//SeedingService seedingService = new SeedingService();
//seedingService.seed();

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
