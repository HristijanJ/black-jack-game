using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private BlackJack bj;
        private String FileName;
        
        public Form1()
        {

            InitializeComponent();
            newGame();
            bj = new BlackJack();
            
        }
        
        public void newGame()
        {
            bj = new BlackJack();
           
            
            playerCashLabel.Text = "Player Cash: " + bj.player.Cash.ToString();
           
            betCashLabel.Text = "Bet: " + bj.Bet.ToString();
            dealButton.Enabled = false;
            hitButton.Enabled = false;
            standButton.Enabled = false;
            doubleButton.Enabled = false;
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            bj.deck.PlayerDeal(bj.player);
           bj. deck.DealerDeal(bj.dealer);
            label1.Text = "Player Hand Value: " + bj.player.Hand1Value().ToString();
            label2.Text = "Dealer Hand Value: " +bj. dealer.HandValue().ToString();
            label3.Text = "Player Hand: " +bj. player.ShowHand1();
            label4.Text = "Dealer Hand: " +bj. dealer.ShowHand();
            startFirstRound();
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            doubleButton.Enabled = false;
            if (bj.player.Hand1Value() < 21)
            {
                bj.deck.PlayerHit(bj.player);
                label3.Text = "Player Hand: " + bj.player.ShowHand1();
                label1.Text = "Player Hand Value: " +bj. player.Hand1Value().ToString();
                if (bj.player.Hand1Value() > 21)
                {
                    playerLost();
                    MessageBox.Show("Busted");
                    newRound();
                    return;
                }
            }
            if (bj.player.Hand1Value() == 21)
                standButton_Click(sender, e);
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            doubleButton.Enabled = false;
            if (bj.dealer.Hand.Count == 2)
            {
                bj.dealer.Hand[1].ShowFace = true;
                label2.Text = "Dealer Hand Value: " + bj.dealer.HandValue().ToString();
                label4.Text = "Dealer Hand: " + bj.dealer.ShowHand();
            }
            if (bj.player.isBlackJack() && !bj.dealer.isBlackJack())
            {
                MessageBox.Show("You win with Black Jack.");
                blackJackWin();
                newRound();
                return;
            }
            while (bj.dealer.HandValue() < 17)
            {
                bj.deck.DealerHit(bj.dealer);
                label2.Text = "Dealer Hand Value: " + bj.dealer.HandValue().ToString();
                label4.Text = "Dealer Hand: " + bj.dealer.ShowHand();
            }
            if (bj.dealer.HandValue() > 21 || bj.dealer.HandValue() < bj.player.Hand1Value())
            {
                MessageBox.Show("Player Won");
                playerWon();
                newRound();
                return;
            }
            if (bj.dealer.HandValue() == bj.player.Hand1Value())
            {
                if (bj.dealer.isBlackJack() && !bj.player.isBlackJack())
                {
                    MessageBox.Show("You lose.");
                    playerLost();
                    newRound();
                    return;
                }
                else if (!bj.dealer.isBlackJack() && bj.player.isBlackJack())
                {
                    MessageBox.Show("You win with Black Jack.");
                    blackJackWin();
                    newRound();
                    return;
                }
                else
                {
                    MessageBox.Show("Push");
                    push();
                    newRound();
                    return;
                }
            }
            if (bj.dealer.HandValue() <= 21 && bj.dealer.HandValue() > bj.player.Hand1Value())
            {
                MessageBox.Show("You lose.");
                playerLost();
                newRound();
                return;
            }
        }

        private void blackJackWin()
        {
            bj.player.Cash += (int)(2.5 * bj.Bet);
           bj. Bet = 0;
            playerCashLabel.Text = "Player Cash: " + bj.player.Cash.ToString();
            betCashLabel.Text = "Bet: " + bj.Bet.ToString();
        }

        private void playerWon()
        {
            bj.player.Cash += 2 * bj.Bet;
            bj.Bet = 0;
            playerCashLabel.Text = "Player Cash: " + bj.player.Cash.ToString();
            betCashLabel.Text = "Bet: " + bj.Bet.ToString();
        }

        private void push()
        {
            bj.player.Cash += bj.Bet;
            bj.Bet = 0;
            playerCashLabel.Text = "Player Cash: " + bj.player.Cash.ToString();
            betCashLabel.Text = "Bet: " + bj.Bet.ToString();
        }

        private void playerLost()
        {
           bj. Bet = 0;
            betCashLabel.Text = "Bet: " + bj.Bet.ToString();
        }

        private void bet500Button_Click(object sender, EventArgs e)
        {
            if (bj.player.Cash >= 500)
            {
                bj.player.Cash -= 500;
                playerCashLabel.Text = "Player Cash: " + bj.player.Cash.ToString();
                bj.Bet += 500;
                betCashLabel.Text = "Bet: " + bj.Bet.ToString();
                dealButton.Enabled = true;
            }
        }

        private void newRound()
        {

            bet500Button.Enabled = true;
            dealButton.Enabled = false;
            hitButton.Enabled = false;
            standButton.Enabled = false;
            doubleButton.Enabled = false;
            bj.player.Hand1.RemoveRange(0, bj.player.Hand1.Count);
            bj.dealer.Hand.RemoveRange(0, bj.dealer.Hand.Count);
            label1.Text = "Player Hand Value: ";
            label2.Text = "Dealer Hand Value: ";
            label3.Text = "Player Hand: ";
            label4.Text = "Dealer Hand: ";
            if (bj.deck.Cards.Count <= 25)
            {
                bj.deck = new Deck();
                bj.deck.ShuffleDeck();
                MessageBox.Show("Reshuffled deck");
            }
        }

        private void startFirstRound()
        {
            bet500Button.Enabled = false;
            dealButton.Enabled = false;
            hitButton.Enabled = true;
            standButton.Enabled = true;
            if (bj.player.Cash >= bj.Bet &&bj. player.Hand1Value() < 21)
            {
                doubleButton.Enabled = true;
            }
        }

        private void doubleButton_Click(object sender, EventArgs e)
        {
            bj.deck.PlayerHit(bj.player);
           bj. player.Cash -= bj.Bet;
            bj.Bet += bj.Bet;
            playerCashLabel.Text = "Player Cash: " + bj.player.Cash.ToString();
            betCashLabel.Text = "Bet: " + bj.Bet.ToString();
            label3.Text = "Player Hand: " + bj.player.ShowHand1();
            label1.Text = "Player Hand Value: " +bj. player.Hand1Value().ToString();
            if (bj.player.Hand1Value() > 21)
            {
                playerLost();
                MessageBox.Show("Busted");
                newRound();
                return;
            }
            standButton_Click(sender, e);
        }
        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Black JAck (*.bj)|*.bj";
                saveFileDialog.Title = "Save Black Jack";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, bj);
                    

                }
            }
        }

        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Black Jack (*.bj)|*.bj";
            openFileDialog.Title = "Open Black JAck file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        bj = (BlackJack)formater.Deserialize(fileStream);
                        


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }


        }

          

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bj.kesh = playerCashLabel.Text;
            bj.bet = betCashLabel.Text;
            bj.deal = dealButton.Enabled;
            bj.bet500 = bet500Button.Enabled;
            bj.doub = doubleButton.Enabled;
            bj.hit = hitButton.Enabled;
            bj.stand = standButton.Enabled;
            bj.playerHand = label3.Text;
            bj.playerZbir = bj.player.Hand1Value();
            bj.dilerHand = label4.Text;
            bj.dilerZbir = bj.dealer.HandValue();
            saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
            playerCashLabel.Text = bj.kesh;
            betCashLabel.Text = bj.bet;
            dealButton.Enabled = bj.deal;
            bet500Button.Enabled = bj.bet500;
            doubleButton.Enabled = bj.doub;
            hitButton.Enabled = bj.hit;
            standButton.Enabled = bj.stand;
            label3.Text = bj.playerHand;
            label1.Text = bj.playerZbir.ToString();
            label4.Text = bj.dilerHand;
            label2.Text = bj.dilerZbir.ToString();
        }
       
    }
}
