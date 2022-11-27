using System;
using System.Text;
using System.Collections.Generic;


namespace dsa_college._5_21_11_22
{

    

    public class GameDriver
    {
        public static void Main(string[] args)
        {
            Player p1 = new RandomPlayer("Sagiv");
            Player p2 = new ConsistentPlayer("Tom");
            Game g = new RockPaperScissors(p1, p2);

            g.Play(5);
            Player winner = g.GetWinner();
            Console.WriteLine("{0}", winner == null ? "tie" : winner.GetName());






            Console.Read();
        }
    }
}