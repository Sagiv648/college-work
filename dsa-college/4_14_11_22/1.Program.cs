using System;
using System.Collections.Generic;


namespace dsa_college._4_14_11_22
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            //Point x = new Point(-1,-1);
            Junction a = new Junction();
            
            Junction b = new Junction();
            
            Road r = new Road(a, b);
            //r.GetLength();
            //Console.WriteLine(r);
            Junction c = new Junction();
            Road r2 = new Road(c, c);
            r2.GetLength();

            Console.WriteLine(r + "\n" + r2);

            Console.ReadLine();
        }
    }
}