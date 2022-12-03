

using System;

namespace dsa_college._0_dsa_exams.Summer_2021_A._5th_question
{
    public class A
    {
        public virtual void F()
        {
            Console.WriteLine("A.F");
        }
        public virtual void G()
        {
            F();
        }
    }
    public class B : A
    {
        public override void F()
        {
            Console.WriteLine("B.F");
        }
        public override void G()
        {
            Console.WriteLine("B.G");
        }
        public void SuperG()
        {
            base.G();
        }
    }

    public class Node
    {
        public int data;
        public Node next;

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            A a = new A();
            
            B b = new B();
            A ab = new B();

            a.F(); // A.F
            ab.F(); // B.F
            b.F(); // B.F
            a.G(); // A.F
            ab.G(); // B.G
            b.G(); // B.G
            ((B)(ab)).SuperG(); // A.F
            b.SuperG(); // A.F


            Node head = new Node();
            head.data = 1;
            Node tmp = head;
            for(int i = 1; i < 10; i++)
            {
                tmp.next = new Node();
                tmp.next.data = i + 1;
                tmp = tmp.next;
                tmp.next = null;
                
            }

            for(tmp = head; tmp != null; tmp = tmp.next)
            {
                Console.Write("{0} ", tmp.data);
            }



            Console.ReadLine();
        }
    }
}