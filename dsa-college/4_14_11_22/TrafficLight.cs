using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public abstract class TrafficLight
    {
        protected int pausingTime;
        protected Junction junction;
        protected Road isGreen;

        static Random rand = new Random();

        public TrafficLight(Junction junction)
        {
            this.junction = junction;
            pausingTime = GenerateRandom(2, 5);
        }



        public abstract void Check();

        public abstract Road GetCurrentGreen();

        protected static int GenerateRandom(int min, int max)
        {
            return rand.Next(min, max);
        }
        
    }
}
