using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YogaStudio.Areas.Identity.Data;
using YogaStudio.Data;

[assembly: HostingStartup(typeof(YogaStudio.Areas.Identity.IdentityHostingStartup))]
namespace YogaStudio.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<YogaStudioContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("YogaStudioContextConnection")));

                services.AddDefaultIdentity<YogaStudioUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<YogaStudioContext>();
            });
        }
    }
}