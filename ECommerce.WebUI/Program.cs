using ECommerce.Application.Abstract;
using ECommerce.Application.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concerete.EFEntityFramework;
using ECommerce.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession();

#region AddScoped

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<ICustomerDal, EfCustomerDal>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddScoped<IEmployeeDal, EfEmployeeDal>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

#endregion

#region Database registration
var conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<NorthWindDbContext>(opt =>
{
    opt.UseSqlServer(conn);
});
#endregion


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
