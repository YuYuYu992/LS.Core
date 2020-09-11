using LS.Core.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.SQLDataConnect
{
    public class TemporaryDbContextFactory : IDesignTimeDbContextFactory<StudentDataBase>
    {
        public StudentDataBase CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentDataBase>();
            var connect = AppConfigurtaionServices.Configuration["ConnectionStrings:Default"];
            // 设置连接字符串
            optionsBuilder.UseSqlServer(connect);
            // 创建上下文实例
            return new StudentDataBase(optionsBuilder.Options);
        }
    }
}
