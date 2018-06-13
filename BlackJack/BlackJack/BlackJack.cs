using System;
using BlackJack.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    [Serializable]
    public class BlackJack
    {
        public Deck deck { get; set; }
        public int Bet { get; set; }
        public Player player { get; set; }
        public Dealer dealer { get; set; }
        public String kesh { get; set; }
        public String bet { get; set; }
        public bool bet500 { get; set; }
        public bool deal { get; set; }
        public bool hit { get; set; }
        public bool doub { get; set; }
        public bool stand { get; set; }
        public String playerHand { get; set; }
        public int playerZbir { get; set; }
        public String dilerHand { get; set; }
        public int dilerZbir { get; set; }
        public Image tabla;

        public BlackJack()
        {
            deck = new Deck();
            deck.ShuffleDeck();
            Bet = 0;
            player = new Player();
            dealer = new Dealer();
            tabla = Resources.tabla;
        }
        
        

    }
}
