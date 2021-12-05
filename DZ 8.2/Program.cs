using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ_8._2 //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
                  //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем,
                  //ответ выведите на консоль.
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = File.CreateText(@"C:\Users\Evgra\OneDrive\Рабочий стол\Рабочий стол\DZ EDA\Lab 8\DZ 8.2\\TenNumbers.txt"))
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(100));
                }
            }
            float sum = 0;
            string[] temp;
            StreamReader sr = new StreamReader(@"C:\Users\Evgra\OneDrive\Рабочий стол\Рабочий стол\DZ EDA\Lab 8\DZ 8.2\\TenNumbers.txt");
            while (!sr.EndOfStream)
            {
                temp = sr.ReadLine().Split(' ');
                foreach (string s in temp)
                {
                    if (s != null)
                    {
                        sum += float.Parse(s);
                    }
                }
            }
            sr.Close();
            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }
    }
}
