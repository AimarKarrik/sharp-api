using Newtonsoft.Json;
using sharp_api.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace sharp_api.Controllers
{
    class UserController
    {
        public List<UserModel> get()
        {
            var users = new List<UserModel>();

            using (StreamReader r = new StreamReader("..\\..\\DemoData\\User.json"))
            {
                string json = r.ReadToEnd();
                users = JsonConvert.DeserializeObject<List<UserModel>>(json);
            }
            return users;
        }
    }
}
