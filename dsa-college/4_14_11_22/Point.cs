using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._4_14_11_22
{
    public class Point
    {
        double axisX;
        double axisY;
        static Random rand = new Random();
        public Point(double x, double y)
        {
            axisX = checkAndGenerateRandom(x, 0, 800, 'X');
            axisY = checkAndGenerateRandom(y, 0, 600, 'Y');

            if (GetType() == typeof(Point))
                Console.WriteLine($"Creating new {this}");
        }
        public Point(Point other) : this(other.axisX, other.axisY) { }

        public Point() : this(rand.NextDouble() + rand.Next(0,800), rand.NextDouble() + rand.Next(0, 600)) { }
        
            
            
        

        public override string ToString()
        {
            return string.Format("Point ({0:f2},{1:f2})", axisX,axisY);
        }


        private double checkAndGenerateRandom(double val,int min, int max, char flag)
        {
            
            if(val < min || val > max)
            {
                
                val = rand.Next(min, max + 1);
                if (val < max)
                    val += rand.NextDouble();
                
                Console.WriteLine($"Incorrect value of {flag}, the new value will be {val}");
            }
            
                
            return val;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Point another = (Point)obj;
            return ((another.axisX == axisX) && (another.axisY == axisY));
        }
        public double Distance(Point another)
        {
            double output = Math.Sqrt(
                Math.Pow((axisX - another.axisX), 2) +
                Math.Pow((axisY - another.axisY), 2)
                );
                if(GetType() == typeof(Point))
                    Console.WriteLine("The distance between {0} and {1} is {2:f2}", this, another, output);
               
            //d^2 = (x1-x2)^2 + (y1-y2)^2
            return output;
        }
    }
}
