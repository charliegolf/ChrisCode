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
            Card card = this.deck.ElementAt(indexPosition);
            int newPosition = indexPosition + steps + 1;
            int topBottomSwapPosition = indexPosition + steps - deck.Count;
               if (newPosition < deck.Count-1)
               {
                   deck.Insert(indexPosition + steps + 1, card);
                   deck.RemoveAt(indexPosition);
               }
               if (indexPosition == deck.Count-1)
               {
                   deck.Insert(indexPosition + steps - deck.Count +1, card);
                   deck.RemoveAt(indexPosition);
                   deck.Add(this.deck.ElementAt(0));
                   deck.RemoveAt(0);
               }

               else if (newPosition > deck.Count-1)
               {
                   deck.Insert(newPosition - deck.Count, card);
                   deck.RemoveAt(indexPosition+1);
                   deck.Add(this.deck.ElementAt(0));
                   deck.RemoveAt(0);
               }
        }


        public void Shuffle()
        {

            var firstJoker = deck.FirstOrDefault(Joker => Joker.Suit==CardSuit.JokerA );
            var secondJoker = deck.FirstOrDefault(Joker => Joker.Suit==CardSuit.JokerB );
            int bottonNumbersTotal = (deck.Count() - deck.IndexOf(secondJoker)) + 1;

            if (deck.IndexOf(firstJoker) < deck.IndexOf(secondJoker))
            {
                for (int belowFirstJoker = deck.IndexOf(firstJoker)-1; belowFirstJoker >= 0; belowFirstJoker--)
                {
                    deck.Add(deck.ElementAt(0));
                    deck.Remove(deck.ElementAt(0));
                }
            }
            else
            if (deck.IndexOf(secondJoker) < deck.IndexOf(firstJoker))
            {
                for (int belowSecondJoker = deck.IndexOf(firstJoker) - 1; belowSecondJoker >= 0; belowSecondJoker--)
                {
                    deck.Add(deck.ElementAt(0));
                    deck.Remove(deck.ElementAt(0));
                }
             }

            for (int belowFirstJoker = deck.IndexOf(firstJoker); belowFirstJoker >= 0;  belowFirstJoker--)
                {
                    deck.Add(deck.ElementAt(0));
                    deck.Remove(deck.ElementAt(0));
                }
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
