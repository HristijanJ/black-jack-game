using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public List<Card> cards { get; set; }
        
        public Deck()
        {
            cards = new List<Card>();
            for (int i = 2; i<15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 11)
                    {
                        cards.Add(new Card("A", "H"));
                        cards.Add(new Card("A", "C"));
                        cards.Add(new Card("A", "D"));
                        cards.Add(new Card("A", "S"));
                    }
                    else if (i == 12)
                    {
                        cards.Add(new Card("J", "H"));
                        cards.Add(new Card("J", "C"));
                        cards.Add(new Card("J", "D"));
                        cards.Add(new Card("J", "S"));
                    }
                    else if (i == 13)
                    {
                        cards.Add(new Card("Q", "H"));
                        cards.Add(new Card("Q", "C"));
                        cards.Add(new Card("Q", "D"));
                        cards.Add(new Card("Q", "S"));
                    }
                    else if (i == 14)
                    {
                        cards.Add(new Card("K", "H"));
                        cards.Add(new Card("K", "C"));
                        cards.Add(new Card("K", "D"));
                        cards.Add(new Card("K", "S"));
                    }
                    else
                    {
                        cards.Add(new Card(i.ToString(), "H"));
                        cards.Add(new Card(i.ToString(), "C"));
                        cards.Add(new Card(i.ToString(), "D"));
                        cards.Add(new Card(i.ToString(), "S"));
                    }
                }
            }
        }

        public void ShuffleDeck()
        {
            Random rand = new Random();
            int deckSize = cards.Count;
            for (int i = 0; i < deckSize; i++)
            {
                Card card = cards[i];
                int randomNumber = rand.Next(deckSize);
                cards[i] = cards[randomNumber];
                cards[randomNumber] = card;
            }
        }

        public void PlayerDeal(Player player)
        {
            Card card = cards[0];
            Card card1 = cards[1];
            card.ShowFace = true;
            card1.ShowFace = true;
            cards.RemoveAt(0);
            cards.RemoveAt(0);
            player.Hand1.Add(card);
            player.Hand1.Add(card1);
        }
        public void DealerDeal(Dealer dealer)
        {
            Card card = cards[0];
            Card card1 = cards[1];
            card.ShowFace = true;
            card1.ShowFace = false;
            cards.RemoveAt(0);
            cards.RemoveAt(0);
            dealer.Hand.Add(card);
            dealer.Hand.Add(card1);
        }

        public void DealerHit(Dealer dealer)
        {
            Card card = cards[0];
            card.ShowFace = true;
            cards.RemoveAt(0);
            dealer.Hand.Add(card);
        }

        public void PlayerHit(Player player)
        {
            Card card = cards[0];
            card.ShowFace = true;
            cards.RemoveAt(0);
            player.Hand1.Add(card);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Card c in cards)
            {
                sb.Append(c.ToString());
            }
            return sb.ToString();
        }
    }
}
