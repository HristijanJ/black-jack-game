using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Properties;

namespace BlackJack
{
    [Serializable]
    public class Card
    {
        public Image frontOfTheCard;
        public Image backOfTheCard;

        public string Value { get; set; }
        public string Type { get; set; }
        public bool ShowFace { get; set; }
        public bool SoftValue { get; set; } // Za kecot bidejki moze da bide 1 ili 11

        public Card(string val, string type,Image frontOfTheCard)
        {
            Value = val;
            Type = type;
            ShowFace = false;
            SoftValue = false;
            this.frontOfTheCard = frontOfTheCard;
            backOfTheCard = Resources.purple_back;
        }

        public override string ToString()
        {
            return Value + Type + " ";
        }
        public void Draw(Graphics g,Point point)
        {
            if (ShowFace)
                g.DrawImage(frontOfTheCard, point);
            else
                g.DrawImage(backOfTheCard, point);
        }
    }
}
