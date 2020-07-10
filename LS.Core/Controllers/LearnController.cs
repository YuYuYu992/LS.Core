using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LS.Core.Data.Dto;
using LS.Core.Data.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LS.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnController : ControllerBase
    {
        private IStudentService _service;

        /// <summary>
        /// 构造注入
        /// </summary>
        /// <param name="service"></param>
        public LearnController(IStudentService service)
        {
            _service = service;
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
    }
}
