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
        public IEnumerable<VaultDataObject> GetVaultDataObjects()
        {
            return new VaultDataObject[] { new VaultDataObject(0,"test1@gmail.com","pword1","test1"),
                                           new VaultDataObject(1,"test2@gmail.com","pword2","test2"),
                                           new VaultDataObject(2,"test3@gmail.com","pword3","test3")};
        }

        // GET: api/VaultData/{RecordNumber}
        [HttpGet("{id}", Name = "GetVaultDataObject")]
        public VaultDataObject GetVaultDataObject(int id)
        {
            return null;
        }

        // POST: api/VaultData
        [HttpPost]
        public void PostVaultData([FromBody] string value)
        {
        }

        // PUT: api/VaultData/5
        [HttpPut("{id}")]
        public void PutVaultData(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteVaultData(int id)
        {
        }
    }
}
