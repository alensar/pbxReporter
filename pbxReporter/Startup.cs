using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace pbxReporter
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(env.ContentRootPath)
             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
             .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();

            //Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<Data.Asterisk.asteriskContext>(opt =>
             opt.UseMySql(Configuration.GetConnectionString("mySqlAsterisk"))
            );

            services.AddDbContext<Data.Asteriskcdrdb.asteriskcdrdbContext>(opt =>
             opt.UseMySql(Configuration.GetConnectionString("mySqlAsteriskcdrdb"))
            );

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                       .AddCookie(o =>
                       {
                           o.LoginPath = new PathString("/Account/Login/");
                       });

            services.AddMvc(config =>
            {
                //config.ModelBinderProviders.Insert(0, new InvariantDecimalModelBinderProvider());//ovo je sa core.rgt.ba aplikaijce kada hocemo da binadmo . kao 
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));

            }
                ).AddJsonOptions(options =>
                {

                    options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                })
            ;

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            /* da možæžemo debaguirati na linuxu
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            */
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            var locale = "bs-Latn-BA";
            RequestLocalizationOptions localizationOptions = new RequestLocalizationOptions
            {
                SupportedCultures = new List<CultureInfo> { new CultureInfo(locale) },
                SupportedUICultures = new List<CultureInfo> { new CultureInfo(locale) },
                DefaultRequestCulture = new RequestCulture(locale)
            };
            app.UseRequestLocalization(localizationOptions);


            app.UseAuthentication();

            app.UseStaticFiles();
            //app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
