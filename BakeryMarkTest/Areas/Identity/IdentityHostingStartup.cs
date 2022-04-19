using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BakeryMarkTest.Areas.Identity.IdentityHostingStartup))]
namespace BakeryMarkTest.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                //services.AddDbContext(options =>
                //options.UseSqlServer(
                //context.Configuration.GetConnectionString(“YouPodDbContextConnection”)));

                //services.AddDefaultIdentity(options => options.SignIn.RequireConfirmedAccount = false) //false for now and when I will configure SendGrid this should change to true
                //.AddEntityFrameworkStores();
            });
        }
    }
}

