﻿using Microsoft.AspNetCore.Mvc;
using VierkanteWielen.Shared.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VierkanteWielen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessenController : ControllerBase
    {
        // GET: api/<LessenController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LessenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LessenController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LessenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LessenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
