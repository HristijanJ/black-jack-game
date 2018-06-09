using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public string Value { get; set; }
        public string Type { get; set; }
        public bool ShowFace { get; set; }
        public bool SoftValue { get; set; } // Za kecot bidejki moze da bide 1 ili 11

        public Card(string val, string type)
        {
            Value = val;
            Type = type;
            ShowFace = false;
            SoftValue = false;
        }

        public override string ToString()
        {
            return Value + Type + " ";
        }
    }
}
