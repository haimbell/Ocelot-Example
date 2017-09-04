using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace OcelotEmptyCore1._1_V2
{
    public class Program
    {
        public static void Main(string[] args)
        {
			//var host = new WebHostBuilder()
			//    .UseKestrel()
			//    .UseContentRoot(Directory.GetCurrentDirectory())
			//    .UseIISIntegration()
			//    .UseStartup<Startup>()
			//    .UseUrls("http://localhost:5001")
			//    .Build();

			//host.Run();

			IWebHostBuilder builder = new WebHostBuilder();

			builder.ConfigureServices(s => {
				s.AddSingleton(builder);
			});

			builder
                .UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseStartup<Startup>()
                .UseUrls("http://localhost:5001");

			var host = builder.Build();

			host.Run();
        }
    }
}
