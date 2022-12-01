using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmonicNum
{
    internal class Harmonic
    {
        public double sumof()
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float s = 1 / 1;
            for(int i = 2; i <= n; i++)
            {
                s = s + 1 / (float)i;
            }
            Console.WriteLine("The sum of harmonic numbers : ",s);
        }
    }
}
