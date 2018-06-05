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

        public Card(string val, string type)
        {
            Value = val;
            Type = type;
        }

        public string ToString()
        {
            return Value + Type + " ";
        }
    }
}
