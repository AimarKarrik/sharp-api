using Newtonsoft.Json;
using Sharp_Api.Models;

namespace Sharp_Api.Helpers
{
    public class UserHelper
    {

        

        public static List<UserModel>? GetUserData()
        {
            List<UserModel>? users; 
            try
            {
                string jsonData = File.ReadAllText("./DemoData/User.json");
                users = JsonConvert.DeserializeObject<List<UserModel>>(jsonData);
            }
            catch 
            {
                return null;
            }

            return users;
        }
    }
}
