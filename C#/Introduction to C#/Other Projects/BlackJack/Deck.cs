using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();

            //Creation of deck of cards
            Card.Rank[] ranks = (Card.Rank[])Enum.GetValues(typeof(Card.Rank));
            Card.Suit[] suits = (Card.Suit[])Enum.GetValues(typeof(Card.Suit));

            foreach (Card.Suit suit in suits)
            {
                foreach (Card.Rank rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            int n = cards.Count;

            for (int i = 0; i < n; i++)
            {
                int k = random.Next(i, n);
                (cards[i], cards[k]) = (cards[k], cards[i]);
            }
        }
        public Card DrawCard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
        public int CardsRemaining()
        {
            return cards.Count;
        }
    }
}
