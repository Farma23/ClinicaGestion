using Microsoft.EntityFrameworkCore;
using ClinicaGestion.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ClinicaContext>(options =>
    options.UseSqlite("Data Source=clinica.db"));

builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ClinicaContext>();
    db.Database.EnsureCreated();
}

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
    pattern: "{controller=Patients}/{action=Index}/{id?}");

app.Run();
