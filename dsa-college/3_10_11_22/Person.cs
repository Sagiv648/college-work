using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._10_11_22
{
    public class Person
    {
        private static int counterHumans = 0;
        protected int pid;
        protected Website site;
        
        private static readonly Random rand = new Random();


        protected bool workDone = false;
        public Person(Website site)
        {
            pid = ++counterHumans;
            this.site = site;
        }

        public bool isWorkDone() => workDone;

        protected int generateRandom(int min, int max)
        {
                return rand.Next(min, max);
            
        }

        
        public int getPid() => pid;


        public virtual void getToWork() { }
    }
}
