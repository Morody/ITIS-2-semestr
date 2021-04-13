using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();
            int count = 8;
            int count1 = count + 1;

            while (stack.Count <= 7)
            {
                stack.Push(count);
                count--;

            }

            Stack<int> stack2 = new Stack<int>(stack);

            while (stack2.Count <= 10)
            {
                stack2.Push(count1);
                count1++;

            }


            foreach (int number in stack2)
            {
                Console.WriteLine(number);
            }

            PopAt(3);


        }

        public static void PopAt(int index)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);

            ArrayList arraylist = new ArrayList(stack);

            arraylist.RemoveAt(index);
            foreach (var n in arraylist)
            {
                Console.Write($" {n} ");
            }
        }

        
    }
}
