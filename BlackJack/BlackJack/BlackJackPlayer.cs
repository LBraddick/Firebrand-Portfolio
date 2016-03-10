using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
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

                foreach (var card in Cards)
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
    }
}

