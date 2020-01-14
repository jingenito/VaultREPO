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
        // GET: api/User/Username/Password
        [HttpGet("{Username}/{Password}", Name = "GetUser")]
        public VaultCommonLibrary.User GetUser(string Username, string Password)
        {
            //will change - this is for testing purposes
            //obviously username and password wont be hardcoded
            //and all passwords in the request will be hashed - not plain text
            if(string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                return null;
            }else if(Username == "jingenito" && Password == "secadm")
            {
                return new VaultCommonLibrary.User(Username, Password);
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
