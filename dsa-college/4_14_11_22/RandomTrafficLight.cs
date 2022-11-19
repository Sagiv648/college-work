using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{

    //רמזור רנדומלי בוחר את הכביש שיקבל את האור הירוק באופן רנדומלי
    public class RandomTrafficLight : TrafficLight 
    {
        
        public RandomTrafficLight(Junction junction) : base(junction) { }
        
            
        


        public override void Check()
        {
            pausingTime--;
            if(pausingTime == 0)
            {
                isGreen = junction.GetEnteringRoads()
                    [GenerateRandom(0, junction.GetEnteringRoads().Count)];

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
            return "Random Traffic light";
        }
    }
}
