using LS.Core.Data.EFCore;
using LS.Core.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.BaseDependcy
{
    /// <summary>
    /// 注入
    /// </summary>
    public class DependcyPackBase
    {

        /// <summary>
        /// 学生仓储
        /// </summary>
        public IRespository<Student> MyStudentRespository { get; set; }
    }
}
