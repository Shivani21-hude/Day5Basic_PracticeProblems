using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOf2
{
    internal class Class1
    {
        public void power()
        {
            Console.WriteLine("enter number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int value = 2;
            for (int i = 1; i <= n; i++)
            {
                double p = Math.Pow(value, i);
                Console.WriteLine("Power of 2 values are : ",p);
                Console.ReadLine();
                Console.WriteLine(p);
            }
        }
    }
}
