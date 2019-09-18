using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixquestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[number, number];
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (number % 2 != 0)
                    {
                        if (i == ((number - 1) / 2))
                            matris[i, j] = 1;
                        else
                        {
                            if (j == ((number - 1) / 2))
                                matris[i, j] = 1;
                            else
                                matris[i, j] = 0;
                        }
                    }
                    else
                    {
                        if (i == number / 2 || i == (number / 2) - 1)
                            matris[i, j] = 1;
                        else
                        {
                            if (j == number / 2 || j == (number / 2) - 1)
                                matris[i, j] = 1;
                            else
                                matris[i, j] = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(matris[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
