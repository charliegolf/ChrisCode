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
                    int positionJokerA = deck.IndexOf(53);

                    if (positionJokerA == 53)
                    {
                        deck.Insert(2, 53);
                        deck.RemoveAt(positionJokerA);   
                    }
                    else
                    {
                        deck.Insert(positionJokerA + 2, 53);
                        deck.RemoveAt(positionJokerA); 
                    }
                }

                if (deck.Contains(54))
                {
                    int positionJokerB = deck.IndexOf(54);
                    if (positionJokerB == 52)
                    {
                        deck.Insert(1, 54);
                        deck.RemoveAt(positionJokerB+1);
                    }
                    else
                        if (positionJokerB == 53)
                        {
                            deck.Insert(2, 54);
                            deck.RemoveAt(positionJokerB+1);
                        }
                        else
                        {
                            deck.Insert(positionJokerB + 3, 54);
                            deck.RemoveAt(positionJokerB+1);
                        }
                   }
            }
            return deck;
        }

        public static List<int> TripleCut(List<int> deck)
        {
            if (deck.IndexOf(54)<deck.IndexOf(54)
            {
                 List<int> topDeck = new List<int>();
                 for (int card = 0; card < deck.IndexOf(54); card++)
                 {
                   //how do i move items from one list to another.
                 }
            }
           
 

        }
   }
}
