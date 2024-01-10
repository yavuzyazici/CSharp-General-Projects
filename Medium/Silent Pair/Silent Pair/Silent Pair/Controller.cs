using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Silent_Pair
{
    public class Controller
    {
        public void SilentPair(string input)
        {
            try
            {
                string[] quiets = { "z", "y", "v", "t", "ş", "s", "r", "p", "n", "r", "m", "l", "k", "h", "j", "ğ", "g", "d", "ç", "c", "b" };
                string[] words = input.Split(" ");

                foreach (string word in words)
                {
                    bool hasSilentPair = false;

                    for (int i = 0; i < word.Length - 1; i++)
                    {
                        if (Array.Exists(quiets, q => q == word[i].ToString()) && Array.Exists(quiets, q => q == word[i + 1].ToString()))
                        {
                            hasSilentPair = true;
                            break;
                        }
                    }

                    Console.Write(hasSilentPair + " ");
                }
            }

            catch (Exception)
            {
                Clear();
                return;
            }
        }

        public void Clear()
        {
            Console.WriteLine("Wrong Input");
            Thread.Sleep(500);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
