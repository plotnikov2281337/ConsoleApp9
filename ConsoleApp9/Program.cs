using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            var numList = new List<int>();
            for (var index = 0; index < 16; index++)
            {
                numList.Add(rnd.Next(100));
            }

            int p1 = 0;
            foreach (int i in numList)
            if (i % 2 == 0) p1 += i;
            Console.WriteLine("Сумма четных элементов массива = " + p1);


            int p2 = 0;
            foreach (int i in numList)
            if (i % 3 == 0) p2 += i;
            Console.WriteLine("Сумма элементов массива кратных 3 = " + p2);

            int r;
            r = p1 - p2;
            Console.WriteLine("Разность между суммой элементов c четными индексами и суммой элементов, индексы которых кратны трем. = " + r);

            foreach (var i in numList)
            {
              Console.Write(string.Format("{0:f3}\t\t", i));
            }
            Console.ReadKey();
            
        }
    }
}
    

