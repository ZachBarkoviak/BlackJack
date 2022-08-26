using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardStuff
{
    public class Hand
    {
        public Card Card1 { get; set; }
        public Card Card2 { get; set; }

        public List<Card> Cards = new List<Card>();
        public Hand(Card card1, Card card2)
        {
            Cards.Add(card1);
            Cards.Add(card2);
            Card1 = card1;
            Card2 = card2;
        }

        public override string ToString()
        {
            return $"{Card1}\n{Card2}";
        }

        public int GetValue()
        {
            int value = 0;
            foreach (Card card in Cards)
            {
                value += card.GetValue();
            }
            return value;
        }
    }
}
