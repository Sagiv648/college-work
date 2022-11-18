using System;
using System.Collections.Generic;


namespace dsa_college._4_14_11_22
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("==========Point=========");
            Point a = new Point(0,0);
            Point b = new Point(8, 6);
            a.Distance(b);

            Point c = new Point();

            Point e = new Point();
            Point f = new Point();

            Console.WriteLine("================Junction==============");

            a = new Junction();
            b = new Junction();
            a.Distance(b); 
             Junction j1 = (Junction)a;
             Junction j2 = (Junction)b;

            Console.WriteLine("===============Road=============");
           
            Road r1 = new Road(j1,j2);
            r1.GetRoadLength();
            Console.WriteLine(r1);
            Junction j3 = new Junction();
            Road r2 = new Road(j3, j3);
            r2.GetRoadLength();

            Console.WriteLine("=============Map=========");
            Map m = new Map(13);

            

            List<Road> test = m.SelectRandomJunction();

            Console.WriteLine("========== Test Map random junction ======");

            DrivingGame game = new DrivingGame(10, 20);
            game.Play(10);

            Console.ReadLine();
        }
    }
}