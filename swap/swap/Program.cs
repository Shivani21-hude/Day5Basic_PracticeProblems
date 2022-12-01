using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number to swap: ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number to swap : ");
            int n2=Convert.ToInt32(Console.ReadLine());
            n1 = n1 * n2;
            n2 = n1 / n2;
            n1 = n1 / n2;
            Console.WriteLine("After swapping 1st number= " + n1 +" 2nd number=" + n2);
        }

    }
}
