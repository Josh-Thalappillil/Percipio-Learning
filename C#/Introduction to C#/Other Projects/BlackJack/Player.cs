using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlackJack
{
    public class Player
    {
        public Hand Hand { get; }
        public string Name { get; }

        public Player(string name)
        {
            Name = name;
            Hand = new Hand();
        }
        public void Hit(Card card)
        {
            Hand.AddCard(card);
        }
    }
}
