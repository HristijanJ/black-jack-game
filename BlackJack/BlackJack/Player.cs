using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public List<Card> Hand1 { get; set; }
        public List<Card> Hand2 { get; set; }
        public List<Card> Hand3 { get; set; }
        public List<Card> Hand4 { get; set; }

        public Player()
        {
            Hand1 = new List<Card>();
        }

        public string ShowHand1()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Card c in Hand1)
            {
                sb.Append(c.ToString());
            }
            return sb.ToString();
        }

        public int Hand1Value()
        {
            int res = 0;
            foreach(Card c in Hand1)
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
