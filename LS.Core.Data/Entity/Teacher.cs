using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.Entity
{
    public class Teacher : EntityBase
    {
        /// <summary>
        /// 老师姓名
        /// </summary>
        public string TEACHERNAME { get; set; }

        /// <summary>
        /// 所属班级
        /// </summary>
        public string CLASSID { get; set; }
    }
}
