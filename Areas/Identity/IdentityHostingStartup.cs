using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(GrowX.Areas.Identity.IdentityHostingStartup))]
namespace GrowX.Areas.Identity
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