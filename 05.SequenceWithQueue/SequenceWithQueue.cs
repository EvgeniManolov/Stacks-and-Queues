using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SequenceWithQueue
{
    class SequenceWithQueue
    {
        private static Queue<double> queue = new Queue<double>();
        private static int counter = 1;

        static void Main(string[] args)
        {
            queue.Enqueue(double.Parse(Console.ReadLine()));
            EnqueueTheQueue();
            PrintQueue();
        }

        private static void EnqueueTheQueue()
        {
            for (int i = 1; i < 50; i++, counter++)
            {
                DequeueAndPrintUssedElement(counter);
                EnqueueElement();
            }
        }

        private static void PrintQueue()
        {
            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + " ");
            }
        }

        private static void EnqueueElement()
        {
            if (counter == 1)
            {
                queue.Enqueue(queue.Peek() + 1);
            }
            else if (counter == 2)
            {
                queue.Enqueue(queue.Peek() * 2 + 1);
            }
            else if (counter == 3)
            {
                queue.Enqueue(queue.Peek() + 2);
            }
        }

        private static void DequeueAndPrintUssedElement(int currElement)
        {
            if (counter == 4)
            {
                Console.Write(queue.Dequeue() + " ");
                counter = 1;
            }
        }
    }
}

