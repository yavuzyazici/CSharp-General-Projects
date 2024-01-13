using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class Helper
    {
        public bool IsDigit(string word)
        {
            foreach (char c in word)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void Clear()
        {
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}
