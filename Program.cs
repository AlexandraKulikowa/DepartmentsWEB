using DepartmentsWEB.db;
using DepartmentsWEB.db.Interfaces;
using DepartmentsWEB.db.Repositories;
using DepartmentsWEB.Helpers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("Employees")));

builder.Services.AddTransient<IDepartmentsRepository, DepartmentsDbRepository>();
builder.Services.AddTransient<IPersonsRepository, PersonsDbRepository>();
builder.Services.AddAutoMapper(typeof(AppMappingProfileDepartment), typeof(AppMappingProfilePerson));


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();