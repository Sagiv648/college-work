using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public class Vehicle
    {
        Map map;
        static Random rand = new Random();
        int speed;

        int travellingTime;

        public Vehicle(Map map)
        {
            this.map = map;
            speed = rand.Next(30, 121);
            
        }
    }
}
