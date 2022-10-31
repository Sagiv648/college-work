using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace dsa_college._26._10._22
{
    class Program<T>
    {
        public static void Main1(string[] args)
        {

            Stack<int> s1 = new Stack<int>();
            Stack s2 = new Stack();
            
            Console.ReadLine();

        }

        



        public static Stack<int> getReverseStack(Stack<int> stack)
        {
            List<int> list = new List<int>();

            while (stack.Count > 0)
            {
                list.Add(stack.Pop());

            }
            Stack<int> output = new Stack<int>();
            for (int i = 0; i < list.Count; i++)
            {
                output.Push(list[i]);
            }
            return output;
        }
        public static Stack getReverseStack(Stack stack)
        {
            List<int> list = new List<int>();
            while (!stack.isEmpty())
            {
                list.Add(stack.pop());
            }
            Stack output = new Stack();
            for (int i = 0; i < list.Count; i++)
            {
                output.push_back(list[i]);
            }
            return output;
        }

        public static Stack<int> getMaxStack(Stack<int> stack)
        {
            List<int> list = new List<int>();
            Stack<int> output = new Stack<int>();
            int maxNum = stack.Pop();
            list.Add(maxNum);
            int maxIndex = 0;

            while (stack.Count > 0)
            {
                list.Add(stack.Pop());
                if (list[list.Count - 1] > maxNum)
                {
                    maxIndex = list.Count - 1;
                    maxNum = list[list.Count - 1];
                }
            }

            for (int i = list.Count - 1; i >= 0; --i)
            {
                stack.Push(list[i]);
                if (i == maxIndex) continue;

                output.Push(list[i]);
            }
            output.Push(list[maxIndex]);


            return output;
        }
        public static Stack getMaxStack(Stack stack)
        {
            List<int> list = new List<int>();
            Stack output = new Stack();
            int maxNum = stack.pop();
            list.Add(maxNum);
            int maxIndex = 0;

            while (!stack.isEmpty())
            {
                list.Add(stack.pop());
                if (list[list.Count - 1] > maxNum)
                {
                    maxIndex = list.Count - 1;
                    maxNum = list[list.Count - 1];
                }
            }

            for (int i = list.Count - 1; i >= 0; --i)
            {
                stack.push_back(list[i]);
                if (i == maxIndex) continue;

                output.push_back(list[i]);
            }
            output.push_back(list[maxIndex]);


            return output;
        }

        public static Stack<int> getEvenStack(Stack<int> stack)
        {
            List<int> list = new List<int>();
            Stack<int> output = new Stack<int>();

            while (stack.Count > 0)
            {
                list.Add(stack.Pop());
            }
            for (int i = list.Count - 1; i >= 0; i--)
            {
                stack.Push(list[i]);
                if (list[i] % 2 != 0) continue;
                output.Push(list[i]);
            }


            return output;
        }
        public static Stack getEvenStack(Stack stack)
        {
            List<int> list = new List<int>();
            Stack output = new Stack();

            while (!stack.isEmpty())
            {
                list.Add(stack.pop());
            }
            for (int i = list.Count - 1; i >= 0; --i)
            {
                stack.push_back(list[i]);
                if (list[i] % 2 != 0) continue;
                output.push_back(list[i]);
            }


            return output;
        }
    }
}