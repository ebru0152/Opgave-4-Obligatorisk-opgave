using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave4ModelLib.model;

namespace Opgave4.Managers
{
    public class ManageFootballer : IManageFootballer
    {
        private static List<FootballPlayer> footballPlayers = new List<FootballPlayer>()
        {
            new FootballPlayer(1, "Cristiano Ronaldo", 76000000, 7),
            new FootballPlayer(2, "Pepe", 15000000, 3),
            new FootballPlayer(3, "Son Heung Min", 6500000, 7),
        };

        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(footballPlayers);
        }

        public FootballPlayer Get(int id)
        {
            return footballPlayers.Find(i => i.Id == id);
        }

        public bool Create(FootballPlayer value)
        {
            footballPlayers.Add(value);
            return true;
        }

        public bool Update(int id, FootballPlayer value)
        {
            FootballPlayer footballPlayer = Get(id);
            if (footballPlayer != null)
            {
                footballPlayer.Id = value.Id;
                footballPlayer.Name = value.Name;
                footballPlayer.Price = value.Price;
                footballPlayer.ShirtNumber = value.ShirtNumber;

                return true;
            }

            return false;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer footballPlayer = Get(id);
            footballPlayers.Remove(footballPlayer);
            return footballPlayer;
        }

    }
}
