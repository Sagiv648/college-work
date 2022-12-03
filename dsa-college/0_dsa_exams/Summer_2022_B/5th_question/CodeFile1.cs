using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace dsa_college._0_dsa_exams.Summer_2022_B._5th_question
{



    public class Program
    {
        public static void what(Node<int> f, Node<int> s)
        {
            //The operation checks if Node f is an inverted version of Node s
            Stack<int> st = new Stack<int>();
            while (s != null)
            {
                st.Push(s.data);
                s = s.next;
            }
            while (f != null && !(st.Count < 0) && (st.Pop() == f.data))
            {
                Console.Write(f.data + ", ");
                f = f.next;
            }
            Console.WriteLine("STOP!");
        }



        public static void Main(string[] args)
        {
            
            
            

            Node<int>[] nL = new Node<int>[4];
            for (int i = 0; i < nL.Length; i++)
            {
                nL[i] = new Node<int>();
                
            }
            
            Node<int>.initList(nL[0], new List<int> { 17,-5,1,1,2,17,-5,1});
            Node<int>.initList(nL[1], new List<int> { 1,-5,17,2,5,6 });
            Node<int>.initList(nL[2], new List<int> { 1,-5,17,0,2,3,6 });
            Node<int>.initList(nL[3], new List<int> { 17, -5, 1, 1, 2, 8, -5, 1 });

            what(nL[2], nL[0]);


            Console.Read();
        }
    }
}