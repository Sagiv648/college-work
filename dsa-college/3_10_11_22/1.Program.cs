using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace dsa_college._10_11_22
{
    public class Program
    {
        static void Main(string[] args)
        {
            Website site = new Website();

            List<Person> humans = new List<Person>();
            
            for(int i = 0; i < 10; i++)
            {
                humans.Add(new Student(site));
                humans[humans.Count - 1].getToWork();
                
            }

            humans.Add(new Lecturer(site));
            
            humans[humans.Count - 1].getToWork();
            if (humans[humans.Count - 1].isWorkDone())
            {
                for(int i = 0; i < humans.Count-1; i++)
                    Console.WriteLine(humans[i]);
            }
            
           

            Console.Read();
        }
    }
}