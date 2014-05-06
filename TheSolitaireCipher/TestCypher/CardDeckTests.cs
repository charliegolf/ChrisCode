using CreateCypher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCypher
{

    [TestClass]
    public class CardDeckTests
    {
        [TestMethod]
        public void New_Card_Deck_Should_Be_In_Ascending_Order()
        {
            CardDeck newDeck = new CardDeck();

            const string CardsInOrder = "1 2 3 4 5 6 7 8 9 10 11 12 13 1 2 3 4 5 6 7 8 9 10 11 12 13 1 2 3 4 5 6 7 8 9 10 11 12 13 1 2 3 4 5 6 7 8 9 10 11 12 13 53 54";

            Assert.AreEqual(CardsInOrder, newDeck.ToString());
        }

        [TestMethod]
        public void Moving_JokerA_Down_One_Card_Puts_Joker_At_End()
        {
            CardDeck newDeck = new CardDeck();

            newDeck.MoveCard(CardDeck.JokerA, 1);

            const string NewOrder = "1 2 3 4 5 6 7 8 9 10 11 12 13 1 2 3 4 5 6 7 8 9 10 11 12 13 1 2 3 4 5 6 7 8 9 10 11 12 13 1 2 3 4 5 6 7 8 9 10 11 12 13 54 53";

            Assert.AreEqual(NewOrder, newDeck.ToString());
        }

        [TestMethod]
        public void Moving_JokerB_Down_Two_Cards_Puts_Joker_Near_Top()
        {
            CardDeck newDeck = new CardDeck();

            //newDeck.MoveCard(CardDeck.JokerA, 1);
            newDeck.MoveCard(CardDeck.JokerB, 2);

            const string NewOrder = "1 54 2 3 4 5 6 7 8 9 10 11 12 13 1 2 3 4 5 6 7 8 9 10 11 12 13 1 2 3 4 5 6 7 8 9 10 11 12 13 1 2 3 4 5 6 7 8 9 10 11 12 13 53";

            Assert.AreEqual(NewOrder, newDeck.ToString());
        }

    }
}
