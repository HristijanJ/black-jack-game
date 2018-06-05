using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private Deck deck;
        private Player player;
        private Dealer dealer;
        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            player = new Player();
            dealer = new Dealer();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deck.ShuffleDeck();
            deck.PlayerDeal(player);
            deck.DealerDeal(dealer);
            MessageBox.Show(deck.ToString());
            label1.Text = "Player Hand Value: " + player.Hand1Value().ToString();
            label2.Text = "Dealer Hand Value: " + dealer.HandValue().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player.Hand1Value() < 21) {
                deck.PlayerHit(player);
                MessageBox.Show(player.ShowHand1());
                label1.Text = "Player Hand Value: " + player.Hand1Value().ToString();
            }
            else
            {
                MessageBox.Show("Busted or 21");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dealer.HandValue() < 17)
            {
                deck.DealerHit(dealer);
                MessageBox.Show(dealer.ShowHand());
                label2.Text = "Dealer Hand Value: " + dealer.HandValue().ToString();
            }
        }

    }
}
