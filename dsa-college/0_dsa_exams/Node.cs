using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._0_dsa_exams
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
}
