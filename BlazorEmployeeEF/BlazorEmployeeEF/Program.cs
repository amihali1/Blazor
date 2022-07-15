using BlazorEmployeeEF.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<AppSettingsService>();

builder.Services.AddDbContext<SqlDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlDbContext")));

// Enables detailed error option for Blazor so detailed error messages appear in dev console
builder.Services.AddServerSideBlazor().AddCircuitOptions(o => o.DetailedErrors = true);

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapBlazorHub();
    endpoints.MapFallbackToPage("/_Host");
});

app.Run();
