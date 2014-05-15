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
               if (newPosition <= deck.Count)
               {
                   deck.Insert(indexPosition + steps + 1, card);
                   deck.RemoveAt(indexPosition);
               }
               else if (newPosition > deck.Count)
               {
                   deck.Insert(newPosition - deck.Count, card);
                   deck.RemoveAt(indexPosition);
               }
        }


        public CardDeck Shuffle()
        {


            if (this.deck. < CardDeck.deck.FindCardIndex(JokerA, 1) && CardDeck.deck.FindCardIndex(JokerA,1) != 53)
                {
                    for (int count = deck.IndexOf(53) + 1; count <= deck.Count; count++)
                    {
                        tripleCutList.Add(deck.ElementAt(count));
                        tripleCutList.Add(54);
                    }

                    for (int count = deck.IndexOf(54) + 1; count < deck.IndexOf(53); count++)
                    {
                        tripleCutList.Add(deck.ElementAt(count));
                        tripleCutList.Add(53);
                    }

                    for (int count = 0; count < deck.IndexOf(54); count++)
                    {
                        tripleCutList.Add(deck.ElementAt(count));

                    }
                 }

               return tripleCutList;
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
