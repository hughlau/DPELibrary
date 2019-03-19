using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using OrchardCore.Modules;
using System;

/****************************************************************
*   Author：L
*   Time：2019/3/19 16:15:43
*   FrameVersion：2.0
*   Description：
*
*****************************************************************/
namespace Admin
{
    public partial class Startup:StartupBase
    {

        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public override void Configure(IApplicationBuilder builder, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(_configuration["Sample"]))
            {
                throw new Exception(":(");
            }

            routes.MapAreaRoute
            (
                name: "adminHome",
                areaName: "Admin",
                template: "",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
