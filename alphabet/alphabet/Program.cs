using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a albhabet : ");
            char c = Convert.ToChar(Console.ReadLine());
            
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'||
            c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("{0} is Vowel", c);
            }
            else
            {
                Console.WriteLine("{0} is Consonant", c);
            }
        }
    }
}