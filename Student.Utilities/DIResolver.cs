using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Student.Core;
using Student.Resources;
using Student.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Student.Core.IRepository;
using Student.Core.IServices;


namespace Student.Utilities
{
    public class DIResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {

            #region Context accesor
            // this is for accessing the http context by interface in view level
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion

            #region Services

            services.AddScoped<IServices, TestServices>();

            #endregion

            #region Repository

            services.AddScoped<IRepository, TestRepository>();

            #endregion

        }
    }
}
