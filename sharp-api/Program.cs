using Newtonsoft.Json;
using sharp_api.Controllers;
using sharp_api.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_api
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserController controller = new UserController();
            List<UserModel> users = controller.get();
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.name}, id: {user.user_id}");
            }
            Console.ReadLine();

        }
    }
}
