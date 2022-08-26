using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardStuff
{
    public class Player
    {
        public Hand Hand { get; set; }
        
        public Player(Card card1, Card card2)
        {
            Hand = new Hand(card1, card2);
        }
    }
}
