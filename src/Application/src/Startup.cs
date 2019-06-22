using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DotnetExamples
{
    public class Startup
    {
        private readonly ILoggerAdapter<Startup> _log;
        private readonly IHostingEnvironment _env;
        private readonly IConfiguration _config;


        public Startup(
            ILogger<Startup> log,
            IHostingEnvironment env,            
            IConfiguration config)
        {
            _log = new LoggerAdapter<Startup>(log);
            _env = env;
            _config = config;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddHealthChecks();
            services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env)
        {
            app.UseMvc();
        }
    }
}