using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_api.Models
{
    public class UserModel
    {
        public string user_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; } 
        public string email { get; set; }
    }
    public class UserListModel
    {
        public List<UserModel> users { get; set;}
    }
}
