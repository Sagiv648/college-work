using System;
using System.Text;
using System.Collections.Generic;

namespace dsa_college._0_dsa_exams.Summer_2022_B._1st_question
{
    public class Program
    {
        public static bool EqualSums(Stack<int> stack)
        {
            Stack<int> tmpFirstHalf = new Stack<int>();
            Stack<int> tmpSecHalf = new Stack<int>();
            int count=0;
            while(stack.Count > 0)
            {
                tmpFirstHalf.Push(stack.Pop());
                count++;
            }
            if (count % 2 == 0)
                return false;
            int mid = count / 2;
            
            while(count > mid)
            {
               
                tmpSecHalf.Push(tmpFirstHalf.Pop());
                count--;
            }
            mid = tmpSecHalf.Pop();
            while(tmpFirstHalf.Count > 0 && tmpSecHalf.Count > 0)
            {
                int popped1 = tmpFirstHalf.Pop();
                int popped2 = tmpSecHalf.Pop();
                Console.WriteLine($"{popped1} + {popped2} = {mid}");
                if (popped1 + popped2 != mid)
                    return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            

            Stack<int> s = new Stack<int>(new List<int> { 18, 3, 15, 13, 4, 25, 21, 12, 10, 22, 7 });

            Console.WriteLine(EqualSums(s));

            Console.Read();
        }
    }
}