using Portfolio.Models;
using Portfolio.Repositories;
using Portfolio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);


builder.Services.AddScoped<IProfile, ProfileService>();
builder.Services.AddScoped<DbContext>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseStaticFiles();
app.UseDefaultFiles();
app.UseMvcWithDefaultRoute();
app.UseAuthorization();


app.Run();
