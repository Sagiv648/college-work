using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._0_dsa_exams._1_Summer_2021_A
{
    public class Tablet
    {
        public string name;
        public string kind;
        public char system;
        public double size;
        public double price;

        public Tablet(string name, string kind, char system, double size, double price)
        {
            this.name = name;
            this.kind = kind;
            this.system = system;
            this.size = size;
            this.price = price;
        }

        public bool IsSame(Tablet other)
        {
            return name == other.name && kind == other.kind && size == other.size;
        }
    }
}
