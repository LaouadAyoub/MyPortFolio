var builder = WebApplication.CreateBuilder(args);
//private readonly IConfiguration? configuration;

builder.Services.AddMvc();

var app = builder.Build();

//builder.Configuration



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
