using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeam
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public IReadOnlyCollection<Player> Players => players;
        public int Rating => this.players.Count == 0 ? 0 : (int)Math.Round(this.players.Average(x => x.SkillLevel));
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            var player = players.FirstOrDefault(x => x.Name == playerName);
            if (player == null)
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }
            this.players.Remove(player);
        }
    }
}
