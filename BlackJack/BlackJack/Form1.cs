using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private Deck deck;
        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deck.ShuffleDeck();
            MessageBox.Show(deck.ToString());
        }
    }
}
