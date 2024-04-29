using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MoviesApp.Data;
using MoviesApp.HttpHandlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<MoviesService>();
builder.Services.AddScoped<StorageService>();
builder.Services.AddScoped(sp => new HttpClient(new CustomHeaderHandler()) 
{ 
    BaseAddress = new Uri("https://api.themoviedb.org/3/") 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
