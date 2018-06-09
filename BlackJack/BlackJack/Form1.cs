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
        private int Bet;
        private Player player;
        private Dealer dealer;
        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        public void newGame()
        {
            deck = new Deck();
            deck.ShuffleDeck();
            player = new Player();
            playerCashLabel.Text = "Player Cash: " + player.Cash.ToString();
            dealer = new Dealer();
            Bet = 0;
            betCashLabel.Text = "Bet: " + Bet.ToString();
            dealButton.Enabled = false;
            hitButton.Enabled = false;
            standButton.Enabled = false;
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            deck.PlayerDeal(player);
            deck.DealerDeal(dealer);
            label1.Text = "Player Hand Value: " + player.Hand1Value().ToString();
            label2.Text = "Dealer Hand Value: " + dealer.HandValue().ToString();
            label3.Text = "Player Hand: " + player.ShowHand1();
            label4.Text = "Dealer Hand: " + dealer.ShowHand();
            startRound();
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            if (player.Hand1Value() < 21)
            {
                deck.PlayerHit(player);
                label3.Text = "Player Hand: " + player.ShowHand1();
                label1.Text = "Player Hand Value: " + player.Hand1Value().ToString();
                if(player.Hand1Value() > 21)
                {
                    //playerLost();
                    MessageBox.Show("Busted");
                    newRound();
                    return;
                }
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            if (dealer.Hand.Count == 2)
            {
                dealer.Hand[1].ShowFace = true;
                label2.Text = "Dealer Hand Value: " + dealer.HandValue().ToString();
                label4.Text = "Dealer Hand: " + dealer.ShowHand();
            }
            while (dealer.HandValue() < 17)
            {
                deck.DealerHit(dealer);
                label2.Text = "Dealer Hand Value: " + dealer.HandValue().ToString();
                label4.Text = "Dealer Hand: " + dealer.ShowHand();
            }
            if (dealer.HandValue() > 21 || dealer.HandValue() < player.Hand1Value())
            {
                MessageBox.Show("Player Won");
                playerWon();
                newRound();
                return;
            }
            if (dealer.HandValue() == player.Hand1Value())
            {
                MessageBox.Show("Push");
                push();
                newRound();
                return;
            }
            if (dealer.HandValue() <= 21 && dealer.HandValue() > player.Hand1Value())
            {
                MessageBox.Show("You lose.");
                playerLost();
                newRound();
                return;
            }
        }

        private void playerWon()
        {
            player.Cash += 2 * Bet;
            Bet = 0;
            playerCashLabel.Text = "Player Cash: " + player.Cash.ToString();
            betCashLabel.Text = "Bet: " + Bet.ToString();
        }

        private void push()
        {
            player.Cash += Bet;
            Bet = 0;
            playerCashLabel.Text = "Player Cash: " + player.Cash.ToString();
            betCashLabel.Text = "Bet: " + Bet.ToString();
        }

        private void playerLost()
        {
            Bet = 0;
            betCashLabel.Text = "Bet: " + Bet.ToString();
        }

        private void bet500Button_Click(object sender, EventArgs e)
        {
            if(player.Cash >= 500)
            {
                player.Cash -= 500;
                playerCashLabel.Text = "Player Cash: " + player.Cash.ToString();
                Bet += 500;
                betCashLabel.Text = "Bet: " + Bet.ToString();
                dealButton.Enabled = true;
            }
        }

        private void newRound()
        {
            bet500Button.Enabled = true;
            dealButton.Enabled = false;
            hitButton.Enabled = false ;
            standButton.Enabled = false;
            player.Hand1.RemoveRange(0, player.Hand1.Count);
            dealer.Hand.RemoveRange(0, dealer.Hand.Count);
            label1.Text = "Player Hand Value: ";
            label2.Text = "Dealer Hand Value: ";
            label3.Text = "Player Hand: ";
            label4.Text = "Dealer Hand: ";
        }

        private void startRound()
        {
            bet500Button.Enabled = false;
            dealButton.Enabled = false;
            hitButton.Enabled = true;
            standButton.Enabled = true;
        }

        
    }
}
