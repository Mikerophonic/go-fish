using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GoFish.Models;
using System;

namespace GoFish.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void DeckConstructor_CreatesInstanceOfDeck_Deck()
        {
            Deck newDeck = new Deck();
            Assert.AreEqual(typeof(Deck), newDeck.GetType());
        }

        [TestMethod]
        public void GetList_ReturnsAList_List()
        {
            Deck newDeck2 = new Deck();
            
            int expectedCardCount = 52;
            int actualCardCount = newDeck2.CardsCount;

            Assert.AreEqual(expectedCardCount, actualCardCount);
        }

        [TestMethod]
        public void ShuffleDeck_ReturnsShuffledDeck_Deck()
        {
            // Deck newDeck3 = new Deck();
            // Card aCard = Card("hearts", "5");
            // Card randomCard = newDeck3.ShuffleDeck;
            // Assert.AreEqual

            Deck deck = new Deck();
            List<Card> originalOrder = new List<Card>(deck.cards);

            // Act
            deck.ShuffleDeck();
            List<Card> shuffledOrder = deck.cards;

            // Assert
            CollectionAssert.AreNotEqual(originalOrder, shuffledOrder);
        }
    }
}