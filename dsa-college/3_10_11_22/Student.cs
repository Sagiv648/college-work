using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._10_11_22
{
    public class Student : Person
    {
        HomeAssignment assignment;
        


        public Student(Website site) : base( site) { }
        

        

   
        public override string ToString()
        {
            


            return string.Format("student with id {0} and grade {1}", getPid(), assignment != null ? assignment.getGrade() : 0);


        }
        public void setAssignment(HomeAssignment homeAssignment) => assignment = homeAssignment;

        public override void getToWork()
        {
            
            
            if (Convert.ToBoolean(generateRandom(0,2)))
            {
                assignment = new HomeAssignment(this);
                site.appendAssignment(assignment);
                workDone = true;

            }
            else
            {
                assignment = null;
                workDone = true;
            }
            

        }
    }
}
