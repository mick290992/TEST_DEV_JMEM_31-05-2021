using System;
using Front_Control.Areas.Identity.Data;
using Front_Control.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Front_Control.Areas.Identity.IdentityHostingStartup))]
namespace Front_Control.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Front_ControlContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Front_ControlContextConnection")));

                services.AddDefaultIdentity<Front_ControlUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Front_ControlContext>();
            });
        }
    }
}