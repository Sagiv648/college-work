using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._5_21_11_22
{
    public abstract class Player
    {
        string name;
        int score;
        public Player(string name)
        {
            this.name = name;
            score = 0;
        }
        public abstract Action SelectAction(Action[] actions);

        public bool IsWinner(Player p)
        {

            return score > p.GetScore();

        }
        public void UpdateScore(int score)
        {
            this.score = score;
        }
        public int GetScore() => score;

        public string GetName() => name;
    }
}
