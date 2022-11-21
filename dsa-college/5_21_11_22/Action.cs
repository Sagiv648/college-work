using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._5_21_11_22
{
    public class Action
    {
        string name;
        public Action(string name)
        {
            this.name = name;
        }
        public string GetName() => name;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Action act = (Action)obj;

            return name == act.name;
        }
    }
}
