using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public class DrivingGame
    {
        Vehicle[] vehiclesAmount;
        Map map;

        public DrivingGame(int wantedVehsAmount, int wantedJunctionsAmount)
        {
            vehiclesAmount = new Vehicle[wantedVehsAmount];
            map = new Map(wantedJunctionsAmount);
        }
        public void Play(int turns)
        {

        }
    }
}
