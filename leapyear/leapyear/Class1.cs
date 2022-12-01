using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    internal class Class1
    {
        public void year()
        {
            Console.WriteLine("enter year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else if (year % 100 == 0) 
            {
                Console.WriteLine("Not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}
