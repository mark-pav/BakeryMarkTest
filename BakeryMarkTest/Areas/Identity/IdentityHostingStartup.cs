using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BakeryMarkTest.Areas.Identity.IdentityHostingStartup))]
namespace BakeryMarkTest.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}