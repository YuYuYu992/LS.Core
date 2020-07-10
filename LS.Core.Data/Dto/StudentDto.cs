using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.Dto
{
    public class StudentDto
    {
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// 学生性别
        /// </summary>
        public string StuSex { get; set; }

        /// <summary>
        /// 学生年龄
        /// </summary>

        public int StuAge { get; set; }

        /// <summary>
        /// 所属班级
        /// </summary>
        public string StuClass { get; set; }
    }
}
