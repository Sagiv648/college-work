using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._5_21_11_22
{
    public abstract class Game
    {
        private Player p1;
        private Player p2;
        string name;
        protected Action[] actions;
        public Game(Player p1, Player p2, string name)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.name = name;
        }
        protected abstract void InitActions();

        public void Play(int turnCount)
        {
            while(turnCount > 0)
            {
                PlaySingleTurn();
                turnCount--;
            }
        }
        void PlaySingleTurn()
        {

            RewardPlayers(p1.SelectAction(actions), p2.SelectAction(actions));

        }
        protected abstract void RewardPlayers(Action a1, Action a2);

        public Player GetWinner()
        {
            return p1.GetScore() == p2.GetScore() ? null : p1.GetScore() > p2.GetScore() ? p1 : p2 ;
        }
        protected Player GetFirstPlayer() => p1;

        protected Player GetSecondPlayer() => p2;
    }
}
