using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} is a even number",n);
            }
            else
            {
                Console.WriteLine("{0} is a odd number ", n);
            }
        }
    }
}