using EL_Nightreigh_Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Добавляем DbContext с прямой строкой подключения
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        "server=mydb-sasha-aalexandr397-031a.h.aivencloud.com;port=13668;username=avnadmin;password=AVNS_jK5JtBXiH0SCCz70Ap3;database=defaultdb",
        ServerVersion.AutoDetect("server=mydb-sasha-aalexandr397-031a.h.aivencloud.com;port=13668;username=avnadmin;password=AVNS_jK5JtBXiH0SCCz70Ap3;database=defaultdb")
    )
);

// Добавляем Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Конфигурация пайплайна
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

app.Run();
