using System;
using ControlApplication.Areas.Identity.Data;
using ControlApplication.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ControlApplication.Areas.Identity.IdentityHostingStartup))]
namespace ControlApplication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ControlApplicationContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ControlApplicationContextConnection")));

                services.AddDefaultIdentity<ControlApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ControlApplicationContext>();
            });
        }
    }
}