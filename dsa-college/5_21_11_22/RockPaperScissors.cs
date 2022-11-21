using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._5_21_11_22
{
    public class RockPaperScissors : Game
    {
        public RockPaperScissors(Player p1, Player p2) : base(p1, p2, "Rock Paper Scissors")
        {
            actions = new Action[3];
        }

        protected override void InitActions()
        {
            actions[0] = new Action("Rock");
            actions[1] = new Action("Scissors");
            actions[2] = new Action("Paper");
        }

        protected override void RewardPlayers(Action a1, Action a2)
        {
            if (!a1.Equals(a2))
            {
                switch (a1.GetName())
                {
                    case "Rock":
                        GetSecondPlayer().UpdateScore(a2.GetName() == "Paper" ? GetSecondPlayer().GetScore() + 1 : 0);
                        GetFirstPlayer().UpdateScore(a2.GetName() == "Paper" ? 0 : GetFirstPlayer().GetScore() + 1);
                        break;
                    case "Scissors":
                        GetSecondPlayer().UpdateScore(a2.GetName() == "Rock" ? GetSecondPlayer().GetScore() + 1 : 0);
                        GetFirstPlayer().UpdateScore(a2.GetName() == "Rock" ? 0 : GetFirstPlayer().GetScore() + 1);
                        break;
                    case "Paper":
                        GetSecondPlayer().UpdateScore(a2.GetName() == "Scissors" ? GetSecondPlayer().GetScore() + 1 : 0);
                        GetFirstPlayer().UpdateScore(a2.GetName() == "Scissors" ? 0 : GetFirstPlayer().GetScore() + 1);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
