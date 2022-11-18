using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public class Road
    {
        Junction startingJunction;
        Junction endingJunction;

        public Road(Junction startingJunction, Junction endingJunction)
        {



            if (startingJunction.Equals(endingJunction))
            {
                
                endingJunction = new Junction();
                Console.WriteLine("Road cannot connect a junction to itself, end junction has been replaced with {0}", endingJunction);

            }
                
            this.startingJunction = startingJunction;
            this.endingJunction = endingJunction;
            this.startingJunction.AddExitingRoad(this);
            this.endingJunction.AddEnteringRoad(this);

            Console.WriteLine("Creating Road from {0} to {1}, length: {2:f2}", startingJunction, endingJunction, startingJunction.Distance(endingJunction));

        }

        public double GetRoadLength()
        {
            //Console.WriteLine($"The length of the road from {startingJunction} to {endingJunction} is {startingJunction.Distance(endingJunction):.00}");
            return startingJunction.Distance(endingJunction);
        }

        public Junction GetStartingJunction() => startingJunction;

        public Junction GetEndingJunction() => endingJunction;

        //public double GetLength() => startingJunction.Distance(endingJunction);

        public override string ToString()
        {
            return $"[Road from {startingJunction} to {endingJunction}]";
        }

    }
}
