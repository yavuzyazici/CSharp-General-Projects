using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Homework
{
    public class Controller
    {
        public void Cutter(string text,int num)
        {
            char[] saaa = new char[text.Length];
            List<char> letterSequence = new List<char>();


            // Her bir harfi diziye ekle
            for (int i = 0; i < text.Length; i++)
            {
                letterSequence.Add(text[i]);
            }

            letterSequence.RemoveAt(num);

            Console.WriteLine(string.Join("", letterSequence));
        }
    }
}
