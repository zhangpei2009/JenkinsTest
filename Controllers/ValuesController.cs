using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers
{
    /// <summary>
    /// XX类注释
    /// </summary>
    [Route("api/[controller]")]
    //[ApiExplorerSettings(IgnoreApi = true)]不显示在swagger api上
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// 获取所有value的方法
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 根据ID获取value
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<OutPutClass> Get( int id)
        {
            OutPutClass item = new OutPutClass {
                Name = "Zhang",
                Age = 20
            };
            return item;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
