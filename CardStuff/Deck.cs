using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardStuff
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck() 
        {
            Cards = GetDeck();
        }

        public static List<Card> GetDeck()
        {
            List<Card> deck = new List<Card>();
            for (int i = 0; i < 13; i++)
            {
                deck.Add(new Card(i, 0));
            }
            for (int i = 0; i < 13; i++)
            {
                deck.Add(new Card(i, 1));
            }
            for (int i = 0; i < 13; i++)
            {
                deck.Add(new Card(i, 2));
            }
            for (int i = 0; i < 13; i++)
            {
                deck.Add(new Card(i, 3));
            }
            return deck;
        }

        public void ShuffleDeck()
        {
            List<Card> shuffled = new List<Card>();
            Random rand = new Random();
            for (int i = Cards.Count(); i > 0; i--)
            {
                int index = rand.Next(Cards.Count());
                shuffled.Add(Cards[index]);
                Cards.RemoveAt(index);
            }
            Cards = shuffled;
        }

        public Card GetCard()
        {
            Random rand = new Random();
            int index = rand.Next(Cards.Count());
            Card draw = Cards[index];
            Cards.RemoveAt(index);

            return draw;
        }
    }
}
