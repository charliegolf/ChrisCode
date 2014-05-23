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
            Card card = this.deck[indexPosition];
            int newPosition = indexPosition + steps;
               if (newPosition < deck.Count)
               {
                   deck.RemoveAt(indexPosition);
                   deck.Insert(indexPosition + steps, card);
                   
               }
               else if (newPosition >= deck.Count)
               {
                   deck.RemoveAt(indexPosition);
                   deck.Insert(newPosition - deck.Count, card);
                   
               }
        }


        public void Shuffle()
        {

            var firstJoker = deck.FirstOrDefault(Joker => Joker.Suit==CardSuit.JokerA );
            var secondJoker = deck.FirstOrDefault(Joker => Joker.Suit==CardSuit.JokerB );
            int bottomNumbersTotal = (deck.Count() - deck.IndexOf(secondJoker)) + 1;
                for (int aboveFirstJoker = deck.IndexOf(firstJoker)-1; aboveFirstJoker >= 0;  aboveFirstJoker--)
                {
                    deck.Add(deck.ElementAt(0));
                    deck.Remove(deck.ElementAt(0));
                }
                for (int belowSecondJoker = deck.IndexOf(secondJoker) + 1; belowSecondJoker < deck.IndexOf(secondJoker)+bottomNumbersTotal; belowSecondJoker++)
                {
                    for (int bottom = 0; bottom < bottomNumbersTotal; bottom++ )
                    {
                        deck.Insert(bottom, deck.ElementAt(belowSecondJoker));
                        deck.Remove(deck.ElementAt(belowSecondJoker+1));
                    }

                }
        }            
          


        public int FindCardIndex(CardSuit suit, int faceValue = 1)
        {
            return deck.IndexOf(new Card(suit, faceValue));
        }

        public override string ToString()
        {
            return string.Join(" ", this.deck);
        }

     }
}
