using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AspNetSignalRSamples.SignalR.Startup))]

namespace AspNetSignalRSamples.SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.MapSignalR();

            app.MapAzureSignalR("AspNetSignalRSamples");
        }
    }
}