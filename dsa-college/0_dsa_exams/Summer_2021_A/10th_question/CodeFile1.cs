using System;

namespace dsa_college._0_dsa_exams.Summer_2021_A._10th_question
{
    public class Student
    {
        public string studentId;
        public int grade;

        public int GetCode()
        {
            return int.Parse(studentId.Substring(0, studentId.Length / 2)) % 10 * 10 +
                int.Parse(studentId.Substring(studentId.Length / 2)[0].ToString());
        }

    }

    public class GradesFile
    {
        Node<Student>[] files;

        public GradesFile()
        {
            files = new Node<Student>[100];
        }

        public Student GetStudent(int k)
        {
            return k >= files.Length || files[k] == null ? null : files[k].data;
        }
        public bool IsEmpty(int k)
        {
            return GetStudent(k) == null ? true : false;
        }
        public bool ListIsGood(int k)
        {
            if (k >= files.Length || GetStudent(k) == null)
                return true;

            Node<Student> tmp = files[k];
            while(tmp != null)
            {
                if (tmp.data.GetCode() != k)
                    return false;
                tmp = tmp.next;
            }
            return true;
        }
        public void MoveStudent(int k, int j)
        {
            if ((k >= files.Length || k < 0) || (j >= files.Length || j < 0) || files[k] == null)
                return;
            Node<Student> firstStudent = files[k];
            files[k] = files[k].next;
            Node<Student> tmp = files[j];
            while(tmp.next != null)
            {
                tmp = tmp.next;
            }
            tmp.next = firstStudent;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student x = new Student();
            GradesFile files = new GradesFile();
            
            

            Console.Read();
        }
    }
}