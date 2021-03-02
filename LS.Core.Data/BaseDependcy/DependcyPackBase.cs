using LS.Core.Data.EFCore;
using LS.Core.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.BaseDependcy
{
    public class ServiceLotar
    {
        public IServiceProvider Provider;
        public static ServiceLotar Instance()
        {
            return new ServiceLotar();
        }
        public void SetProvider(IServiceProvider serviceProvider)
        {
            Provider = serviceProvider;
        }
        public object GetService()
        {
            return Provider.GetService(typeof(IRespository<Student>));
 
        }


    }
    public interface IDependcyPackBase
    {

    }
    /// <summary>
    /// 注入
    /// </summary>
    public class DependcyPackBase //: IDependcyPackBase
    {
       
        public DependcyPackBase()
        {
            var sevice = ServiceLotar.Instance().GetService();
           // MyStudentRespository = _provider.GetService(typeof(IRespository<Student>)) as IRespository<Student>;
        }
        //public DependcyPackBase {


        /// <summary>
        /// 学生仓储
        /// </summary>
        public IRespository<Student> MyStudentRespository { get; set; }
    }
}
