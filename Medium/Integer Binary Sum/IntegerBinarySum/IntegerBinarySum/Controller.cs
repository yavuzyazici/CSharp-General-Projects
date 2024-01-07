using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerBinarySum
{
    public class Controller
    {

        public bool PcsPair(string input)
        {
            try
            {
                string[] strings = input.Split(" ");
                if (strings.Count() % 2 == 1 || strings.Count() == 0)
                {
                    Clean();
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void BinarySum(string input)
        {
            string[] strings = input.Split(" ");
            for (int i = 0; i < strings.Length - 1; i = i + 2)
            {
                if (strings[i] == strings[i + 1])
                {
                    int summed = Convert.ToInt32(strings[i]) + Convert.ToInt32(strings[i + 1]);
                    int result = summed * summed;
                    Console.Write(summed * summed + " ");
                }
                if (strings[i] != strings[i + 1])
                {
                    Console.Write(Convert.ToInt32(strings[i]) + Convert.ToInt32(strings[i + 1]) + " ");
                }
            }

            Console.WriteLine("İşlem Tamamlandı.");
        }

        public void Clean()
        {
            Console.WriteLine("Wrong Input");
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}
