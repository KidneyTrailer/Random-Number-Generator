using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumsFromCards
{
    class Program
    {
        Deck myDeck;
        Random rand;

        public Program()
        {
            myDeck = new Deck(2);
            rand = new Random();
        }

        int GetDigits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }
            return count;
        }

        int GetNumFromCards(Deck deck, int numDigits = 3, int shuffles = 1)
        {
            if (numDigits >= deck.GetLength() || numDigits > GetDigits(int.MaxValue))
                throw new ArgumentOutOfRangeException("numDigits");

            int result = 0;
            ShuffleDeck(deck, shuffles);
            int startIndex = rand.Next(deck.GetLength() - numDigits - 1);
            int index = 0;
            int digits = 0;
            while (digits < numDigits)
            {
                result *= 10;
                if (startIndex + index > deck.GetLength() - 1) index = 0;
                result += deck.GetCardValue(index + startIndex) % 10;
                index++;
                digits = GetDigits(result);
            }
            return result;
        }

        void ShuffleDeck(Deck deck, int shuffles = 1)
        {
            for (int x = 0; x < shuffles; x++)
            {
                for (int i = 0; i < deck.GetLength(); ++i)
                {
                    int j = rand.Next(i, deck.GetLength());
                    deck.Swap(i, j);
                }
            }
            //Console.WriteLine("Deck shuffled {0} times.", shuffles);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.GetNumFromCards(p.myDeck));
            
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey(true);
        }
    }
}
