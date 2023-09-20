using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GoFish.Models;
using System;

namespace GoFish.Tests
{
    [TestClass]
    public class CardTests
    {

        [TestMethod]
        public void CardConstructor_CreatesInstanceOfCard_Card()
        {
            Card newCard = new Card("hearts", "5");
            Assert.AreEqual(typeof(Card), newCard.GetType());
        }

        [TestMethod]
        public void GetSuit_ReturnsSuit_String()
        {
            string suit1 = "hearts";
            Card newCard = new Card(suit1, "5");
            string result = newCard.Suit;
            Assert.AreEqual(suit1, result);
        }

        [TestMethod]
        public void GetRank_ReturnsRank_String()
        {
            string rank1 = "5";
            Card newCard = new Card("hearts", "5");
            string result = newCard.Rank;
            Assert.AreEqual(rank1, result);

        }

}
}