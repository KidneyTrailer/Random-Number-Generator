using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumsFromCards;

namespace RNFC.Test
{
    [TestClass]
    public class DeckTest
    {
        [TestMethod]
        public void DeckLengthTest()
        {
            Deck deck = new Deck(2);
            int deckLength = deck.GetLength();
            Assert.AreEqual(104, deckLength);
        }
    }
}
