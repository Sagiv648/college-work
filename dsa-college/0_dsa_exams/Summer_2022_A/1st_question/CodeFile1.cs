
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;


namespace dsa_college._0_dsa_exams.Summer_2022_A._1st_question
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public static void initList(Node<T> head, IEnumerable<T> list)
        {
            Node<T> tmp = head;

            int i;
            for (i = 0; i < list.Count(); i++)
            {
                tmp.data = list.ElementAt(i);
                tmp.next = i == list.Count() - 1 ? null : new Node<T>();
                tmp = tmp.next;
            }


        }

    }

    public class CodeDriver11
    {
        public static void printList(Node<int> head)
        {
            for (Node<int> tmp = head; tmp != null; tmp = tmp.next)
            {
                Console.Write($"{tmp.data} ");
            }
            Console.WriteLine();
        }


        public static Node<int> DifferenceList(Node<int> head)
        {
            Node<int> output = new Node<int>();
            Node<int> outputTmp = output;
            Node<int> tmp = head;
            while(tmp.next.next != null)
            {
                outputTmp.data = Math.Abs( tmp.data - tmp.next.data);
                outputTmp.next = new Node<int>();
                tmp = tmp.next;
                outputTmp = outputTmp.next;
                
            }
            outputTmp.data = Math.Abs(tmp.data - tmp.next.data);
            outputTmp.next = null;
            return output;
        }


        public static int TheSurvives(Node<int> head)
        {
            Node<int> diff = DifferenceList(head);

            while(diff.next != null)
            {
                printList(diff);
                diff = DifferenceList(diff);
            }
            printList(diff);
            return diff.data;
            
        }

        public static void Main(string[] args)
        {
            Node<int> head = new Node<int>();
            Random rand = new Random();
            Node<int> tmp = head;
            int i = 0;
            while (i < 7)
            {
                
                tmp.data = rand.Next(1, 21);
                tmp.next = i == 6 ? null : new Node<int>();
                tmp = tmp.next;
                i++;
            }
            //printList(head);

            Node<int> diffList = DifferenceList(head);
            //printList(diffList);

            TheSurvives(head);

            Console.Read();
        }
    }

}

