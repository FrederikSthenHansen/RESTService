using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary;


namespace RESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET: api/Calculator
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Calculator/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Calculator
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Calculator/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //Add: 
        [HttpPost("Add", Name = "Add")]
        public int Post([FromBody] Data data)
        {
            return data.a + data.b;
        }

        // Divide
        [HttpPost("Divide", Name = "Divide")]
        public double Divide ([FromBody] Data data)
        {
            return (data.a*1.0) / data.b;
        }

        //multiply
        [HttpPost("Multiply")]
        public int multiply([FromBody] Data data)
        {
            return data.a * data.b;
        }

        //subtract
        [HttpPost("Subtract")]
        public int Subtract([FromBody] Data data)
        {
            return data.a - data.b;
        }
    }
}
