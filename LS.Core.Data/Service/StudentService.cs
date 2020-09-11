using LS.Core.Data.Dto;
using LS.Core.Data.Entity;
using LS.Core.Data.IService;
using LS.Core.Data.SQLDataConnect;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using LS.Core.Data.BaseDependcy;

namespace LS.Core.Data.Service
{
    public class StudentService : DependcyPackBase,IStudentService
    {
        private StudentDataBase _context;

        public StudentService(StudentDataBase context) 
        {
            _context = context;
        }

        public string AddStudent(StudentDto stuDto)
        {
            Student stu = new Student();
            stu.STUNAME = stuDto.StudentName;
            stu.STUAGE = stuDto.StuAge;
            stu.STUCLASS = stuDto.StuClass;
            stu.STUSEX = stuDto.StuSex;
            _context.STUDENT.Add(stu);
            int i = _context.SaveChanges();
            if (i > 0)
            {
                return "添加成功。";
            }
            else 
            {
                return "添加失败。";
            }
        }

        public List<Student> SearchStudent()
        {
           return _context.STUDENT.AsNoTracking().AsQueryable().ToList();
        }
    }
}
