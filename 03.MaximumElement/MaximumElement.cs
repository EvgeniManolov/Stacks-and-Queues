using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaximumElement
{
    class MaximumElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            int maxNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "2":
                        int numberToPop = stack.Pop();

                        if (maxNum == numberToPop && stack.Count == 0)
                        {
                            maxNum = int.MinValue;
                        }
                        else if (maxNum == numberToPop)
                        {
                            maxNum = stack.Max();
                        }
                        break;
                    case "3":
                        Console.WriteLine(maxNum);
                        break;
                    default:
                        string[] inputArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        int x = int.Parse(inputArgs[1]);
                        stack.Push(x);

                        if (maxNum < x)
                        {
                            maxNum = x;
                        }
                        break;
                }
            }
        }
    }
}
