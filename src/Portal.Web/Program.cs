using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Portal.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseSerilog((hostingContext, logger) =>
                     {
                         logger.WriteTo.Console();
                         logger.WriteTo.SQLite(hostingContext.Configuration.GetSection("Logging:Sqlite").Value);
                     });

                    webBuilder.UseStartup<Startup>();
                });
        //    public static void Main(string[] args)
        //    {
        //        var host = CreateWebHostBuilder(args).Build();

        //        host.Run();
        //    }

        //    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //        WebHost.CreateDefaultBuilder(args)
        //        //.UseServiceProviderFactory()

        //            .UseSerilog((hostingContext, logger) =>
        //            {
        //                logger.WriteTo.Console();
        //                logger.WriteTo.SQLite(hostingContext.Configuration.GetSection("Logging:Sqlite").Value);
        //            })
        //        .UseServiceProviderFactory(new AutofacServiceProviderFactory())
        //            .UseStartup<Startup>();
        //}
    }
}
