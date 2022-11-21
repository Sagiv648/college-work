using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._5_21_11_22
{
    public class RandomPlayer : Player
    {
        static Random rand = new Random();

        public RandomPlayer(string name) : base(name) { }
        
        

        public override Action SelectAction(Action[] actions)
        {
            return actions[rand.Next(actions.Length)];
        }
    }
}
