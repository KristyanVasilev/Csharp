using System;
using System.Linq;

namespace _03.Cards
{
    class Card
    {
        private string face;

        private string suit;

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public string Face
        {
            get { return face; }
            set
            {
                string[] faces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

                if (!faces.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                face = value;
            }
        }

        public string Suit
        {
            get { return suit; }
            set
            {
                string[] suits = new string[] { "S", "H", "D", "C" };

                if (!suits.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }

                if (value == "S")
                {
                    suit = "\u2660";
                }
                else if (value == "H")
                {
                    suit = "\u2665";
                }
                else if (value == "D")
                {
                    suit = "\u2666";
                }
                else if (value == "C")
                {
                    suit = "\u2663";
                }
            }
        }

        public override string ToString()
            => $"[{face}{suit}]";
    }
}
