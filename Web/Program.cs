var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

var app = builder.Build();





app.UseStaticFiles();
app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute
    ("defaultRoute",
    "{controller=Home}/{action=Index}/{id?}");
});

//app.MapGet("/", () => "Hello World!");

app.Run();
