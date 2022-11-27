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
            InitActions();
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
                Console.WriteLine($"{GetFirstPlayer().GetName()}: {a1.GetName()}({GetFirstPlayer().GetScore()}) -- {GetSecondPlayer().GetName()}:{a2.GetName()}({GetSecondPlayer().GetScore()})");


                switch (a1.GetName())
                {
                    case "Rock":
                        GetSecondPlayer().UpdateScore(GetSecondPlayer().GetScore() + (a2.GetName() == "Paper" ?  1 : 0));
                        GetFirstPlayer().UpdateScore(GetFirstPlayer().GetScore() + (a2.GetName() == "Paper" ? 0 : 1));
                        break;
                    case "Scissors":
                        GetSecondPlayer().UpdateScore(GetSecondPlayer().GetScore() +  (a2.GetName() == "Rock" ? 1 : 0));
                        GetFirstPlayer().UpdateScore(GetFirstPlayer().GetScore() + (a2.GetName() == "Rock" ? 0 : 1));
                        break;
                    case "Paper":
                        GetSecondPlayer().UpdateScore(GetSecondPlayer().GetScore() +  (a2.GetName() == "Scissors" ? 1 : 0));
                        GetFirstPlayer().UpdateScore( GetFirstPlayer().GetScore() +  (a2.GetName() == "Scissors" ? 0 : 1));
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
