global using _3Ecommerce.Shared;
global using _3Ecommerce.Server.Services.ProductService;
global using _3Ecommerce.Server.Services.CategoriesServices;
global using _3Ecommerce.Server.DAL;
global using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ResponseCompression;


var builder = WebApplication.CreateBuilder(args);
var ConStr = builder.Configuration.GetConnectionString("ConStr");
// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddDbContext<Contexto>(options => options.UseSqlite(ConStr));

var app = builder.Build();


app.UseSwaggerUI();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
