using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class CardDeckPlayer : CardDeck
    {
        public Card OnTopCard { get { return _deck.First(); } }
        public CardDeckPlayer() : base() { }

        public void AddCardsToBottom(List<Card> cards) 
        {
            for (int i = 0; i < cards.Count; i++) 
            {
                if (cards[i] != null)
                    _deck.AddLast(cards[i]);
            }
        }
    }
}
