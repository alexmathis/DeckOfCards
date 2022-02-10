using DeckOfCardsApp.Models;
using NUnit.Framework;
using System.Linq;

namespace DeckOfCards.Test
{
    public class DeckOfCardsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShuffle()
        {
            var deck = new Deck();
            var currentSortString = deck.Cards.Select(o => $"{o.Number}{o.Suit}");
            var concatinatedInitialOrder = string.Join(',', currentSortString);

            var currentSortDuplicateString = deck.Cards.Select(o => $"{o.Number}{o.Suit}");
            var concatinatedInitialOrderDuplicate = string.Join(',', currentSortString);

            deck.Shuffle();
            var newSortString = deck.Cards.Select(o => $"{o.Number}{o.Suit}");
            var concatinatedFinalOrder = string.Join(',', currentSortString);

            //updatedDec
            Assert.IsTrue(concatinatedInitialOrder == concatinatedInitialOrderDuplicate);
            Assert.IsFalse( concatinatedInitialOrder == concatinatedFinalOrder);
        }


        [Test]
        public void DealOneTest()
        {
            var deck = new Deck();
            var dealtCards = deck.Deal(1);
            Assert.IsTrue(dealtCards.Data.Count == 1);
            Assert.IsTrue(deck.Cards.Count == 51);
    
        }

        [Test]
        public void DealTwoTest()
        {
            var deck = new Deck();
            var dealtCards = deck.Deal(2);
            Assert.IsTrue(dealtCards.Data.Count == 2);
            Assert.IsTrue(deck.Cards.Count == 50);
        }

        [Test]
        public void DealAllTest()
        {
            var deck = new Deck();
            var dealtCards = deck.Deal(52);
            Assert.IsTrue(dealtCards.Data.Count == 52);
            Assert.IsTrue(deck.Cards.Count == 0);
        }
    }
}
