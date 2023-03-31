using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        // deck and hand are private in the dealer so that the dealer can access and modify data but the data cannot be modified by other classes
        private Hand hand;
        private Deck deck;


        public Dealer(Deck deck)
        {
            this.deck = deck;
            hand = new Hand();
        }
        public void Deal(Player player)
        {
            // Drawing two cards and storing the information
            player.Hit(deck.DrawCard());
            hand.AddCard(deck.DrawCard());
            player.Hit(deck.DrawCard());
            hand.AddCard(deck.DrawCard());
        }
    }
}
