using System;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloMvcApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddSingleton<IFoo>((_)=>makeFoo());
            services.AddMvcCore()
                    .AddJsonFormatters();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, IFoo foo)
        {
            loggerFactory.AddConsole(LogLevel.Debug);

            app.UseMvc();
        }

        public IFoo makeFoo()
        {
            throw new NotImplementedException();
        }
    }
    public interface IFoo {}
}
