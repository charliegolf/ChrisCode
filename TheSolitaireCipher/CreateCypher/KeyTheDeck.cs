using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCipher
{
    public class KeyTheDeck
    {
        public static List<int> CreateDeck()
        {
            List<int> deck = new List<int>();
            for (int cardSuites = 0; cardSuites < 4; cardSuites++)
            {
                for (int cardValues = 1; cardValues <= 13; cardValues++)
                {
                    deck.Add(cardValues);
                }
            }
            deck.Add(53);
            deck.Add(54);

            return deck;
        }
        
        public static List<int> MoveJokers(List<int> deck)
        {
            foreach (int element in deck)
            {
                if (deck.Contains(53))
                {
                    int positionJokerA =deck.IndexOf(53);

                    if (positionJokerA == 54)
                    {
                        deck.Insert(2, 53);
                        deck.RemoveAt(positionJokerA);   
                    }
                    else
                    {
                        deck.Insert(positionJokerA + 1, 53);
                        deck.RemoveAt(positionJokerA); 
                    }
                }

                if (deck.Contains(54))
                {
                    int positionJokerB = deck.IndexOf(54);
                    if (positionJokerB == 53)
                    {
                        deck.Insert(1, 53);
                        deck.RemoveAt(positionJokerB);
                    }
                    else
                        if (positionJokerB == 54)
                        {
                            deck.Insert(2, 53);
                            deck.RemoveAt(positionJokerB);
                        }
                        else
                        {
                            deck.Insert(positionJokerB + 2, 53);
                            deck.RemoveAt(positionJokerB);
                        }
                   }
            }
            return deck;
        }
   }
}
