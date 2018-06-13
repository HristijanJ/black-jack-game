using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    [Serializable]
   public class Serialazible
    {
        public Deck deck { get; set; }
        public Dealer dealer { get; set; }
        public Player player { get; set; }
        public int bet { get; set; }

        public Serialazible(Deck d, Dealer de,Player p,int b)
        {
            deck = d;
            dealer = de;
            player = p;
            bet = b;
        }
    }
}
