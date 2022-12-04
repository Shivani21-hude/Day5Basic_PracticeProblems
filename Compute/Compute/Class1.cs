using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute
{
    public class Class1
    {
        public void ComQuoRemainder()
        {
            Console.WriteLine("Enter a value as a divident :");
            int divident = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter a value as a divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            
            int quotient = divident / divisor;
            int remainder = divident % divisor;
            
            Console.WriteLine("\n");
            Console.WriteLine("Quoteint: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
            
        }
    }
}
