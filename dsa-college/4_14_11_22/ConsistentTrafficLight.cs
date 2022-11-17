using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    /*רמזור עקבי
מעביר את האור הירוק בין הכבישים הנכנסים של הצומת לפי הסדר בו הם מופיעים     
     * 
     */
    public class ConsistentTrafficLight : TrafficLight
    {
        int roadsCounter;

        public ConsistentTrafficLight(Junction junction) : base(junction) { }
        
            
        

        public override void Check()
        {
            if(pausingTime == 0)
            {
                isGreen = junction.GetEnteringRoads()[roadsCounter++];
                /*
                 * Random TrafficLights Junction 18, delay= 2: green light on Road from
                    Junction 20 to Junction 18
                 * 
                 */
                pausingTime = GenerateRandom(2, 5);
                Console.WriteLine($"{this} {isGreen.GetStartingJunction()}, delay {pausingTime}:" +
                    $"green light on the road from {isGreen.GetStartingJunction()} to {isGreen.GetEndingJunction()}");
            }
        }

        public override Road GetCurrentGreen() => isGreen;
        
        public override string ToString()
        {
            return "Consistent Traffic light";
        }
    }
}
