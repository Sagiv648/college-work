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
                Player winner = a1.GetName() == actions[1].GetName() ? GetFirstPlayer() : GetSecondPlayer();
                winner.UpdateScore(winner.GetScore() + 1);
            }
        }
    }
}
