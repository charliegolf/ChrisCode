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
        private List<Card> deck;

        public const string JokerA = "53";
        public const string JokerB = "54";
        
        public CardDeck()
        {
            this.deck = new List<Card>();
            
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                if (suit == CardSuit.JokerA || suit == CardSuit.JokerB)
                {
                    this.deck.Add(new Card(suit, 1));
                }
                else
                {
                    for (int cardValues = 1; cardValues <= 13; cardValues++)
                    {
                        this.deck.Add(new Card(suit, cardValues));
                    }
                }
            }
        }

        public void MoveCard(int indexPosition, int steps)
        {
            Debug.Assert(steps > 0, "step value has to be positive");

            //if (deck.Contains(cardValue))
            //{
            //    int originalPosition = FindCardIndex(cardValue);

            //    int newPosition = originalPosition + steps;

            //    if ((newPosition + 1) > deck.Count)
            //    {
            //        newPosition -= deck.Count+1;
            //    }

            //    if ((newPosition + 1) == deck.Count)
            //    {
            //        newPosition = steps+1;
            //    }

            //    deck.RemoveAt(originalPosition);
            //    deck.Insert(newPosition, cardValue);
            //}
        }

        public int FindCardIndex(CardSuit suit, int faceValue)
        {
            return deck.IndexOf(new Card(suit, faceValue));
        }

        public override string ToString()
        {
            return string.Join(" ", this.deck);
        }
    }
}
