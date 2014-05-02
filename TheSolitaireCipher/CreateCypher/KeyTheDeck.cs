using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCipher
{
    public class CreateTheDeck
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
    }

    public class MoveTheJokers
    {
        public static List<int> MoveJokers(List<int> deck)
        {

                if (deck.Contains(53))
                {
                    int positionJokerA = deck.IndexOf(53);
                    if (positionJokerA == 52)
                    {
                        deck.Insert(positionJokerA + 2, 53);
                        deck.RemoveAt(positionJokerA);
                    }
                    else
                    {
                    if (positionJokerA == 53)
                    {
                        deck.Insert(1, 53);
                        deck.RemoveAt(positionJokerA); 
                    }
                    else
                    {
                        deck.Insert(positionJokerA + 2, 53);
                        deck.RemoveAt(positionJokerA);
                    }

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
            return deck;
        }


        public class CutTheCards
        {
            public static List<int> TripleCut(List<int> deck)
            {
                List<int> tripleCutList = new List<int>();

                if (deck.IndexOf(54) < deck.IndexOf(53))
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

                // else

                // if (deck.IndexOf(53) < deck.IndexOf(54))
                // {

                // }
                return tripleCutList;

            }
        }
  }

}

