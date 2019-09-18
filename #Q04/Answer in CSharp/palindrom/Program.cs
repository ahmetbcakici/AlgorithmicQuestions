using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            bool palindromecontrol = false;
            Console.Write("Enter a word:");
            string word = Console.ReadLine();
            for (int i = 0, j = word.Length - 1; i < word.Length; i++,j--) 
            {
                if (word[i] != word[j])
                {
                    palindromecontrol = true;
                    break;
                }
            }
            if(palindromecontrol == false)
                Console.WriteLine(word+" is a palindrome word");
            Console.ReadKey();
        }
    }
}
