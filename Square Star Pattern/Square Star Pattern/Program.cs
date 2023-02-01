using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Star_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");

            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++) Console.Write("*");
                           
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
