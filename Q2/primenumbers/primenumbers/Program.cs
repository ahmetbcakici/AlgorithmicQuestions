using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int cntr = 0;
            bool c = false;
            for (int i = 2; ; i++)
            {
                if (cntr >= number) break;
                else
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
                    {
                        Console.Write(i + " ");
                        cntr++;
                    }
                    c = false;
                }
            }
            Console.Read();
        }
    }
}
