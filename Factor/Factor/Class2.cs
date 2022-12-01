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
                bool isPrimeNumber = true;
                int fact = 1;
                
                for(int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                 }
                     if (isPrimeNumber)
                   
                        Console.WriteLine("{0}",i);
                         fact=fact*i;
               }
               Console.WriteLine("factorial of prime numbers : " +fact);
          }
      }
 }
 
