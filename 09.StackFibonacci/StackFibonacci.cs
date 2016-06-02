using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StackFibonacci
{
    class StackFibonacci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<long> fibonacciNumbers = new Stack<long>();

            fibonacciNumbers.Push(1);
            fibonacciNumbers.Push(1);

            for (int i = 2; i < n; i++)
            {


                long f1 = fibonacciNumbers.Pop();
                long f2 = fibonacciNumbers.Peek();
                fibonacciNumbers.Push(f1);
                fibonacciNumbers.Push(f1 + f2);
            }


            if (n == 0 || n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(fibonacciNumbers.Peek());
            }
        }

    }
}
