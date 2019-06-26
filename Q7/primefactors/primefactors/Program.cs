using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primefactors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();   
            int cntr = 0;
            long number = 600851475143;
            for (int i = 1;; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) cntr++;
                }
                if(cntr == 2)
                {
                    if(number % i == 0)
                    {
                        number = number / i;
                        numbers.Add(i);
                    }
                }
                cntr = 0;
                if (i > number) break;
            }
            int max = 0;
            foreach (var item in numbers)
            {
                if (item > max) max = item;
            }
            Console.WriteLine(max);
            Console.Read();


        }
    }
}
