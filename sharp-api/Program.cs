using sharp_api.Controllers;
using System;
using System.Collections.Generic;
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
            Console.WriteLine(controller.get());
            Console.ReadLine();

        }
    }
}
