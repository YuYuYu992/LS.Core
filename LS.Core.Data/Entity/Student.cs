using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.Entity
{
    public class Student : EntityBase
    {
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string STUNAME { get; set; }

        /// <summary>
        /// 学生性别
        /// </summary>
        public string STUSEX { get; set; }

        /// <summary>
        /// 学生年龄
        /// </summary>

        public int STUAGE  { get; set; }

        /// <summary>
        /// 所属班级
        /// </summary>
        public string STUCLASS { get; set; }
    }
}
