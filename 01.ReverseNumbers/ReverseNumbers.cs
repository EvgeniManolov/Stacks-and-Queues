using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(int.Parse(numbers[i]));
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(stack.Pop());
                Console.Write(' ');
            }
        }
    }
}
