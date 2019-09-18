using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersUntilEnteredNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primenumbers = new ArrayList();
            bool c = false;
            Console.Write("Enter max number:");
            int limit = Convert.ToInt16(Console.ReadLine());
            for (int i = 2; i < limit; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        c = true;
                        break;
                    }
                }
                if (c == false)
                    primenumbers.Add(i);
                else
                    c = false;
            }
            foreach (var item in primenumbers)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}

