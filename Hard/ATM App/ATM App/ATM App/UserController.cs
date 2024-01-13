using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public double Money { get; set; }
        public string AccountNumber { get; set; }

    }
    public class UserController
    {
        public List<User> Users { get; set; }
        public UserController()
        {
            Users = LoadUsers();
        }
        public void SaveUsers()
        {
            string jsonFilePath = Directory.GetCurrentDirectory() + "\\userInfo.json";
            string jsonContent = JsonConvert.SerializeObject(Users, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonContent);
        }
        public List<User> LoadUsers()
        {
            string jsonFilePath = Directory.GetCurrentDirectory() + "\\userInfo.json";

            string jsonContent = File.ReadAllText(jsonFilePath);

            Users = JsonConvert.DeserializeObject<List<User>>(jsonContent);

            return Users;
        }
    }
}