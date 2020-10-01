using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningProyect
{
    class Baraja
    {
        private String[] deck = { "2C", "2D", "2H", "2S",
                                  "3C", "3D", "3H", "3S",
                                  "4C", "4D", "4H", "4S",
                                  "5C", "5D", "5H", "5S",
                                  "6C", "6D", "6H", "6S",
                                  "7C", "7D", "7H", "7S",
                                  "8C", "8D", "8H", "8S",
                                  "9C", "9D", "9H", "9S",
                                  "10C", "10D", "10H", "10S",
                                  "AC", "AD", "AH", "AS",
                                  "JC", "JD", "JH", "JS",
                                  "3C", "3D", "3H", "3S",
                                  "KC", "KD", "KH", "KS",
        };
        private List<String> mixedDeck;

        public Carta askCard()
        {
            if(this.mixedDeck.Count == 0)
            {
                MessageBox.Show("La baraja no tiene cartas");
            }

            String card = this.mixedDeck[this.mixedDeck.Count - 1];
            Carta newCard = new Carta(card);
            this.mixedDeck.RemoveAt(this.mixedDeck.Count - 1);
            return newCard;
        }

        public void mixDeck()
        {
            Random rnd = new Random();
            this.mixedDeck = this.deck.OrderBy(x => rnd.Next()).ToList();
        }

        public void emptyMixedDeck()
        {
            this.mixedDeck.Clear();
        }
    }
}
