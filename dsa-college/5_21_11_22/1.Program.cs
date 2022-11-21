using System;
using System.Text;
using System.Collections.Generic;


namespace dsa_college._5_21_11_22
{
    public class GameDriver
    {
        public static void Main(string[] args)
        {
            Player p1 = new ConsistentPlayer("sagiv");
            Player p2 = new ConsistentPlayer("Tom");
            Game g = new PrisonerDilemmas(p1,p2);
            g.Play(5);
            Console.WriteLine(g.GetWinner().GetName());

            Console.Read();
        }
    }
}