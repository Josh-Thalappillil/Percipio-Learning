using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hand
    {
        private List<Card> cards;
         
        public Hand()
        {
            cards = new List<Card>();
        }
        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        // This method calculates the total value of a hand of cards in the game of BlackJack
        public int GetValue()
        {
            int value = cards.Sum(card => card.Value);

            if (cards.Any(card => card.rank == Card.Rank.Ace) && value + 10 <= 21)
            {
                value += 10;
            }
            return value;
        }
            
        public void Clear()
            {
                cards.Clear();
            }
    }
}
