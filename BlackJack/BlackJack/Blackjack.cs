using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
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
