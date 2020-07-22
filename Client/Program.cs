using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorAnimate;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace PortfolioSite.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            builder.Services.Configure<AnimateOptions>(options => {
                options.Animation = Animations.FadeIn;
                options.Duration = TimeSpan.FromMilliseconds(1000);
            });

            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
