<<<<<<< HEAD
var builder = WebApplication.CreateBuilder(args);
//private readonly IConfiguration? configuration;

builder.Services.AddMvc();

var app = builder.Build();

//builder.Configuration



app.UseStaticFiles();
app.UseRouting();


app.UseEndpoints(endpoints =>
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Web
>>>>>>> fe2f1836cc52df00a128aec106b8c08fb5b3387c
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}