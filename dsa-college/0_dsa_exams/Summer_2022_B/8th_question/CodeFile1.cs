

using System;

namespace dsa_college._0_dsa_exams.Summer_2022_B._8th_question
{
    public class MyNode
    {
        public int value;
        public int howManyBig;
        public MyNode next;
       
        public MyNode(int val, int big)
        {
            this.value = val;
            this.howManyBig = big;
            this.next = null;
        }
        
    }


    public class Program
    {
        public static MyNode AddNumber(MyNode list, int val, int position) 
        {
            MyNode tmp = list;
            position--;
            for (; tmp.next != null && position > 1; tmp = tmp.next, position--) ;
            if(tmp.next == null)
            {
                tmp.next = new MyNode(val, 0);
                tmp = tmp.next;
                tmp.howManyBig = 0;
                tmp.next = null;
                return tmp;

            }
            MyNode nextTmp = tmp.next;
            tmp.next = new MyNode(val, 0);
            MyNode cont = nextTmp;
            while(cont != null)
            {
                if (cont.value > tmp.next.value)
                    tmp.next.howManyBig++;
                cont = cont.next;
            }
            tmp.next.next = nextTmp;

            return tmp.next;
            
        }

        public static void Main(string[] args)
        {
            MyNode head = new MyNode(5,2);
            head.next = new MyNode(2, 4);
            head.next.next = new MyNode(4, 2);
            head.next.next.next = new MyNode(8, 0);
            head.next.next.next.next = new MyNode(7, 0);
            head.next.next.next.next.next = new MyNode(1, 0);
            head.next.next.next.next.next.next = null;
            MyNode tmp = head;

            AddNumber(head, 3, 5);
            AddNumber(head, 3, 1);

            while (tmp != null)
            {
                Console.WriteLine($"{tmp.value}-{tmp.howManyBig}");
                tmp = tmp.next;
            }
        
            Console.Read();
        }
    }
}