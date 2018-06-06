using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckUnitTest
{
    [TestClass]
    public class DeckTest
    {
        [TestMethod]
        public void ReturnsProperDeckInfo()
        {
            RandomNumsFromCards.Deck deck = new RandomNumsFromCards.Deck(2);
            int testLength = deck.GetLength();
            Assert.AreEqual(104, testLength);
    }
}
