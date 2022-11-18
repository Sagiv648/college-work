using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public class Junction : Point
    {
        List<Road> enteringRoads = new List<Road>();
        List<Road> exitingRoads = new List<Road>();
        TrafficLight trafficLight;
        static int counter = 0;
        int jId;

        public Junction() 
        {
            //trafficLight = new ConsistentTrafficLight(this);
            jId = ++counter;
            Console.WriteLine($"Creating {this} at {base.ToString()}");
        }



        public override string ToString()
        {
            return $"Junction {jId}";
        }
        public void AddEnteringRoad(Road road) => enteringRoads.Add(road);

        public void AddExitingRoad(Road road) => exitingRoads.Add(road);

        

        public int GetJId() => jId;

        public List<Road> GetEnteringRoads() => enteringRoads;

        public List<Road> GetExitingRoads() => exitingRoads;

        public void SetTrafficLight(TrafficLight tl) {
            
            trafficLight = tl;
            
        }

        public TrafficLight GetTrafficLight() => trafficLight;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Junction junc = (Junction)obj;

            return junc.jId == jId;
        }
    }
}
