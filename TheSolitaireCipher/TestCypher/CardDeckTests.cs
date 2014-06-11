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

            Assert.AreEqual(53, newDeck.FindCardIndex(CardSuit.JokerB));
        }

        [TestMethod]
        public void Moving_JokerA_Down_One_Card_Puts_Joker_At_End()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA), 1);
            Assert.AreEqual(53, newDeck.FindCardIndex(CardSuit.JokerA));
        }

        [TestMethod]
        public void Moving_JokerA_Down_One_Card_From_Last_Position_Puts_Joker_At_1()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA), 1);
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA), 1);
            Assert.AreEqual(0, newDeck.FindCardIndex(CardSuit.JokerA));
        }

        [TestMethod]
        public void Moving_JokerB_Down_Two_Cards_Puts_Joker_Near_Top()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerB), 2);
            Assert.AreEqual(1, newDeck.FindCardIndex(CardSuit.JokerB));
        }

        [TestMethod]
        public void Moving_JokerB_Down_One_Cards_Puts_Joker_At_Top()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerB), 1);
            Assert.AreEqual(0, newDeck.FindCardIndex(CardSuit.JokerB));
            Assert.AreEqual(53, newDeck.FindCardIndex(CardSuit.Clubs, 1));
        }

        [TestMethod]
        public void Moving_A_Joker_Down_The_Pack_Without_Crossing_Boundaries()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerB), 53);
            Assert.AreEqual(52, newDeck.FindCardIndex(CardSuit.JokerB));

        }

        [TestMethod]
        public void Shuffle_Swaps_Cards_Above_Top_Joker_Position_1()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA), 3);
            Assert.AreEqual(1, newDeck.FindCardIndex(CardSuit.JokerA));
            newDeck.Shuffle();
            Assert.AreEqual(53, newDeck.FindCardIndex(CardSuit.Clubs, 1));
        }


        [TestMethod]
        public void Shuffle_Swaps_Cards_Above_Top_Joker_Position_4()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA), 5);
            Assert.AreEqual(3, newDeck.FindCardIndex(CardSuit.JokerA));
            newDeck.Shuffle();
            Assert.AreEqual(51, newDeck.FindCardIndex(CardSuit.Clubs, 1));
        }

        [TestMethod]
        public void Shuffle_Swaps_Cards_Below_Bottom_Joker_Position_1()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA), 5);
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerB), 51);
            Assert.AreEqual(50, newDeck.FindCardIndex(CardSuit.JokerB));
            newDeck.Shuffle();
            Assert.AreEqual(0, newDeck.FindCardIndex(CardSuit.Spades, 13));
        }

        [TestMethod]
        public void Shuffle_Swaps_Cards_Below_Bottom_Joker_Position_2()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA), 12);
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerB), 35);
            newDeck.Shuffle();
            Assert.AreEqual(0, newDeck.FindCardIndex(CardSuit.Spades, 13));
            Assert.AreEqual(53, newDeck.FindCardIndex(CardSuit.Clubs, 10));
        }

        [TestMethod]
        public void Cut_Moves_Cards_to_Above_Bottom_Joker_Position()
        {
            CardDeck newDeck = new CardDeck();
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerA), 5);
            newDeck.MoveCard(newDeck.FindCardIndex(CardSuit.JokerB), 48);
            newDeck.Shuffle();
            newDeck.Cut();
            Assert.AreEqual(46, newDeck.FindCardIndex(CardSuit.Clubs, 12));
        }
    }
}
