using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class ATMOperations
    {
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

                if (int.TryParse(input, out amount) && amount > 0 && user.Money >= amount)
                {
                    uC.Users.Where(x => x.Username == user.Username && x.Password == user.Password).First().Money -= amount;
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

                if (int.TryParse(input, out int amount) && amount >= 0)
                {
                    uC.Users.Where(x => x.Username == user.Username && x.Password == user.Password).First().Money += amount;
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
            uC.SaveUsers();
        }
        public void BalanceInquiry(User user)
        {
            log.WriteLog($"{user.Username} checked his/her deposit.");
            Console.WriteLine($"Your deposit is:{user.Money}TL");
        }
        public void MakePayment(User user)
        {
            bool TrueFalse = true;
            while (TrueFalse)
            {
                Console.WriteLine("Enter the account number of the person you will pay:");
                string accnumber = Console.ReadLine();

                Console.WriteLine("Enter the ammount:");
                string amountstring = Console.ReadLine();

                if (int.TryParse(amountstring, out int amount) && !string.IsNullOrEmpty(uC.Users.Where(x => x.AccountNumber == accnumber).First().ToString()) && user.Money > amount)
                {
                    User userToTransfer = uC.Users.Where(x => x.AccountNumber == accnumber).FirstOrDefault();
                    userToTransfer.Money += amount;
                    uC.Users.Where(x => x.Username == user.Username && x.Password == user.Password).FirstOrDefault().Money -= amount;
                    log.WriteLog($"{amount}TL money transfered to {userToTransfer.Username} from {user.Username}.");
                    Console.WriteLine($"{amount}TL money transfered.");
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
    }
}
