using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class Controller
    {
        Helper helper = new Helper();
        Log log = new Log();
        UserController uC = new UserController();
        public void Start()
        {
            User user = LogIn();

            bool TrueFalse = true;
            while (TrueFalse)
            {
                Console.WriteLine($"-------------Welcome {user.Username}-------------");
                Console.WriteLine("Select the operation you want to perform.");
                Console.WriteLine("1. Withdrawal");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Balance Inquiry");
                Console.WriteLine("4. Making a Payment");
                Console.WriteLine("5. Exit");
                Console.WriteLine("(1/2/3/4/5)");

                string choise = Console.ReadLine();

                ATMOperations atm = new ATMOperations();

                switch (choise)
                {
                    case "1":
                        atm.Withdrawal(user);
                        helper.Clear();
                        break;
                    case "2":
                        atm.Deposit(user);
                        helper.Clear();
                        break;
                    case "3":
                        atm.BalanceInquiry(user);
                        helper.Clear();
                        break;
                    case "4":
                        atm.MakePayment(user);
                        helper.Clear();
                        break;
                    case "5":
                        TrueFalse = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        helper.Clear();
                        break;
                }
            }
        }

        public User LogIn()
        {
            bool TrueFalse = true;
            while (TrueFalse)
            {
                helper.Clear();
                UserController uC = new UserController();
                List<User> users = uC.LoadUsers();

                Console.WriteLine("Enter your username");
                string username = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                User foundUser = users.FirstOrDefault(u => u.Username == username);
                if (foundUser != null)
                {
                    if (foundUser.Password == password)
                    {
                        Console.WriteLine("Redirecting to ATM page...");
                        Thread.Sleep(500);
                        Console.Clear();
                        log.WriteLog("Successfully logged in");
                        return foundUser;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password");
                        log.WriteLog("Incorrect password entered");
                    }
                }
                else
                {
                    Console.WriteLine("User not found");
                    log.WriteLog("Incorrect username entered");
                }
            }
            return null;
        }
    }
}
