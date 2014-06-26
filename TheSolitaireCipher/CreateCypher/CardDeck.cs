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

               else if (newPosition == deck.Count)
               {
                   deck.RemoveAt(indexPosition);
                   deck.Insert(newPosition - deck.Count - 1, card);
                   deck.Add(deck.ElementAt(1));
                   deck.RemoveAt(1);    
               }

               else if (newPosition > deck.Count)
               {
                   deck.RemoveAt(indexPosition);
                   deck.Insert(newPosition - deck.Count-1, card);
               }
        }


        public void Shuffle()
        {
           
            var firstJoker = deck.FirstOrDefault(Joker => Joker.Suit == CardSuit.JokerA);
            var secondJoker = deck.FirstOrDefault(Joker => Joker.Suit == CardSuit.JokerB);

            if (deck.IndexOf(firstJoker) < deck.IndexOf(secondJoker))
            {
                for (int aboveFirstJoker = deck.IndexOf(firstJoker) - 1; aboveFirstJoker >= 0; aboveFirstJoker--)
                {
                    deck.Add(deck.ElementAt(0));
                    deck.Remove(deck.ElementAt(0));
                }
                int bottomNumbersTotal = (deck.Count() - deck.IndexOf(secondJoker)) - 1;
                int belowSecondJoker = deck.IndexOf(secondJoker) + 1;
                for (int bottom = 0; bottom < bottomNumbersTotal; bottom++)
                {
                    deck.Insert(0, deck.ElementAt(belowSecondJoker));
                    Card test = deck.ElementAt(belowSecondJoker + 1);
                    deck.RemoveAt(belowSecondJoker + 1);
                    belowSecondJoker++;
                }
            }
            else
            {
                for (int aboveFirstJoker = deck.IndexOf(secondJoker)-1; aboveFirstJoker >= 0; aboveFirstJoker--)
                {
                    if (aboveFirstJoker > 0)
                    { 
                    deck.Add(deck.ElementAt(aboveFirstJoker));
                    deck.Remove(deck.ElementAt(aboveFirstJoker));
                }
                int belowSecondJoker = deck.IndexOf(firstJoker) + 1;
                int bottomNumbersTotal = (deck.Count() - deck.IndexOf(firstJoker)) - 1;
                for (int bottom = 0; bottom < bottomNumbersTotal; bottom++)
                {
                    deck.Insert(0, deck.ElementAt(belowSecondJoker));

                    Card test = deck.ElementAt(belowSecondJoker + 1);
                    deck.RemoveAt(belowSecondJoker + 1);
                    belowSecondJoker++;
                    }
                }
            }
        }            
          
        public void Cut()
        {
            Card bottomValue = deck.ElementAt(53);
            int faceValue = bottomValue.FaceValue;

            for (int cardCount = 0; cardCount < faceValue; cardCount++)
            {
                deck.Insert(52, deck.ElementAt(0));
                deck.Remove(deck.ElementAt(0));
            }
        }



      //  public string ModulusTwentySix()
      //  {

     //   }



        public char FindOutputLetter()
        {


            if (deck.ElementAt(0).ToString() == JokerA || deck.ElementAt(0).ToString() == JokerB)
            {
                

                {
                    Card topValue = deck.ElementAt(1);
                    int faceValue = topValue.FaceValue;
                    Card cardToConvert = deck.ElementAt(faceValue - 1);
                    int valueToconvert = cardToConvert.FaceValue;
                    char cardAsLetter;
                    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    cardAsLetter = alphabet[valueToconvert - 1];
                    return cardAsLetter;
                }
                
            }
            else
            {
                              
                    Card topValue = deck.ElementAt(0);
                    int faceValue = topValue.FaceValue;
                    Card cardToConvert = deck.ElementAt(faceValue - 1);
                    int valueToconvert = cardToConvert.FaceValue;
                    char cardAsLetter;
                    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    cardAsLetter = alphabet[valueToconvert - 1];
                    return cardAsLetter;  
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
