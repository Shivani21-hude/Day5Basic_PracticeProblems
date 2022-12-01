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
            Console.WriteLine("Enetr a 1st number : ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number : ");
            int n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number : ");
            int n3=Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("{0} is largest", n1);
            }else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("{0} is largest", n2);
            }
            else
            {
                Console.WriteLine("{0} is largest", n3);
            }
        }
    }
}