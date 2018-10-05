using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary.Model;

namespace RestCalculatorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        // POST: api/Calculator/addere 2 integers. Virker
        //Name = "Add" navngir det internt så man kan bruge metoden
        [HttpPost("Add", Name = "Add")]
        public int PostAdd([FromBody] Data data)
        {
            return data.A + data.B;
        }

        // POST: api/Calculator/dividere 2 integers. Virker
        [HttpPost("Div", Name = "Div")]
        public int PostDiv([FromBody] Data data)
        {
            return data.A / data.B;
        }

        // POST: api/Calculator/substrahere 2 integers. Virker
        [HttpPost("Sub", Name = "Sub")]
        public int PostSub([FromBody] Data data)
        {
            return data.A - data.B;
        }

        // POST: api/Calculator/multiplicere 2 integers. Virker
        [HttpPost("Multi", Name = "Multi")]
        public int PostMulti([FromBody] Data data)
        {
            return data.A * data.B;
        }


        //// GET: api/Calculator
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Calculator/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Calculator
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Calculator/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
