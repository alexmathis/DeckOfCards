using DeckOfCardsApp.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsApp.Models
{
    public class Card
    {
        public Suit Suit { get; set; }
        public string Number { get; set; }

        public Card(Suit suit, string Number)
        {
            this.Suit = suit;
            this.Number = Number;
        }
    }
}
