using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxasal
{
    class Program
    {
        static int findmaxasal(int a)
        {
            List<int> arr = new List<int>();
            bool c = false;
            for (int i = 3; i < a; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        c = false;
                        break;
                    }
                    else
                        c = true;
                }
                if (c == true) arr.Add(i);
                c = false;
            }

            return arr.Max();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(findmaxasal(input));
            Console.Read();
        }
    }
}
