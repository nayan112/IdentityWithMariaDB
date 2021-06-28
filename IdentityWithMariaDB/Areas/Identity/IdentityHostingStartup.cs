using IdentityWithMariaDB.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdentityWithMariaDB.Areas.Identity.IdentityHostingStartup))]
namespace IdentityWithMariaDB.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                //services.AddDbContext<MariaDBContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MariaDBContext>();
            });
        }
    }
}