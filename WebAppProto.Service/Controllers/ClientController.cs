using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppProto.Application;
using WebAppProto.Domain.Application;
using WebAppProto.Domain.Entities;

namespace WebAppProto.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Client")]
    public class ClientController : Controller
    {
        private IApplicationClient applicationClient;

        public ClientController(IApplicationClient _applicationClient)
        {
            applicationClient = _applicationClient;
        }
        
        // GET: api/Client
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Client/5
        [HttpGet("{id}", Name = "Get")]
        public JsonResult Get(int id)
        {
            Client client = applicationClient.Get(id);
            return Json(client);
        }
        
        // POST: api/Client
        [HttpPost]
        public JsonResult Post([FromBody]Client value)
        {
            Client client = applicationClient.Insert(value);
            return Json(client);
        }
        
        // PUT: api/Client/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
