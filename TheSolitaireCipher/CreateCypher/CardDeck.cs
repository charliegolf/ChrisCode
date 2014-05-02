using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCypher
{
    public class CardDeck
    {
        private List<int> deck;

        public const int JokerA = 53;
        public const int JokerB = 54;

        public CardDeck()
        {
            this.deck = new List<int>();

            for (int cardSuites = 0; cardSuites < 4; cardSuites++)
            {
                for (int cardValues = 1; cardValues <= 13; cardValues++)
                {
                    this.deck.Add(cardValues);
                }
            }

            this.deck.Add(JokerA);
            this.deck.Add(JokerB);
        }

        public void MoveCard(int cardValue, int steps)
        {
            Debug.Assert(steps > 0, "step value has to be positive");

            if (deck.Contains(cardValue))
            {
                int originalPosition = FindCardIndex(cardValue);

                int newPosition = originalPosition + steps;

                if ((newPosition + 1) > deck.Count)
                {
                    newPosition -= deck.Count;
                }

                deck.RemoveAt(originalPosition);
                deck.Insert(newPosition, cardValue);
            }
        }

        public int FindCardIndex(int cardValue)
        {
            return deck.IndexOf(cardValue);
        }

        public override string ToString()
        {
            return string.Join(" ", this.deck);
        }
    }
}
