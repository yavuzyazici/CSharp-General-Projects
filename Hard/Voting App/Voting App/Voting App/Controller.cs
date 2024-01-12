using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    public class Controller
    {

        public void Start()
        {
            VotingController vC = new VotingController();
            UsersController uC = new UsersController();
            bool trueFalse = true;
            while (trueFalse)
            {
                Console.WriteLine("1. Vote");
                Console.WriteLine("2. Exit");
                Console.Write("Make your choice (1/2): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string username = uC.LogIn();
                        vC.Vote(username);
                        trueFalse = false;
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        Console.WriteLine("Wrong input");
                        Thread.Sleep(500);
                        Console.Clear();
                        break;
                }
            }
        }
        public void End()
        {
            CategoryController cC = new CategoryController();
            Console.WriteLine("\nResults:");
            for (int i = 0; i < cC.categoryVotes.Count(); i++)
            {
                int sumOfVotes = cC.categoryVotes.Values.Sum();
                var category = cC.categoryVotes;
                if (category.Values.ElementAt(i) == 0)
                {
                    Console.WriteLine($"Category: {category.Keys.ElementAt(i)} - Vote Count: {category.Values.ElementAt(i)} - Vote Rate: %0");
                }
                else
                {
                    Console.WriteLine($"Category: {category.Keys.ElementAt(i)} - Vote Count: {category.Values.ElementAt(i)} - Vote Rate: %{100 * category.Values.ElementAt(i) / sumOfVotes}");
                }
            }
        }
    }
}
