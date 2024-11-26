using sharp_api.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace sharp_api.Controllers
{
    class UserController
    {
        public List<UserModel> get()
        {
            List<UserModel> users = new List<UserModel>();

            using (StreamReader r = new StreamReader("..\\..\\DemoData\\User.json"))
            {
                string json = r.ReadToEnd();
                Console.WriteLine(json);
                //no idea why it doesent work
                //imma figure out later
                //2024-11-26 20:07
                users = JsonSerializer.Deserialize<List<UserModel>>(json);
            }
            Console.WriteLine(users);
            return users;
        }
    }
}
