using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Repositories;
using Api.Models;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        // GET api/person
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/person/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/person
        [HttpPost]
        public void Post([FromBody]Person person)
        {
            _personRepository.Add(person);
        }

        // PUT api/person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/person/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
