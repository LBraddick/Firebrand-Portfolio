using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public SuitType Suit { get; set; }
        public Values Value { get; set; }

        public Card(Values value, SuitType suit)
        {
            Value = value;
            Suit = suit;
        }
    }

    public enum SuitType
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades,
    }

    public enum Values
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }
}
