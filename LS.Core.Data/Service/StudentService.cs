using LS.Core.Data.Dto;
using LS.Core.Data.Entity;
using LS.Core.Data.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.Service
{
    public class StudentService : IStudentService
    {
        public string AddStudent(StudentDto stuDto)
        {
            Student stu = new Student();
            stu.STUNAME = stuDto.StudentName;
            stu.STUAGE = stuDto.StuAge;
            stu.STUCLASS = stuDto.StuClass;
            stu.STUSEX = stuDto.StuSex;
            int i = 1;
            //int i = StudentResposity.AddEntities(stu);
            if (i > 0)
            {
                return "添加成功。";
            }
            else 
            {
                return "添加失败。";
            }
        }
    }
}
