using DeckOfCardsApp.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsApp.Models
{
    public class Deck
    {
        /// <summary>
        /// List of cards in the deck.
        /// </summary>
        public List<Card> Cards { get; set; }

        /// <summary>
        /// Shuffle a list of cards.
        /// </summary>
        /// <returns>List<Cards></returns>
        public List<Card> Shuffle()
        {
            var randomGenerator = new Random();

            for (var i = Cards.Count - 1; i > 0; i--)
            {
                var n = randomGenerator.Next(i + 1);
                var temp = Cards[i];
                Cards[i] = Cards[n];
                Cards[n] = temp;
            }

            return Cards;
        }


        /// <summary>
        /// Deal the number of cards requested by the user. 
        /// </summary>
        /// <param name="numberOfCardsToDeal"></param>
        /// <returns>ReturnResults<List<Card>> This object contains an error message if there were any errors, a success boool, and the results.</returns>
        public ReturnResults<List<Card>> Deal(int numberOfCardsToDeal)
        {
            var results = new ReturnResults<List<Card>>();

            if (numberOfCardsToDeal > Cards.Count)
            {
                results.ErrorMessage = $"There are not enough cards in the deck to deal that many. There are currently {Cards.Count} cards left.";
            }
            else
            {
                for (var i = 0; i < numberOfCardsToDeal; i++)
                {
                    results.Data.Add(Cards[i]);
                }

                Cards.RemoveRange(0, numberOfCardsToDeal);
                results.Success = true;
            }
             
            return results;
        }

        public Deck()
        {
            Cards = new List<Card>();
            var numbers = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (string number in numbers)
            {
                Cards.AddRange(new List<Card>()
                {
                    new Card(Suit.Diamonds, number),
                    new Card(Suit.Hearts, number),
                    new Card(Suit.Spades, number),
                    new Card(Suit.Clubs, number)
                });
            }
        }
    }
}
