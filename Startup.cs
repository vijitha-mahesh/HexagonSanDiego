using HexagonSanDiego.Data;
using HexagonSanDiego.Repositories.IRepository;
using HexagonSanDiego.Repositories.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace HexagonSanDiego
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

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {

                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });

                options.AddPolicy("MyCORSPolicy",
                    builder =>
                    {
                        builder.WithOrigins(Configuration.GetSection("AllowedOrigins").Get<string[]>())
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });

            });
            ///////////////////////////////////////////////////  Cors
            
            services.AddControllers().AddJsonOptions(options => {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.DictionaryKeyPolicy = null;

            });
            ////////////////////////////////////////////////// Controllers

            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            /////////////////////////////////////////////////// Context
            services.AddAutoMapper(typeof(Startup));

            ////////////////////////////////////////////////// Mapper
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "hp_proj_1_backend", Version = "v1" });

                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            ////////////////////////////////////////////////////// Swagger 

            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<ILocationRepo, LocationRepo>();
            services.AddScoped<IFloorPlanRepository, FloorPlanRepository>();
            services.AddScoped<IHomePageRepository,HomePageRepository>();
            services.AddScoped<IVertualToursRepository, VertualToursRepository>();


            //////////////////////////////////////////////////////// Auth 
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuerSigningKey = true,
                       IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                       ValidateIssuer = false,
                       ValidateAudience = false
                   };
               });

            //////////////////////////////////////////////////////// Auth
            
             services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HexagonSanDiego v1"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors("MyCORSPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapRazorPages();
               // endpoints.MapControllers();
            });

            
        }
    }
}
