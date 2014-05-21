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

            Assert.IsTrue(newDeck.ToString().StartsWith("1 of Clubs 2 of Clubs"));
            Assert.IsTrue(newDeck.ToString().EndsWith("Joker A Joker B"));
        }

        [TestMethod]
        public void FindingIndexOf_Card_Deck()
        {
            CardDeck newDeck = new CardDeck();

            Assert.AreEqual(53, newDeck.FindCardIndex(CardSuit.JokerB, 1));
        }

        [TestMethod]
        public void Moving_JokerA_Down_One_Card_Puts_Joker_At_End()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA, 1), 1);
            Assert.AreEqual(53, newDeck.FindCardIndex(CardSuit.JokerA, 1));
        }

        [TestMethod]
        public void Moving_JokerA_Down_One_Card_From_Last_Position_Puts_Joker_At_1()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA, 1), 1);
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA, 1), 1);
            Assert.AreEqual(1, newDeck.FindCardIndex(CardSuit.JokerA, 1));
        }

        [TestMethod]
        public void Moving_JokerB_Down_Two_Cards_Puts_Joker_Near_Top()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerB, 1), 2);
            Assert.AreEqual(2, newDeck.FindCardIndex(CardSuit.JokerB, 1));
        }

        [TestMethod]
        public void Moving_A_Joker_Down_The_Pack_Without_Crossing_Boundaries()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerB, 1), 53);
            Assert.AreEqual(53, newDeck.FindCardIndex(CardSuit.JokerB, 1));

        }

        [TestMethod]
        public void Shuffle_Swaps_Cards_Above_Top_Joker_Position_1()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA, 1), 2);
            Assert.AreEqual(1, newDeck.FindCardIndex(CardSuit.JokerA, 1));
            newDeck.Shuffle();
            Assert.AreEqual(53, newDeck.FindCardIndex(CardSuit.Clubs, 1));
        }


        [TestMethod]
        public void Shuffle_Swaps_Cards_Above_Top_Joker_Position_4()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA, 1), 5);
            Assert.AreEqual(4, newDeck.FindCardIndex(CardSuit.JokerA, 1));
            newDeck.Shuffle();
            Assert.AreEqual(50, newDeck.FindCardIndex(CardSuit.Clubs, 1));
        }
    }
}
