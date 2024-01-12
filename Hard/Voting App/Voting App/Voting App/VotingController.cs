using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    public class VotingController
    {
        public void Vote(string username)
        {
            CategoryController cC = new CategoryController();
            Controller C = new Controller();

            bool trueFalse = true;
            while (trueFalse)
            {
                Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("Select the category you want to vote for");
                foreach (var category in cC.categoryVotes)
                {
                    Console.WriteLine($"Category: {category.Key} - Vote Count: {category.Value}");
                }
                Console.Write("Category Name: ");
                string input = Console.ReadLine();

                

                switch (input)
                {
                    case "Movie Categories":
                        cC.categoryVotes[input]++;
                        cC.SaveCategories(cC.categoryVotes);
                        C.End();
                        trueFalse = false;
                        break;
                    case "Tech Stack Categories":
                        cC.categoryVotes[input]++;
                        cC.SaveCategories(cC.categoryVotes);
                        C.End();
                        trueFalse = false;
                        break;
                    case "Sports Categories":
                        cC.categoryVotes[input]++;
                        cC.SaveCategories(cC.categoryVotes);
                        C.End();
                        trueFalse = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}
