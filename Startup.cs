using corewebapioracle.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OData.Edm;
using Microsoft.AspNetCore.OData.Routing.Conventions;
using ODataRoutingSample.Models;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.OData.Batch;
using Microsoft.OData;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Swashbuckle.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Identity.Web;
using Microsoft.OpenApi;
using Microsoft.AspNet.OData;
using System.Web.Http;

namespace corewebapioracle
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }






        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

                                          
            services.Configure<DataContext>(Configuration.GetSection("DefaultConnection"));


            services.AddDbContext<DataContext>(opt => opt.UseOracle(Configuration.GetConnectionString("DefaultConnection")));

            IEdmModel model0 = EdmModelBuilder.GetEdmModel();

            services.AddControllers()
                .AddOData(opt => opt.Count().Filter().Expand().Select().OrderBy().SetMaxTop(10)
                    .AddRouteComponents(model0)
                    
                );
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
           


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "corewebapioracle", Version = "v1" });
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows()
                    {
                        Implicit = new OpenApiOAuthFlow()
                        {
                            AuthorizationUrl = new Uri("https://login.microsoftonline.com/ebd70b07-224b-4900-8332-2885c0a4a186/oauth2/v2.0/authorize"),
                            TokenUrl = new Uri("https://login.microsoftonline.com/ebd70b07-224b-4900-8332-2885c0a4a186/oauth2/v2.0/token"),
                            Scopes = new Dictionary<string, string>
                            {
                                { "api://54bc0d1e-1b1a-4c79-92f5-9c03e9ebd9fc/Full.Access", "Reads the corewebapioracle" }
                            }
                        }
                    }
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                     {
                     new OpenApiSecurityScheme
                        {
                        Reference = new OpenApiReference
                        {
                        Type = ReferenceType.SecurityScheme,
                        Id = "oauth2"
                        },
                                Scheme = "oauth2",
                                Name = "oauth2",
                                In = ParameterLocation.Header
                     },
                        new List<string>()
                     }
                });
            
            });
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));
        }






        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "corewebapioracle v1");
                
                c.OAuthClientId("54bc0d1e-1b1a-4c79-92f5-9c03e9ebd9fc");
                c.OAuthClientSecret("9V0GTw8c0VUn_~~gBJ2eSSobL-NL9GAomS");
                c.OAuthUseBasicAuthenticationWithAccessCodeGrant();

            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                                                                
            }

            app.UseHttpsRedirection();
                                  
            app.UseRouting();
            app.UseCors(option => option
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();
            

            app.Use(next => db =>
            {
                var endpoint = db.GetEndpoint();
                if (endpoint == null)
                {
                    return next(db);
                }

                return next(db);
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });

        }

        



    }
}
