﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShittyWebApp3.Startup))]
namespace ShittyWebApp3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
