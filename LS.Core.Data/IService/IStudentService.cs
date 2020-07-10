using LS.Core.Data.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.IService
{
    public interface IStudentService
    {
        string AddStudent(StudentDto stuDto);
    }
}
