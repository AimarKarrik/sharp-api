using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sharp_Api.Helpers;
using Sharp_Api.Models;

namespace Sharp_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {


        [HttpGet(Name = "GetUsers")]
        public List<UserModel>? Get()
        {
            List<UserModel>? users = UserHelper.GetUserData();
            if (users == null)
            { 
                return null;
            }
            return users;
        }
    }
}
