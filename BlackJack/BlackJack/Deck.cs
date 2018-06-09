using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        
        public Deck()
        {
            Cards = new List<Card>();
            for (int i = 2; i<15; i++)
            {
                for (int j = 0; j < 4; j++) // j == number of Decks of 52 cards
                {
                    if (i == 11)
                    {
                        Cards.Add(new Card("A", "H"));
                        Cards.Add(new Card("A", "C"));
                        Cards.Add(new Card("A", "D"));
                        Cards.Add(new Card("A", "S"));
                    }
                    else if (i == 12)
                    {
                        Cards.Add(new Card("J", "H"));
                        Cards.Add(new Card("J", "C"));
                        Cards.Add(new Card("J", "D"));
                        Cards.Add(new Card("J", "S"));
                    }
                    else if (i == 13)
                    {
                        Cards.Add(new Card("Q", "H"));
                        Cards.Add(new Card("Q", "C"));
                        Cards.Add(new Card("Q", "D"));
                        Cards.Add(new Card("Q", "S"));
                    }
                    else if (i == 14)
                    {
                        Cards.Add(new Card("K", "H"));
                        Cards.Add(new Card("K", "C"));
                        Cards.Add(new Card("K", "D"));
                        Cards.Add(new Card("K", "S"));
                    }
                    else
                    {
                        Cards.Add(new Card(i.ToString(), "H"));
                        Cards.Add(new Card(i.ToString(), "C"));
                        Cards.Add(new Card(i.ToString(), "D"));
                        Cards.Add(new Card(i.ToString(), "S"));
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
