using System;
namespace dsa_college._31_10_22
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Point a = new Point();
            a.SetX(900);
            Console.WriteLine(a);

            a.SetX(5);
            Console.WriteLine(a);

            a.SetY(3.25);
            Console.WriteLine(a);

            a.SetX(3);
            a.SetY(4);
            Console.WriteLine(a);

            Point b = new Point();

            Console.WriteLine(a.Distance(b));
            Console.WriteLine(b.Distance(a));
            Point c = new Point(15, -5);
            Point d = new Point(3, 4);
            d.Equals(a);
            d.Equals(c);
            Point e = new Point(d);
            e.Equals(a);




            Console.ReadLine();
            
        }
    }
}
