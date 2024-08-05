using IntroNet.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CervezeriaContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("aplicacionConexion"));
}
    );

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

/*
 comando para que tome los datos de la base de datos y los pueda publicar 

Scaffold-DbContext "Server=DESKTOP-O2KEFME; Database=cervezeria; Trusted_Connection=True; TrustServerCertificate=True" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Comando por si l abase de datos es modificada y queremos trare los cambvios de la base a el codigo 

Scaffold-DbContext "Server=DESKTOP-O2KEFME; Database=cervezeria; Trusted_Connection=True; TrustServerCertificate=True" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force

 */
