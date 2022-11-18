using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public class DrivingGame
    {
        List<Vehicle> vehiclesAmount;
        Map map;

        public DrivingGame(int wantedVehsAmount, int wantedJunctionsAmount)
        {
            map = new Map(wantedJunctionsAmount);
            vehiclesAmount = new List<Vehicle>(wantedVehsAmount);
            for (int i = 0; i < wantedVehsAmount; i++)
                vehiclesAmount.Add(new Vehicle(map));
            
        }
        public void Play(int turns)
        {
            int k = 1;
            while(k <= turns)
            {
                Console.WriteLine($"\n\nTurn {k}:\n\n");
                for(int i = 0; i < vehiclesAmount.Count; i++)
                {
                    vehiclesAmount[i].Move();
                    int j = 0;
                    //for(; j < vehiclesAmount[i].GetRoute().Count; j++)
                    //{
                    //    vehiclesAmount[i].GetRoute()[j].GetStartingJunction().GetTrafficLight().Check();
                    //}
                }
                k++;
            }
        }
    }
}
