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

    class Program
    {
        static BlackJack blackJack;

        static void Main(string[] args)
        {
            blackJack = new BlackJack();

            while (true)
            {
                string key = null;
                while (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key.ToString();
                }
                blackJack.Update(key);
            }
            //Console.ReadLine();
        }
    }

    public class BlackJackPlayer
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public bool IsCpu { get; set; }

        public BlackJackPlayer(bool isCpu)
        {
            Cards = new List<Card>();
            IsCpu = isCpu;
        }

        public int[] CurrentScore
        {
            get
            {
                if (Cards == null || Cards.Count == 0)
                    return new[] { 0 };

                var totalOne = 0;
                var totalTwo = 0;

                foreach(var card in Cards)
                {
                    if (card.Value == Values.Ace)
                    {
                        totalOne += 1;
                        totalTwo += 11;
                    }
                    else
                    {
                        var cardVal = (int)card.Value + 1;
                        if (cardVal > 10)
                            cardVal = 10;

                        totalOne += cardVal;
                        totalTwo += cardVal;
                    }
                }

                if (totalOne == totalTwo)
                    return new[] { totalOne };

                return new[] { totalOne, totalTwo };
            }
        }
    
        public bool checkingGameOver { get; set; }
        public class CheckingGameOver
        {
               
        }

    }

    public class BlackJack
    {
        public enum GameState
        {
            Starting,
            Dealing,
            StickingOrTwisting,
            Ending,
            WaitingForInput,
        }

        GameState currentState;
        Deck deck;

        private BlackJackPlayer dealer;
        private BlackJackPlayer user;
        private BlackJackPlayer currentPlayer;

        public BlackJack()                             // Game
        {
            currentState = GameState.Starting;
        }

        public void Update(string input)
        {

            switch (currentState)
            {
                case GameState.Starting:
                    dealer = new BlackJackPlayer(true);
                    user = new BlackJackPlayer(false);

                    Console.WriteLine("Welcome to Blackjack     ");
                    Console.WriteLine("Please Enter your name   ");

                    dealer.Name = "The Dealer";

                    var name = Console.ReadLine();
                    user.Name = string.IsNullOrWhiteSpace(name) ? "User 1" : name;

                    deck = new Deck();        // Deck Insilised                 
                    deck.Shuffle();

                    currentPlayer = user;
                    currentState = GameState.Dealing;
                    break;

                case GameState.Dealing:
                    // Needs method to ensure users lists are clear
                    currentPlayer.Cards.Add(deck.Deal());     //Dealing and adding card
                    currentPlayer.Cards.Add(deck.Deal());    //Dealing and adding card

                    Console.WriteLine("");
                    Console.WriteLine(currentPlayer.Name + "'s" + " " + "Cards");

                    foreach (Card card in currentPlayer.Cards)
                    {
                        if (currentPlayer.IsCpu)
                        {
                            Console.WriteLine("Card: ** of ****** ");
                        }
                        else
                        {
                            Console.WriteLine("Card: {0} of {1} ", card.Value, card.Suit);
                        }                       
                    }

                    deck.CheckRemainingCard();

                    if (!currentPlayer.IsCpu)
                        currentPlayer = dealer;
                    else
                    {
                        currentPlayer = user;
                        currentState = GameState.StickingOrTwisting;
                    }
                    break;

                case GameState.StickingOrTwisting:
                    
                    currentState = GameState.Ending;
                    break;

                case GameState.Ending:
                    currentState = GameState.WaitingForInput;
                    break;

                case GameState.WaitingForInput:
                    if (input != null)
                    {
                    }
                    break;
            }
        }
    }
}


