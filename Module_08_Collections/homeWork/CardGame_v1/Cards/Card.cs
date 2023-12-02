using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card : IComparable<Card>
    {
        private static int _minRank = 6;
        private static int _maxRank = 14;

        public static int MinRank { get { return _minRank; } }
        public static int MaxRank { get { return _maxRank; } }

        public CardSuitsEnum Suit { get; private set; }

        private int _rank;
        public int Rank 
        {
            get { return _rank; }
            private set 
            {
                if (value >= _minRank && value <= _maxRank)
                {
                    _rank = value;
                }
                else 
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, 
                        $"out of {_minRank}...{_maxRank} range");
                }
            } 
        }

        public string? Name 
        {
            get
            {
                return Rank switch
                {
                    (>= 6) and (<= 10) => $"{Rank}",
                    11 => "J",
                    12 => "Q",
                    13 => "K",
                    14 => "A",
                    _ => null
                };
            }
        }

        public Card(CardSuitsEnum suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public int CompareTo(Card? other)
        {
            return this.Rank.CompareTo(other?.Rank);
        }


        public static int Compare(Card cardLeft, Card cardRight) 
        {
            return cardLeft.CompareTo(cardRight);
        }

        public override string ToString()
        {
            return $"[{Name} {Suit.ToString()[0]}]";
        }
    }
}
