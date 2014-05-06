using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCypher
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
}
