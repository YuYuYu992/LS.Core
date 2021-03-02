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
using LS.Core.Data.EFCore;

namespace LS.Core.Data.Service
{
    public class StudentService :IStudentService
    {
       // private StudentDataBase _context;
        private IRespository<Student> StudentRepository;

        public StudentService(IRespository<Student> _studentRepository) 
        {
            //_context = context;
            StudentRepository = _studentRepository;
            //_studentRepository = StudentRepository;
        }

        public string AddStudent(StudentDto stuDto)
        {
            Student stu = new Student();
            stu.STUNAME = stuDto.StudentName;
            stu.STUAGE = stuDto.StuAge;
            stu.STUCLASS = stuDto.StuClass;
            stu.STUSEX = stuDto.StuSex;
            int i = StudentRepository.AddEntity(stu);
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
            var data = StudentRepository.TrackEntities.ToList();
            return data;
        }
    }
}
