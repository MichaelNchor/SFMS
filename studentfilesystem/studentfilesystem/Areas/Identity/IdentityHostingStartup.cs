using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using studentfilesystem.Models;

[assembly: HostingStartup(typeof(studentfilesystem.Areas.Identity.IdentityHostingStartup))]
namespace studentfilesystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<studentfilesystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<studentfilesystemContext>();

            });
        }
    }
}