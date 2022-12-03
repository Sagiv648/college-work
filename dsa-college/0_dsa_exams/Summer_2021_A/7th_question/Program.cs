
using System;

namespace dsa_college._0_dsa_exams.Summer_2021_A._7th_question
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T val)
        {
            data = val;
        }
    }


    public class Data
    {
        private bool free;
        private int size;
        //constructor
        public Data(int size)
        {
            this.free = true;
            this.size = size;
        }
        public bool IsFree() { return free; }
        public int GetSize() { return size; }
        public void SetFree(bool free) { this.free = free; }
        public void SetSize(int size) { this.size = size; }
    }

    public class Memory
    {
        public Node<Data> start;
        public Memory(int totalSize)
        {
            this.start = new Node<Data>(new Data(totalSize));
            start.next = null;
        }
        public bool IsDangerous()
        {
            Node<Data> tmp = start;
            int takenTotal = 0;
            int netTotal = 0;
            for(; tmp != null; tmp = tmp.next)
            {
                netTotal += tmp.data.GetSize();
                if (!tmp.data.IsFree())
                    takenTotal += tmp.data.GetSize();
            }

            return !((netTotal - takenTotal) > (netTotal * 0.1));
        }
        bool FirstFit(int num)
        {
            if (IsDangerous())
                return false;
            Node<Data> tmp = start;
            
            for(;tmp != null; tmp = tmp.next)
            {
                if(tmp.data.IsFree() && tmp.data.GetSize()>= num)
                {
                    if(tmp.data.GetSize() - num == 0)
                    {
                        tmp.data.SetFree(false);
                        return true;
                    }
                    else
                    {
                        Node<Data> tmp2 = tmp.next;
                        tmp.next = new Node<Data>(new Data(tmp.data.GetSize() - num));
                        tmp.next.next = tmp2;
                        return true;
                        
                    }
                }
            }
            return !(tmp == null);
        }
    }


    public class Program
    {

        static Random r = new Random();

        public static void Main(string[] args)
        {
            Memory m = new Memory(10);
            Node<Data> tmp = m.start;
            int c = r.Next(1000);
            while(c > 0)
            {
                r.Next(50, 500);
                c--;
            }

            for (int i = 0; i < 10; i++)
            {
                tmp.next = new Node<Data>(new Data(r.Next(50, 500)));

                Console.WriteLine("{0}-{1} ", tmp.data.GetSize(), tmp.next.data.IsFree());
                tmp = tmp.next;
     
                tmp.next = null;
            }
            Console.WriteLine();
            


            Console.Read();
        }
    }
}