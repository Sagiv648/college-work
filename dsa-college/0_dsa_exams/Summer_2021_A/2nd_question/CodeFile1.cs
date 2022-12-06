using System;
using System.Collections.Generic;

namespace dsa_college._0_dsa_exams.Summer_2021_A._2nd_question
{
    public class Program
    {

        public static Queue<int> Duplicates(Queue<int> q1)
        {
            Queue<int> q2 = new Queue<int>();
            int num = 0;
            Queue<int> output = new Queue<int>();
            int element = 0;
            for(; ; num++)
            {
                if(q1.Count > 0) { 

                    while(q1.Count > 0)
                    {
                        element = q1.Dequeue();
                        if(element == num)
                        {
                            output.Enqueue(element);
                        }
                        else
                        {
                            q2.Enqueue(element);
                        }
                    }
                }
                else
                {
                    while(q2.Count > 0)
                    {
                        element = q2.Dequeue();
                        if(element == num)
                        {
                            output.Enqueue(element);
                        }
                        else
                        {
                            q1.Enqueue(element);
                        }
                    }
                }
                if (q1.Count == 0 && q2.Count == 0)
                    break;
            }
            num = 0;
            while (output.Count > 0)
            {
                element = output.Dequeue();
                if (output.Count > 0 && element == output.Peek())
                    num+=2;
                else
                    num = 0;
                
                if(num > 2)
                {
                    q1.Enqueue(element);
                    num = 0;
                }
            }
            return q1;
        }


        public static void Main(string[] args)
        {


            Queue<int> t = new Queue<int>(new List<int> {2,5,5,7,2,1,4,1,3,2,5,5,1 });

            Queue<int> x = Duplicates(t);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}