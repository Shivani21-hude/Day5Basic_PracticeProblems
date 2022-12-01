using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factor
{
    internal class Class2
    {
        static void factorization()
        {
            int n;
        
            Console.WriteLine("Enter number for to print prime number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                int fact = 1;
                int count = 0;
                for(int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    else if (count >= 2)
                    {
                        break;
                    }
                    else if (count < 2)
                    {
                        fact = fact * i;
                    }
                }Console.WriteLine(fact);
            }
        }
    }
}
