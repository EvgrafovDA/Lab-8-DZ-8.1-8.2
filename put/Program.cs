using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace put
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2/log.txt";
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //DirectoryInfo directory = new DirectoryInfo(path);
            //if (!directory.Exists)
            //{
            //    directory.Create();
            //}    
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Start the program");
                sw.WriteLine("Misstake");
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey(); 
        }
    }
}
