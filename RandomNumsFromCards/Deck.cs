using System;
namespace RandomNumsFromCards
{
    public class Deck
    {

        private readonly Card[] _cards;
        private readonly int _deckLength;
        private readonly int _numDecks;

        public Deck(int numDecks = 2)
        {
            _numDecks = numDecks;
            _deckLength = 52 * numDecks;
            _cards = new Card[_deckLength];

            var index = 0;

            for (int i = 0; i < numDecks; i++) {
                foreach (var cardValue in Enum.GetValues(typeof(CardValue)))
                {
                    foreach (var suit in Enum.GetValues(typeof(Suit)))
                    {
                        _cards[index++] = new Card((CardValue)cardValue, (Suit)suit);
                    }
                }
            }
        }

        public int GetCardValue(int i)
        {
            return (int)_cards[i].Value;
        }

        public int GetLength()
        {
            return _deckLength;
        }

        public int GetNumDecks()
        {
            return _numDecks;
        }

        public void Print()
        {
            Console.WriteLine("{0} {1} card deck[s].", _numDecks, _deckLength / _numDecks);
        }

        public void Show()
        {
            foreach (Card c in _cards)
            {
                c.Print();
            }
        }

        public void Swap(int a, int b)
        {
            Card temp = _cards[a];
            _cards[a] = _cards[b];
            _cards[b] = temp;
        }
    }
}
