using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaultCommonLibrary;

namespace VaultWebService.Controllers
{
    [Route("api/VaultData")]
    [ApiController]
    public class VaultDataController : ControllerBase
    {
        // GET: api/VaultData
        [HttpGet]
        public IEnumerable<VaultDataObject> Get()
        {
            return null;
        }

        // GET: api/VaultData/{RecordNumber}
        [HttpGet("{id}", Name = "Get")]
        public VaultDataObject Get(int id)
        {
            return null;
        }

        // POST: api/VaultData
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/VaultData/5
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
