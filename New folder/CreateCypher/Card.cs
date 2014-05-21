using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCypher
{
    public enum CardSuit
    {
        Clubs, 
        Diamonds, 
        Hearts, 
        Spades,
        JokerA,
        JokerB
    }

    [DebuggerDisplay("{Suit} {FaceValue}")]
    public class Card : IEquatable<Card>
    {
        const int MaxFaceValue = 13;

        public Card(CardSuit suit, int faceValue)
        {
            if (faceValue <= 0 && faceValue > MaxFaceValue)
                throw new ArgumentException("Card value out of range");

            this.Suit = suit;
            this.FaceValue = faceValue;
        }

        public CardSuit Suit { get; private set; }

        public int FaceValue { get; private set; }

        public int Value
        {
            get
            {
                int total = this.FaceValue;

                switch(this.Suit)
                {
                    case CardSuit.Diamonds:
                        total += MaxFaceValue;
                        break;

                    case CardSuit.Hearts:
                        total += 2 * MaxFaceValue;
                        break;
                    case CardSuit.Spades:
                        total += 3 * MaxFaceValue;
                        break;
                    case CardSuit.JokerA:
                    case CardSuit.JokerB:
                        total = 53;
                        break;
                }

                return total;
            }
        }

        public override string ToString()
        {
            if (this.Suit == CardSuit.JokerA)
                return "Joker A";

            if (this.Suit == CardSuit.JokerB)
                return "Joker B";

            return string.Format("{0} of {1}", this.FaceValue, this.Suit);
        }


        public bool Equals(Card other)
        {
            if (other.Suit == CardSuit.JokerA || other.Suit == CardSuit.JokerB)
                return this.Suit == other.Suit;
                    
            return this.Suit == other.Suit && this.FaceValue == other.FaceValue;
        }
    }
}
