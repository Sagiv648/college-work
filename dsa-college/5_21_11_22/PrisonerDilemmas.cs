using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._5_21_11_22
{
    class PrisonerDilemmas : Game
    {
        public PrisonerDilemmas(Player p1, Player p2) : base(p1, p2, "Prisoner's Dilema")
        {
            actions = new Action[2];
            InitActions();
        }

        protected override void InitActions()
        {
            actions[0] = new Action("Silence");
            actions[1] = new Action("Singing");
        }

        protected override void RewardPlayers(Action a1, Action a2)
        {
            if (!a1.Equals(a2))
            {
                Console.WriteLine($"{GetFirstPlayer().GetName()}: {a1.GetName()}({GetFirstPlayer().GetScore()}) -- {GetSecondPlayer().GetName()}:{a2.GetName()}({GetSecondPlayer().GetScore()})");


                GetFirstPlayer().UpdateScore(GetFirstPlayer().GetScore() + (a1.GetName() == actions[1].GetName() ? 1 : 0));
                GetSecondPlayer().UpdateScore(GetSecondPlayer().GetScore() + (a2.GetName() == actions[1].GetName() ? 1 : 0));
            }
        }
    }
}
