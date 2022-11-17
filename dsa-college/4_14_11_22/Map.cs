using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public class Map
    {
        Junction[] junctions;
        Road[] roads;
        static Random rand = new Random();
        public Map(int wantedJunctionNum)
        {
            junctions = new Junction[wantedJunctionNum];
            for(int i = 0; i < junctions.Length; i+=2)
            {
                junctions[i] = new Junction();
                
                junctions[i + 1] = new Junction();

                junctions[i].AddEnteringRoad( new Road(junctions[i + 1], junctions[i]));
                junctions[i].AddExitingRoad(new Road(junctions[i], junctions[i + 1]));
                junctions[i + 1].AddEnteringRoad(new Road(junctions[i], junctions[i + 1]));
                junctions[i+1].AddExitingRoad(new Road(junctions[i + 1], junctions[i]));

                



            }

            for(int i = 0; i < junctions.Length; i++)
            {
                if(rand.Next(0,101) <= 25)
                {
                    TrafficLight tl = null;
                    switch (rand.Next(0,2))
                    {
                        case 0:
                            tl = new RandomTrafficLight(junctions[i]);
                            break;
                        case 1:
                            tl = new ConsistentTrafficLight(junctions[i]);
                            break;

                        default:
                            break;
                    }
                    
                    junctions[i].SetTrafficLight(tl);
                }
            }
        }

        public Map(List<Junction> junctionCollection, List<Road> roadsCollection)
        {
            junctions = junctionCollection.ToArray();
            roads = roadsCollection.ToArray();

            for (int i = 0; i < junctions.Length; i++)
            {
                if (rand.Next(0, 101) <= 25)
                {
                    TrafficLight tl = null;
                    switch (rand.Next(0, 2))
                    {
                        case 0:
                            tl = new RandomTrafficLight(junctions[i]);
                            break;
                        case 1:
                            tl = new ConsistentTrafficLight(junctions[i]);
                            break;

                        default:
                            break;
                    }

                    junctions[i].SetTrafficLight(tl);
                }
            }
        }

        public void SelectRandomJunction()
        {
            
        }
    }
}
