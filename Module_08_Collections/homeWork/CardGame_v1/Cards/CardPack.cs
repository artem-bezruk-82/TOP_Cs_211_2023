using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class CardPack : CardDeck
    {
        public CardPack() : base() { }

        public void Snuffle()
        {
            Card[] deck = _deck.ToArray();
            Random random = new Random();
            _deck.Clear();
            for (int i = deck.Length - 1; i > 0; i--)
            {
                int k = random.Next(i + 1);
                (deck[i], deck[k]) = (deck[k], deck[i]);
            }
            _deck = new LinkedList<Card>(deck);
        }
    }
}
