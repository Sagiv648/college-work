using System;

namespace dsa_college._0_dsa_exams.Summer_2021_A._4th_question
{
    public class A
    {
        public A ()
        {
            Console.WriteLine("Hello from A");
        }
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine("B constructor");
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            A x = new B();
            Console.Read();
        }
    }
}