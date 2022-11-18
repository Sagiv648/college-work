using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public class Vehicle
    {
        
        static Random rand = new Random();
        List<Road> travellingRoute;
        int speed;
        static int vehCounter = 0;
        int vehId;
        int travellingTime = 0;
        bool finishedRoute = false;
        public Vehicle(Map map)
        {
            travellingRoute = map.SelectRandomJunction();
            speed = rand.Next(30, 121);
            vehId = ++vehCounter;
            travellingTime = 0;
            
        }
        public void Move()
        {
            if (!finishedRoute)
            {
                int i=0;
                for(i = 0; i < travellingRoute.Count; i++)
                {
                    Console.WriteLine($"{this} is moving on the road from {travellingRoute[i].GetStartingJunction()} to {travellingRoute[i].GetEndingJunction()}");
                    while ((travellingTime * speed) < travellingRoute[i].GetRoadLength())
                        travellingTime++;
                    Console.WriteLine($"{this} has arrived to {travellingRoute[i].GetEndingJunction()}");
                }
                finishedRoute = true;

            }
            else
            {
                Console.WriteLine($"{this} has arrived to it's destination: {travellingRoute[travellingRoute.Count-1].GetEndingJunction()} ");
            }
            
              
            

            /*בכל פעולת  Moveנבדק האם הרכב סיים לנסוע בכביש הנוכחי (ע"י השוואה של אורך הכביש
עם זמן נסיעה בכביש זה, מוכפל במהירות הרכב.
             * 
             */
        }

        public List<Road> GetRoute() => travellingRoute;

        public override string ToString()
        {
            return $"Vehicle {vehId}";
        }
    }
}
