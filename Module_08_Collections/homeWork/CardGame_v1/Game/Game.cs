using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Game
    {
        public static int MinPlayers { get { return 2; } }
        public static int MaxPlayers { get { return 6; } }

        public int PlayersCount { get { return _players.Count; } }

        private CardPack _pack;

        private List<Card> _bank;

        private List<Player> _players;

        public Player? LastWinner { get; private set; }

        public Game()
        {
            _pack = new CardPack();
            _bank = new List<Card>();
            _players = new List<Player>();
        }

        public void AddPlayer(Player player) 
        {
            if (_players.Count < 6) 
            {
                if (!_players.Contains(player))
                    _players.Add(player);
                else
                    throw new InvalidOperationException(message: $"Player with name {player.Name} already exists");
            }
            else
                throw new InvalidOperationException(message: $"The game supports up to {MaxPlayers} players");
        }

        public void SetupGame() 
        {
            if (_players.Count > 1) 
            {
                FormPack();
                _pack.Snuffle();
                DealCards();
            }
            else
                throw new InvalidOperationException(message: $"The game supports at least {MinPlayers} players");
        }

        private void FormPack() 
        {
            var types = Enum.GetValues(typeof(CardSuitsEnum));
            foreach (var type in types)
            {
                for (int i = Card.MinRank; i <= Card.MaxRank; i++)
                {
                    _pack.AddCardOnTop(new Card((CardSuitsEnum)type, i));
                }
            }
        }

        private void DealCards() 
        {
            while (_pack.Count > 0) 
            {
                for (int i = 0; i < _players.Count; i++)
                {
                    _players[i].AddCard(_pack.ExtractCard());
                }
            }
        } 

        private Player GetMaxScoredPlayer() 
        {
            Player playerMaxScores = _players[0];
            for (int i = 1; i < _players.Count; i++)
            {
                if (_players[i].CompareTo(playerMaxScores) > 0) 
                {
                    playerMaxScores = _players[i];
                }
            }
            return playerMaxScores;
        }

        public void PlayRound() 
        {
            _bank.Clear();
            _players.RemoveAll(item => item.CardsCount == 0);
            Player roundWinner = GetMaxScoredPlayer();
            foreach (Player player in _players) 
            {
               _bank.Add(player.PutDownCard());
            }
            roundWinner.TakeBank(_bank);
            LastWinner = roundWinner;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Round result: ");
            for (int i = 0; i < _bank.Count; i++)
            {
                sb.Append($"\n\t{_players[i].Name}: {_bank[i]}");
            }
            sb.Append($"\nRound Winner: {LastWinner?.Name}");
            return sb.ToString();
        }
    }
}
