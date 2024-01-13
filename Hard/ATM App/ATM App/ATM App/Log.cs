using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ATM_App
{
    public class Log
    {
        public Log() { }

        public void WriteLog(string value)
        {
            DateTime date = DateTime.Now;
            string path = Directory.GetCurrentDirectory() + $"\\{date.ToString("dd.MM.yyyy")}.txt";

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{value} on {date}");
            }
        }
        public void CheckAndCreate()
        {
            DateTime date = DateTime.Now;
            string path = Directory.GetCurrentDirectory() + $"\\{date.ToString("dd.MM.yyyy")}.txt";

            if (!File.Exists(path))
            {
                File.Create(path);



                WriteLog("Log file created");
            }
        }
    }
}
