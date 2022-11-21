using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._5_21_11_22
{
    public class ConsistentPlayer : Player
    {
        int lastIdx;
        public ConsistentPlayer(string name) : base(name)
        {
            lastIdx = -1;
        }

        public override Action SelectAction(Action[] actions)
        {
            lastIdx = (lastIdx + 1) % actions.Length;

            return actions[lastIdx];
        }
    }
}
