using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            for (int suit = 0; suit <= 3; suit++)     // Suit type
            {
                for (int value = 0; value <= 12; value++)    // Card Value
                {
                    Card c = new Card((Values)value, (SuitType)suit);
                    cards.Add(c);
                    // Console.WriteLine(c.Value + " " + c.Suit); - To test if list is working
                }
            }
        }

        public void Shuffle()
        {
            List<Card> randomizedList = new List<Card>();
            Random rnd = new Random();
            while (cards.Count > 0)
            {
                int CardToMove = rnd.Next(0, cards.Count); //pick a random item deck list
                randomizedList.Add(cards[CardToMove]); //place it at the end of the randomized list
                cards.RemoveAt(CardToMove);
            }
            cards = randomizedList;
            //Console.WriteLine(cards);       //To test if list is working
            //Console.ReadLine();            //To test if list is working
        }

        public Card Deal()        // Return 1 card at a time
        {
            if (cards.Count <= 0)
            {
                Shuffle();
            }

            Card cardsToReturn = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);     // Remove card from deck once shuffles

            return cardsToReturn;     // Returns card
        }

        public int CheckRemainingCard()
        {
            return cards.Count;
        }

        public void PrintDeck()
        {
            int i = 1;
            foreach (Card card in cards)
            {
                Console.WriteLine("Card {0}, {1} of {2}. Value: {3}", i, card.Suit, card.Value);
            }
        }
    }
}
