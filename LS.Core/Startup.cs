using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using LS.Core.Data.BaseDependcy;
using LS.Core.Data.EFCore;
using LS.Core.Data.IService;
using LS.Core.Data.Service;
using LS.Core.Data.SQLDataConnect;
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

namespace LS.Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           // provider = serviceProvider;
        }

        public IConfiguration Configuration { get; }
       // private IServiceProvider provider;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddDbContext<StudentDataBase>();
            services.AddDbContext<StudentDataBase>(options =>
            {
                var connectionString = this.Configuration["ConnectionStrings:Default"];
                options.UseSqlServer(connectionString);
            });
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "YuYuYu992 API", Version = "v1" });
                // ��ȡxml�ļ���
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // ��ȡxml�ļ�·��
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // ��ӿ�������ע�ͣ�true��ʾ��ʾ������ע��
                options.IncludeXmlComments(xmlPath, true);
            });

            services.AddScoped(typeof(IRespository<>), typeof(Respository<>));
            services.AddScoped<IStudentService, StudentService>();
            var provider = services.BuildServiceProvider();
            var contxt = provider.GetService(typeof(StudentDataBase));
            Loatar.Instance().SerProvider(provider);

            // ��д�Ŀ�������
            services.AddControllers();
             
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // ���Swagger�й��м��
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "YuYuYu992 v1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
