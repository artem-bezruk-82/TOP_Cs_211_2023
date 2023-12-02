using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public abstract class CardDeck
    {
        protected LinkedList<Card> _deck;

        public int Count { get { return _deck.Count; } }

        public CardDeck()
        {
            _deck = new LinkedList<Card>();
        }

        public Card ExtractCard() 
        {
            Card card = _deck.First();
            _deck.RemoveFirst();
            return card;
        }

        public void AddCardOnTop(Card card) 
        {
            _deck.AddFirst(card);
        }
    }
}
