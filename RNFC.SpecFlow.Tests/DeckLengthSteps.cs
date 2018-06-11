using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumsFromCards;
using System;
using TechTalk.SpecFlow;

namespace RNFC.SpecFlow.Tests
{
    [Binding]
    public class DeckLengthSteps
    {
        Deck testDeck;
        int result;

        [Given(@"I have two decks")]
        public void GivenIHaveTwoDecks()
        {
            testDeck = new Deck(2);
        }
        
        [When(@"I see how many cards I have")]
        public void WhenISeeHowManyCardsIHave()
        {
            result = testDeck.GetLength();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int amount)
        {
            Assert.AreEqual(amount, result);
        }
    }
}
