using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace dsa_college._0_dsa_exams.Summer_2022_B._2nd_question
{
    


    public class Program
    {
      public static int NumNodesFollowing(Node<int> node)
      {
            Node<int> tmp = node;
            int count = -1;
            while(tmp != null)
            {
                
                tmp = tmp.next;
                count++;
            }
            return count;
      }

        public static bool IsSection(Node<int> head) 
        {
            
            Node<int> tmp = head;
            
            for(; tmp != null; tmp = tmp.next)
            {
                if (tmp.data > NumNodesFollowing(tmp))
                    return false;
            }

            return true;
        }

        public static void Main(string[] args)
        {

            Node<int> head = new Node<int>();
            Node<int>.initList(head, new int[] { 2, 3, 2, 1, -4, 1, 0 });

            //Console.WriteLine(NumNodesFollowing(head));

            Console.WriteLine(IsSection(head));

            Console.Read();
        }
    }
}