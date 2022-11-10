using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._10_11_22
{
    public class Lecturer : Person
    {
        public Lecturer(Website site) : base(site) { }


        public override string ToString()
        {
            return string.Format("Lecturer number : {0}", pid);
        }

        public override void getToWork()
        {
            

            while (site.getQueueLength() > 0)
            {
                
                HomeAssignment assignment = site.sendToLecturer();
                
                assignment.setGrade(generateRandom(20,101));
                
            }
            workDone = true;
            Console.WriteLine("All the assignments were checked and marked.");
        }

    }
}
