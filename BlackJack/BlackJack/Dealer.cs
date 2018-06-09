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
                if (c.ShowFace)
                    sb.Append(c.ToString());
                else
                    sb.Append("FaceDown ");
            }
            return sb.ToString();
        }

        public int HandValue()
        {
            int numberOfNotSoftValuedAces = 0;
            int res = 0;
            foreach (Card c in Hand)
            {
                if (c.ShowFace)
                {
                    if (c.Value == "A" && c.SoftValue == false)
                    {
                        res += 11;
                        numberOfNotSoftValuedAces++;
                    }
                    else if (c.Value == "A" && c.SoftValue == true)
                    {
                        res += 1;
                    }
                    else if (c.Value == "J")
                        res += 10;
                    else if (c.Value == "Q")
                        res += 10;
                    else if (c.Value == "K")
                        res += 10;
                    else
                        res += int.Parse(c.Value);
                }
            }
            while(res > 21 && numberOfNotSoftValuedAces > 0)
            {
                foreach(Card c in Hand)
                {
                    if (c.Value == "A" && c.SoftValue == false)
                    {
                        res -= 10;
                        c.SoftValue = true;
                        numberOfNotSoftValuedAces--;
                        break;
                    }
                }
            }
            return res;
        }

        public bool isBlackJack()
        {
            if (Hand.Count == 2 && HandValue() == 21)
                return true;
            return false;
        }
    }
}
