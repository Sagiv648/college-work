using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public class Map
    {
        List<Junction> junctions { get; set; }
        List<Road> roads;
        static Random rand = new Random();
        public Map(int wantedJunctionNum)
        {
            junctions = new List<Junction>(wantedJunctionNum);
            for(int i = 0; i < junctions.Capacity; i++)
            {
                junctions.Add(new Junction());

            }
            int randVal = GenerateRandom(0, junctions.Count + 1,true,0);
            while(randVal == junctions.Count)
                randVal = GenerateRandom(0, junctions.Count + 1, true, 0);

            roads = new List<Road>();
            List<int> buffer = new List<int>();
            buffer.Add(randVal);
            bool chance = true;
            for (int i = 0; i < junctions.Count; i = chance? i+1 : i+0  )
            {
                Console.WriteLine(randVal);
                roads.Add(new Road(junctions[i], junctions[randVal]));
                buffer.Add(randVal);

                randVal = GenerateRandom(0, junctions.Count + 1, true,i);
                while(randVal == junctions.Count || buffer.FindIndex(x => x == randVal) > -1)
                    randVal = GenerateRandom(0, junctions.Count + 1, true,i);

                 chance = Convert.ToBoolean(rand.Next(0, 2));
                if (chance)
                    buffer.Clear();

            }





            SetTrafficLights();
        }

        public Map(List<Junction> junctionCollection, List<Road> roadsCollection)
        {
            junctions = new List<Junction>();
            roads = new List<Road>();
            junctions.AddRange(junctionCollection);
            roads.AddRange(roadsCollection);
            SetTrafficLights();
        }

        private void SetTrafficLights()
        {
            int randVal;
            

            
            for (int i = 0; i < junctions.Count; i++)
            {
                if (junctions[i].GetEnteringRoads().Count > 0)
                {
                    
                    randVal = rand.Next(0, 101);
                    if (randVal <= 25)
                    {
                        Junction j = junctions[i];;
                        TrafficLight tl;
                        switch (rand.Next(0,2))
                        {
                            
                            case 0:

                                 tl = new RandomTrafficLight(j);
                                j.SetTrafficLight( tl);
                                
                                break;
                            case 1:
                                tl = new ConsistentTrafficLight(j);
                                j.SetTrafficLight( tl);
                                
                                break;
                            default:
                               
                                break;
                        }
                    }
                    
                }

            }
        } 

        private int GenerateRandom(int min,int max, bool secondChance,object exception)
        {
            int randSecondChance = secondChance ? 5 : 0;
            int randVal = rand.Next(min, max);
            while (randSecondChance > 0 && randVal == max)
            {
                if(exception != null && typeof(int) == exception.GetType() && randVal == (int)exception)
                {
                    randVal = rand.Next(min, max);
                    continue;

                }


                if (randVal < max)
                    return randVal;

                randVal = rand.Next(min, max);
                randSecondChance--;
            }
            return randVal;
            
        }

        

        public List<Road> SelectRandomJunction()
        {
            List<Road> output = new List<Road>();
            
            Junction startingPoint = junctions[GenerateRandom(0, junctions.Count, false, null)];
            Junction tmp = startingPoint;
            
            int i = 0;
            
            int j = 0;
            for(i = 0; i < 4; i++)
            {
                if (tmp == null)
                    break;

                Road r = roads.Find(x => x.GetStartingJunction() == tmp);
                output.Add(r);

                if (r.GetEndingJunction().GetExitingRoads().Count == 0)
                    break;
                
                tmp = roads.Find(x => x.GetStartingJunction() == output[output.Count - 1].GetEndingJunction()).GetStartingJunction();
                //Console.WriteLine("test road is {0}",roads.Find(x => x.GetStartingJunction() == output[output.Count - 1].GetEndingJunction()));
            }
            
            
            



            return output;
            
            /*
             * המחלקה מכילה מתודה שבוחרת צומת רנדומלי מאוסף הצמתים שבמפה, ובונה מסלול רנדומלי
המתחיל בצומת זה וממשיך ממנו עד שמגיע לצומת ללא מוצא (ללא כבישים יוצאים) או לאורך
מקסימלי של  4רחובות. המסלול מיוצג ע"י אוסף של כבישים, כאשר צומת סיום של כביש הוא
צומת התחלה של כביש הבא במסלול
             * 
             * 
             * 
             *
             *
             */

            


        }
    }
}
