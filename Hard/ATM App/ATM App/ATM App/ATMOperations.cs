using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class ATMOperations
    {
        Helper helper = new Helper();
        Log log = new Log();
        UserController uC = new UserController();
        public void Withdrawal(User user)
        {
            bool TrueFalse = true;
            while (TrueFalse)
            {
                Console.WriteLine("Enter the amount you want to withdraw");
                string input = Console.ReadLine();

                int amount = Convert.ToInt32(input);

                //if (input == null || !helper.IsDigit(input) || Convert.ToInt32(input) <= 0 || user.Money < amount)
                //{
                //    Console.WriteLine("Wrong input");
                //}
                //else
                //{
                //    user.Money = user.Money - amount;
                //    log.WriteLog($"{amount}TL money withdrawed.");
                //    Console.WriteLine($"{amount}TL money withdrawed.");
                //    Thread.Sleep(1000);
                //    TrueFalse = false;
                //}

                if (int.TryParse(input, out amount) && amount > 0 && user.Money >= amount)
                {
                    user.Money -= amount;
                    log.WriteLog($"{amount}TL money withdrawn.");
                    Console.WriteLine($"{amount}TL money withdrawn.");
                    Thread.Sleep(1000);
                    TrueFalse = false;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            uC.SaveUsers();
        }
        public void Deposit(User user)
        {
            bool TrueFalse = true;
            while (TrueFalse)
            {
                Console.WriteLine("Enter the amount you want to deposit");
                string input = Console.ReadLine();

                int amount = Convert.ToInt32(input);

                //if (input == null || !helper.IsDigit(input) || Convert.ToInt32(input) <= 0)
                //    Console.WriteLine("Wrong input");
                //else
                //{
                //    user.Money = user.Money + amount;
                //    log.WriteLog($"{amount}TL deposit added.");
                //    TrueFalse = false;
                //}
                if (int.TryParse(input, out amount))
                {
                    user.Money += amount;
                    log.WriteLog($"{amount}TL deposit added.");
                    Console.WriteLine($"{amount}TL deposit added.");
                    Thread.Sleep(1000);
                    TrueFalse = false;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }

        }
        public void BalanceInquiry(User user)
        {

        }
        public void MakePayment(User user)
        {

        }
    }
}
