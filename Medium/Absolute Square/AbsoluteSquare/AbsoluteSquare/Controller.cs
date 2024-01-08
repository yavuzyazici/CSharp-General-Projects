using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbsoluteSquare
{
    public class Controller
    {
        public Controller() { }

        public bool Check(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            string[] digits = input.Split(' ');
            if (digits.Count() <= 1)
            {
                return false;
            }
            if (digits.Count() % 2 == 1)
            {
                return false;
            }
            if (IsDigit(input))
            {
                return false;
            }

            return true;
        }

        public void Algorithm(string input)
        {
            int total1 = 0;
            int total2 = 0;
            string[] digits = input.Split(' ');
            for (int i = 0; i < digits.Count(); i++)
            {
                int digit = Convert.ToInt32(digits[i]);

                if (digit < 67)
                {
                    total1 = (67 - digit) + total1;
                }
                if (digit > 67)
                {
                    total2 += (digit - 67) * (digit - 67);
                }
            }
            Console.WriteLine(total1 + " " + total2);
        }

        public void Clear()
        {
            Console.WriteLine("Wrong Input");
            Thread.Sleep(500);
            Console.Clear();
        }

        bool IsDigit(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsDigit(c) || c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
