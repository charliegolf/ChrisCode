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
        private List<string> deck;

        public const string JokerA = "53";
        public const string JokerB = "54";
        
        public List<string> CardDeck()
        {
            this.deck = new List<string>();

            for (int cardSuites = 0; cardSuites < 4; cardSuites++)
            {
                
                for (int cardValues = 1; cardValues <= 13; cardValues++)
                {
                    this.deck.Add(cardValues + " " + cardSuites);
                }
            }

            this.deck.Add(JokerA);
            this.deck.Add(JokerB);

            return deck;
        }

        public void MoveCard(string cardValue, int steps)
        {
            Debug.Assert(steps > 0, "step value has to be positive");

            if (deck.Contains(cardValue))
            {
                int originalPosition = FindCardIndex(cardValue);

                int newPosition = originalPosition + steps;

                if ((newPosition + 1) > deck.Count)
                {
                    newPosition -= deck.Count+1;
                }

                if ((newPosition + 1) == deck.Count)
                {
                    newPosition = steps+1;
                }

                deck.RemoveAt(originalPosition);
                deck.Insert(newPosition, cardValue);
            }
        }

        public int FindCardIndex(string cardValue)
        {
            return deck.IndexOf(cardValue);
        }

        public override string ToString()
        {
            return string.Join(" ", this.deck);
        }
    }
}
