using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._10_11_22
{
    public class Website
    {
        Queue<HomeAssignment> assignments;

        public Website()
        {
            assignments = new Queue<HomeAssignment>();
        }
        public void appendAssignment(HomeAssignment assignment) => assignments.Enqueue(assignment);

        public HomeAssignment sendToLecturer() => assignments.Dequeue();

        public int getQueueLength() => assignments.Count;


    }
}
