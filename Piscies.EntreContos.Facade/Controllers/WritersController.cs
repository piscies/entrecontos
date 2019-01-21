using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Piscies.Common.Crosscut.DTO;
using Piscies.EntreContos.Application.Interface;
using Piscies.EntreContos.Crosscut.DTO;

namespace Piscies.EntreContos.Facade.Controllers
{
    [Route("api/[controller]")]
    public class WritersController : Controller
    {
        IWriterApp writerApp;

        public WritersController(IWriterApp writerApp)
        {
            this.writerApp = writerApp;
        }

        [HttpGet]
        public IActionResult List()
        {
            ActionResponseDTO response = new ActionResponseDTO();

            try
            {
                response = writerApp.List();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

            return Ok(response.Content);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
