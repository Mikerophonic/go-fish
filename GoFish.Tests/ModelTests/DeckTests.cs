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

            Deck originaldeck = new Deck();
            List<Card> originalOrder = Deck.GetAll();

            Deck shuffledDeck = new Deck();
            List<Card> shuffledOrder;
            
            // Act
            shuffledDeck.ShuffleDeck();
            shuffledOrder = Deck.GetAll();

            // Assert
            CollectionAssert.AreNotEqual(originalOrder, shuffledOrder);
        }


        [TestMethod]
        public void DrawCard_ReturnsDrawnCard_Card()
        {
            Deck newDeck = new Deck();
            newDeck.ShuffleDeck();
            newDeck.DrawCard();
            List<Card> deckAfterDraw = Deck.GetAll();

            Assert.AreEqual(51, deckAfterDraw.Count);
        }
    }
}