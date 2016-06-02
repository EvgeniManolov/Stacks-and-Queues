using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int min = queue.Min();

                    Console.WriteLine(min);
                }
            }
        }
    }
}
