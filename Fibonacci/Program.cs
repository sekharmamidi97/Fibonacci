using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Program
    {
        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            if (n == 0)
            {
                return n;
            }
           
            if(n == 1)
            {
                return n;
            }

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;

            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the Fibonacci Sequence: ");
            int sequence = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sequence; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
            Console.ReadKey();

        }
    }
}
