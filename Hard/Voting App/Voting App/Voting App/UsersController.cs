using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    public class UsersController
    {
        public Dictionary<string, string> registeredUsers = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(Directory.GetCurrentDirectory() + "\\registeredUsers.json"));

        public void SaveUsers()
        {
            string jsonFilePath = Directory.GetCurrentDirectory() + "\\registeredUsers.json";

            // Serialize the dictionary to JSON
            string jsonContent = JsonConvert.SerializeObject(registeredUsers, Formatting.Indented);

            // Write JSON content to a file
            File.WriteAllText(jsonFilePath, jsonContent);
        }
        public string LoadUsers()
        {
            string jsonFilePath = Directory.GetCurrentDirectory() + "\\registeredUsers.json";

            string jsonContent = File.ReadAllText(jsonFilePath);

            registeredUsers = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

            return jsonContent;
        }
        public string LogIn()
        {
            bool trueFalse = true;
            while (trueFalse)
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Enter your username");
                string username = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                if (registeredUsers.ContainsKey(username) && registeredUsers[username].Contains(password))
                {
                    Console.WriteLine("Redirecting to Vote page...");
                    Thread.Sleep(500);
                    Console.Clear();
                    return username;
                }
                else
                {
                    Console.WriteLine("Your username is not found");
                    Console.WriteLine("1. Sign Up");
                    Console.WriteLine("2. Try Again");
                    Console.Write("Make your choice (1/2): ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            SignUp();
                            Console.WriteLine("Successfully Signed Up");
                            Thread.Sleep(500);
                            Console.Clear();
                            LogIn();
                            trueFalse = false;
                            break;
                        case "2":
                            LogIn();
                            trueFalse = false;
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                    }

                }
            }
            return null;
        }
        public void SignUp()
        {

            string username, password;
            bool boolExp = true;
            while (boolExp)
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.Write("Enter your username: ");
                username = Console.ReadLine();

                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                if (string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(password) ||
                    username.Length < 3 ||
                    password.Length < 3)
                {
                    Console.WriteLine("Wrong input");
                    Thread.Sleep(500);
                    Console.Clear();
                    break;
                }
                if (registeredUsers.ContainsKey(username))
                {
                    Console.WriteLine("This user is registered already. Try again");
                    Thread.Sleep(500);
                }
                else
                {
                    registeredUsers.Add(username, password);
                    SaveUsers();
                    boolExp = false;
                }
            }
        }
    }
}
