using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        public List<Card> Hand { get; set; }

        public Dealer()
        {
            Hand = new List<Card>();
        }
        public string ShowHand()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Card c in Hand)
            {
                sb.Append(c.ToString());
            }
            return sb.ToString();
        }

        public int HandValue()
        {
            int res = 0;
            foreach (Card c in Hand)
            {
                if (c.ShowFace)
                {
                    if (c.Value == "A")
                        res += 11;
                    else if (c.Value == "J")
                        res += 12;
                    else if (c.Value == "Q")
                        res += 13;
                    else if (c.Value == "K")
                        res += 14;
                    else
                        res += int.Parse(c.Value);
                }
            }
            return res;
        }
    }
}
