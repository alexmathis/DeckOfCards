using DeckOfCardsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeckOfCardsApp
{
    public class Utilities
    {
        /// <summary>
        /// Print a list of cards to the console
        /// </summary>
        /// <param name="cards"></param>
        public void Print(List<Card> cards, string action = "Dealt")
        {
            foreach(var card in cards)
            {
                Console.WriteLine($"{action} a {card.Number} {card.Suit}.");
            }

        }

        /// <summary>
        /// Can print a list of return results cards. 
        /// </summary>
        /// <param name="cardResults"></param>
        /// <param name="action"></param>
        public void Print(ReturnResults<List<Card>> cardResults, string action = "Dealt")
        {
            if (!cardResults.Success)
            {
                Console.WriteLine(cardResults.ErrorMessage ?? "Something went wrong.");
            }
            else if(cardResults.Data != null && cardResults.Data.Count > 0)
            {
                Print(cardResults.Data, action);
            }
        }
    }
}
