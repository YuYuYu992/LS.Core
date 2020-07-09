using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LS.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnController : ControllerBase
    {
        /// <summary>
        /// 第一个接口
        /// </summary>
        /// <returns></returns>
        [Route("api/colleges/GetCollegesById")]
        [HttpGet]
        public string LearnTheFirst() 
        {
            return "我是第一个接口。";
        }
    }
}
