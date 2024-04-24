using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddMvc().AddRazorPagesOptions(options =>
{
    options.Conventions.AddAreaPageRoute("Home", "/Home/Home/", "");

    options.Conventions.AddPageRoute("/Home/Home", "");
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

app.UseAuthorization();
app.UseEndpoints(endpoints =>

{     // controller route ayarlama

    endpoints.MapRazorPages();
    endpoints.MapControllerRoute(
        name: "Home",
        pattern: "{controller=Home}/{action=Home}");
    //endpoints.MapDefaultControllerRoute();
});
app.MapRazorPages();

app.Run();
