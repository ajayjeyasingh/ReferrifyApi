﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ReferMeApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using AutoMapper;

namespace ReferMeApi
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
            services.AddCors(c => c.AddPolicy("CorsPolicy", policyBuilder =>
            {
                policyBuilder.AllowAnyOrigin()
                             .AllowAnyMethod()
                             .AllowAnyHeader();
            }));

            services.AddAutoMapper();
            services.AddDbContext<ReferMeDbContext>(options => options.UseMySql(Configuration.GetConnectionString("Production")));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("CorsPolicy");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            
        }
    }
}