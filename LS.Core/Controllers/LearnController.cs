using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LS.Core.Data.Dto;
using LS.Core.Data.Entity;
using LS.Core.Data.IService;
using LS.Core.Data.SQLDataConnect;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LS.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnController : ControllerBase
    {
        private IStudentService _service;
        private StudentDataBase _context;

        /// <summary>
        /// 构造注入
        /// </summary>
        /// <param name="service"></param>
        /// <param name="context"></param>
        public LearnController(IStudentService service,StudentDataBase context)
        {
            _service = service;
            _context = context;
        }


        /// <summary>
        /// 第一个接口
        /// </summary>
        /// <returns></returns>
        [Route("/Learn/LearnTheFirst")]
        [HttpGet]
        public string LearnTheFirst() 
        {
            return "我是第一个接口。";
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <returns></returns>
        [Route("StudentAdd")]
        [HttpPost]
        public string StudentAdd(StudentDto stuDto) 
        {
            return _service.AddStudent(stuDto);
        }

        /// <summary>
        /// 查询学生
        /// </summary>
        /// <returns></returns>
        [Route("Search")]
        [HttpGet]
        public List<Student> Search()
        {
            return _service.SearchStudent();
        }

        /// <summary>
        /// 数据库迁移
        /// </summary>
        /// <returns></returns>
        [Route("/Learn/CreateDataBase")]
        [HttpGet]
        public string CreateDataBase()
        {
            TemporaryDbContextFactory temporaryDb = new TemporaryDbContextFactory();
            temporaryDb.CreateDbContext();
            _context.Database.Migrate();
            return "迁移成功";
        }
    }
}
