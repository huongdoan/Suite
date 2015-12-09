using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using AngularJSSuite.Service.Interface;
using AngularJSSuite.Service.Implement;
using AngularJSSuite.Service.EF;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Runtime;
using Microsoft.Framework.Configuration;

namespace AngularJSSuite
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            // Setup configuration sources.
            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .AddJsonFile($"config.{env.EnvironmentName}.json", optional: true);

            if (env.IsEnvironment("Development"))
            {
                // This reads the configuration keys from the secret store.
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                configurationBuilder.AddUserSecrets();
            }
            configurationBuilder.AddEnvironmentVariables();
            Configuration = configurationBuilder.Build();
        }

        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var Configuration =  new ConfigurationBuilder().AddJsonFile("config.json").AddEnvironmentVariables().Build();
            AddServiceDI(services);

            services.AddEntityFramework().AddSqlServer().AddDbContext<SuiteDBContext>(options =>
            {
                options.UseSqlServer(Configuration["Data:ConnectionString"]);
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.MinimumLevel = LogLevel.Information;
            loggerFactory.AddConsole();

            // Configure the HTTP request pipeline.

            //// Add the following to the request pipeline only in development environment.
            //if (env.IsDevelopment())
            //{
            //    app.UseBrowserLink();
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    // Add Error handling middleware which catches all application specific errors and
            //    // send the request to the following path or controller action.
            //    app.UseExceptionHandler("/Home/Error");
            //}

            // Add static files to the request pipeline.
            app.UseStaticFiles();

            // Add MVC to the request pipeline.
            app.UseMvc();
          
        }

        private void AddServiceDI(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IApplicationDataService, ApplicationDataService>();
            services.AddSingleton<IUserService,UserService>();
            services.AddSingleton<IUserService, UserService>();


        }
    }
}
