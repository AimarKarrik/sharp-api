using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sharp_Api.Helpers;
using Sharp_Api.Models;
using System.Collections.Generic;

namespace Sharp_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {


        [HttpGet(Name = "GetUsers")]
        public List<UserModel> Get(string? id)
        {
            Console.WriteLine(id);
            List<UserModel>? users = UserHelper.GetUserData();
            List<UserModel> response = new List<UserModel>();
            if (users == null)
            {
                return response;
            }
            if (id != null)
            {
                UserModel? user = users.Find(x => x.user_id.Equals(id));
                if (user == null)
                {
                    return response;
                }

                response.Add(user);
                return response;
            }
            
            response = users;
            return response;
        }
    }
}
