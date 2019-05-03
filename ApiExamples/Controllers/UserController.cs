using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Models;

namespace UsersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User
        /// <summary>
        /// List all users from the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new []
            {
                new User{ Id = 1, FirstName = "Ben", LastName="Jones"},
                new User{ Id = 2, FirstName = "Rakhee", LastName="Amith"},
                new User{ Id = 3, FirstName = "Lola", LastName="Jones"},
                new User{ Id = 4, FirstName = "Amelie", LastName="Smith"}
            };
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetById")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}