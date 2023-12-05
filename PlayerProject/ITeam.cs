using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProject
{
    public interface ITeam
    {
        void AddPlayer(Player player);
        void RemovePlayer(int playerID);
        Player GetPlayerByID(int playerID);
        Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
       

    }
}
