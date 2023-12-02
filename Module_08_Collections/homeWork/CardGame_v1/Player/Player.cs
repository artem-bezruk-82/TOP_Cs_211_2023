using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Player : IComparable<Player>
    {
        private CardDeckPlayer _cards;
        public string Name { get; set; }

        public int CardsCount { get { return _cards.Count; } }

        public Card CurrentCard { get { return _cards.OnTopCard; } }

        public Player(string name)
        {
            _cards = new CardDeckPlayer();
            Name = name;
        }

        public void TakeBank(List<Card> cards) 
        {
            _cards.AddCardsToBottom(cards);
        }

        public Card PutDownCard() 
        {
            return _cards.ExtractCard();
        }

        public void AddCard(Card card) 
        {
            _cards.AddCardOnTop(card);
        }

        public int CompareTo(Player? other)
        {
            return CurrentCard.CompareTo(other?.CurrentCard);
        }
    }
}
