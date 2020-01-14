using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VaultWebService.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User/UserName/Password
        [HttpGet("{UserName}/{Password}", Name = "GetUser")]
        public VaultCommonLibrary.User GetUser(string UserName, string Password)
        {
            //will change - this is for testing purposes
            //obviously username and password wont be hardcoded
            //and all passwords in the request will be hashed - not plain text
            if(string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                return null;
            }else if(UserName == "jingenito" && Password == "secadm")
            {
                return new VaultCommonLibrary.User(UserName, Password);
            }
            
            return null;
        }

        // POST: api/User
        [HttpPost]
        public void PostUser([FromBody] VaultCommonLibrary.IUser user)
        {
        }

        // PUT: api/User/5
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
