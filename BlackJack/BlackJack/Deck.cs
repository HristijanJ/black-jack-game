using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Properties;

namespace BlackJack
{
    [Serializable]
    public class Deck
    {
        public List<Card> Cards { get; set; }
        
        public Deck()
        {
            Cards = new List<Card>();
            Card card;
            for (int i = 2; i<15; i++)
            {
                for (int j = 0; j < 4; j++) // j == number of Decks of 52 cards
                {
                    if (i == 11)
                    {
                        card = new Card("A", "H", Resources.AH);
                        Cards.Add(card);
                        card = new Card("A", "C", Resources.AC);
                        Cards.Add(card);
                        card = new Card("A", "D", Resources.AD);
                        Cards.Add(card);
                        card = new Card("A", "S", Resources.AS);
                        Cards.Add(card);
                    }
                    else if (i == 12)
                    {
                        card = new Card("J", "H", Resources.JH);
                        Cards.Add(card);
                        card = new Card("J", "C", Resources.JC);
                        Cards.Add(card);
                        card = new Card("J", "D", Resources.JD);
                        Cards.Add(card);
                        card = new Card("J", "S", Resources.JS);
                        Cards.Add(card);
                    }
                    else if (i == 13)
                    {
                        card = new Card("Q", "H", Resources.QH);
                        Cards.Add(card);
                        card = new Card("Q", "C", Resources.QC);
                        Cards.Add(card);
                        card = new Card("Q", "D", Resources.QD);
                        Cards.Add(card);
                        card = new Card("Q", "S", Resources.QS);
                        Cards.Add(card);
                    }
                    else if (i == 14)
                    {
                        card = new Card("K", "H", Resources.KH);
                        Cards.Add(card);
                        card = new Card("K", "C", Resources.KC);
                        Cards.Add(card);
                        card = new Card("K", "D", Resources.KD);
                        Cards.Add(card);
                        card = new Card("K", "S", Resources.KS);
                        Cards.Add(card);
                    }
                    else
                    {
                        if (i == 2)
                        {
                            card = new Card("2", "H", Resources._2H);
                            Cards.Add(card);
                            card = new Card("2", "C", Resources._2C);
                            Cards.Add(card);
                            card = new Card("2", "D", Resources._2D);
                            Cards.Add(card);
                            card = new Card("2", "S", Resources._2S);
                            Cards.Add(card);
                        }
                        else if (i == 3)
                        {
                            card = new Card("3", "H", Resources._3H);
                            Cards.Add(card);
                            card = new Card("3", "C", Resources._3C);
                            Cards.Add(card);
                            card = new Card("3", "D", Resources._3D);
                            Cards.Add(card);
                            card = new Card("3", "S", Resources._3S);
                            Cards.Add(card);
                        }
                        else if (i == 4)
                        {
                            card = new Card("4", "H", Resources._4H);
                            Cards.Add(card);
                            card = new Card("4", "C", Resources._4C);
                            Cards.Add(card);
                            card = new Card("4", "D", Resources._4D);
                            Cards.Add(card);
                            card = new Card("4", "S", Resources._4S);
                            Cards.Add(card);
                        }
                        else if (i == 5)
                        {
                            card = new Card("5", "H", Resources._5H);
                            Cards.Add(card);
                            card = new Card("5", "C", Resources._5C);
                            Cards.Add(card);
                            card = new Card("5", "D", Resources._5D);
                            Cards.Add(card);
                            card = new Card("5", "S", Resources._5S);
                            Cards.Add(card);
                        }
                        else if(i == 6)
                        {
                            card = new Card("6", "H", Resources._6H);
                            Cards.Add(card);
                            card = new Card("6", "C", Resources._6C);
                            Cards.Add(card);
                            card = new Card("6", "D", Resources._6D);
                            Cards.Add(card);
                            card = new Card("6", "S", Resources._6S);
                            Cards.Add(card);
                        }
                        else if (i == 7)
                        {
                            card = new Card("7", "H", Resources._7H);
                            Cards.Add(card);
                            card = new Card("7", "C", Resources._7C);
                            Cards.Add(card);
                            card = new Card("7", "D", Resources._7D);
                            Cards.Add(card);
                            card = new Card("7", "S", Resources._7S);
 
                            Cards.Add(card);
                        }
                        else if (i == 8)
                        {
                            card = new Card("8", "H", Resources._8H);
                            Cards.Add(card);
                            card = new Card("8", "C", Resources._8C);
                            Cards.Add(card);
                            card = new Card("8", "D", Resources._8D);
                            Cards.Add(card);
                            card = new Card("8", "S", Resources._8S);
                            Cards.Add(card);
                        }
                        else if (i == 9)
                        {
                            card = new Card("9", "H", Resources._9H);
                            Cards.Add(card);
                            card = new Card("9", "C", Resources._9C);
                            Cards.Add(card);
                            card = new Card("9", "D", Resources._9D);
                            Cards.Add(card);
                            card = new Card("9", "S", Resources._9S);
                            Cards.Add(card);
                        }
                        else if (i == 10)
                        {
                            card = new Card("10", "H", Resources._10H);
                            Cards.Add(card);
                            card = new Card("10", "C", Resources._10C);
                            Cards.Add(card);
                            card = new Card("10", "D", Resources._10D);
                            Cards.Add(card);
                            card = new Card("10", "S", Resources._10S);
                            Cards.Add(card);
                        }
                    }
                }
            }
        }

        public void ShuffleDeck()
        {
            Random rand = new Random();
            int deckSize = Cards.Count;
            for (int i = 0; i < deckSize; i++)
            {
                Card card = Cards[i];
                int randomNumber = rand.Next(deckSize);
                Cards[i] = Cards[randomNumber];
                Cards[randomNumber] = card;
            }
        }

        public void PlayerDeal(Player player)
        {
            Card card = Cards[0];
            Card card1 = Cards[1];
            card.ShowFace = true;
            card1.ShowFace = true;
            Cards.RemoveAt(0);
            Cards.RemoveAt(0);
            player.Hand1.Add(card);
            player.Hand1.Add(card1);
        }
        public void DealerDeal(Dealer dealer)
        {
            Card card = Cards[0];
            Card card1 = Cards[1];
            card.ShowFace = true;
            card1.ShowFace = false;
            Cards.RemoveAt(0);
            Cards.RemoveAt(0);
            dealer.Hand.Add(card);
            dealer.Hand.Add(card1);
        }

        public void DealerHit(Dealer dealer)
        {
            Card card = Cards[0];
            card.ShowFace = true;
            Cards.RemoveAt(0);
            dealer.Hand.Add(card);
        }

        public void PlayerHit(Player player)
        {
            Card card = Cards[0];
            card.ShowFace = true;
            Cards.RemoveAt(0);
            player.Hand1.Add(card);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Card c in Cards)
            {
                sb.Append(c.ToString());
            }
            return sb.ToString();
        }
    }
}
