using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._26._10._22
{
    public class Stack
    {
        int[] ptr;
        int top;
        static int INC_SIZE = 5;

        public Stack(int size)
        {
            ptr = new int[size];
            top = -1;
        }
        public Stack()
        {
            ptr = null;
            top = -1;
        }
        public void push_back(int num)
        {
            if (ptr == null)
            {
                ptr = new int[INC_SIZE];
            }
            else if (top == ptr.Length-1)
            {
                int[] temp = new int[ptr.Length + INC_SIZE];
                for (int i = 0; i < top; i++)
                    temp[i] = ptr[i];
                ptr = temp;

            }
            ptr[++top] = num;
        }
        public int pop()
        {
            return ptr[top--];
        }
        public int peek()
        {
            return ptr[top];
        }
        public bool isEmpty()
        {
            return top == -1;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Stack temp = (Stack)obj;

            int[] firstStack = new int[INC_SIZE];
            int[] secStack = new int[INC_SIZE];
            int ptr = 0;

            while (!isEmpty() && !temp.isEmpty())
            {

                firstStack[ptr] = pop();
                secStack[ptr++] = temp.pop();


                if (ptr == firstStack.Length-1 || ptr == secStack.Length-1)
                {
                    Array.Resize(ref firstStack, firstStack.Length + INC_SIZE);
                    Array.Resize(ref secStack, secStack.Length + INC_SIZE);
                }


            }

            bool isEqual = true;
            ptr--;
            for (; ptr >= 0; ptr--)
            {
                if (isEqual && (firstStack[ptr] != secStack[ptr]))
                {
                    isEqual = false;
                }

                push_back(firstStack[ptr]);
                temp.push_back(secStack[ptr]);

            }

            return isEqual;
        }
    }
}
