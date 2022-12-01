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
            Console.WriteLine()
            int divident = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = divident / divisor;
            int remainder = divident % divisor;
            Console.WriteLine("divident:{0}  Divisor:{1}", divident, divisor);
            Console.WriteLine("Quoteint: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
            Console.ReadLine();
        }
    }
}
