using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._31_10_22
{
    public class Point
    {
        double _X;
        double _Y;
        static double MAX_X = 800;
        static double MAX_Y = 600;

        public Point()
        {
            _X = _Y = 0;
            Console.WriteLine($"Creating point ({_X},{_Y})");
        }
        public Point(double x = 0, double y = 0)
        {
            if ((x < 0 || x > MAX_X) || (y < 0 || y > MAX_Y))
                Console.WriteLine("Incorrect values");
            else
            {
                _X = x;
                _Y = y;
                Console.WriteLine($"Creating point ({_X},{_Y})");
            }
           
        }
        public Point(Point another)
        {
            _X = another._X;
            _Y = another._Y;
            Console.WriteLine($"Creating point ({another._X},{another._Y})");
        }


        private bool IsInRange(double num, char rep)
        {
            if (rep == 'X')
                return num >= 0 && num <= MAX_X;
            else if (rep == 'Y')
                return num >= 0 && num <= MAX_Y;

            return false;
        }

        public void SetX(double x)
        {
            if (!IsInRange(x, 'X'))
                Console.WriteLine("Not in range.");
            else
                _X = x;
        }
        public double GetX()
        {
            return _X;
        }
        public void SetY(double y)
        {
            if (!IsInRange(y, 'Y'))
                Console.WriteLine("Not in range.");
            else
                _Y = y;
        }
        public double GetY()
        {
            return _Y;
        }



        public override string ToString()
        {
            return $"Point ({_X},{_Y})";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Point another = (Point)obj;
            return ((another._X == _X) && (another._Y == _Y));
        }
        public double Distance(Point another)
        {
            //d^2 = (x1-x2)^2 + (y1-y2)^2
            return Math.Sqrt(
                Math.Pow((_X - another._X), 2) + 
                Math.Pow((_Y - another._Y), 2)
                );
        }
    }
}
