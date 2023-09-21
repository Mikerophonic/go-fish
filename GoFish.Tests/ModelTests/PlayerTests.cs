using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GoFish.Models;
using System;

namespace GoFish.Tests
{
    [TestClass]
    public class PlayerTests
    {

        [TestMethod]
        public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
        {
            Player player1 = new Player("bug");
            Assert.AreEqual(typeof(Player), player1.GetType());
        }

        [TestMethod]
        public void NewHand_DealsPlayersFirstHand_Thing()
        {
          Deck newDeck = new Deck();
          newDeck.ShuffleDeck();
          Player player1 = new Player("bug");
          player1.NewHand(newDeck);
          Assert.AreEqual(5, player1.Hand.Count);
        }
    }
}