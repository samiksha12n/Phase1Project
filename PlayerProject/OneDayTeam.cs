using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProject
{
    public class OneDayTeam : Player 
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public int Capacity { get; set; }
        public OneDayTeam()
        {
            Capacity = 11;
        }
        public void Add(Player player)
        {
            Console.WriteLine("Enter the Player ID");
            player.PlayerID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Name");
            player.PlayerName = Console.ReadLine();
            Console.WriteLine("Enter Age of Player");
            player.PlayerAge = int.Parse(Console.ReadLine());
            oneDayTeam.Add(player);
            Console.WriteLine("Player Added Success");
        }
        public void Remove(int playerID)
        {
            Console.WriteLine("Enter the Player ID to remove from the List");
            playerID = int.Parse(Console.ReadLine());
            for (int i = 0; i < oneDayTeam.Count; i++)
            {
                if (oneDayTeam[i].PlayerID == playerID)
                {
                    oneDayTeam.RemoveAt(i);
                  
                    break;
                }
            }
            Console.WriteLine("Player removed Success");
        }
        public Player GetPlayerByID(int playerID)
        {
            Console.WriteLine("Enter the Player ID to get details");
            playerID = int.Parse(Console.ReadLine());
            foreach (Player player in oneDayTeam)
            {
                if (player.PlayerID == playerID)
                {
                    Console.WriteLine("sachine");
                    Console.WriteLine(24);
                    return player;
                }
            }
            return null;
        }
        public Player GetPlayerByName(string playerName)
        {
            Console.WriteLine("Enter the Name of Player to get details");
            playerName = Console.ReadLine();
            foreach (Player player in oneDayTeam)
            {
                if (player.PlayerName == playerName)
                {
                    Console.WriteLine(100);
                    Console.WriteLine("sachine");
                    Console.WriteLine(24);
                    return player;
                }
            }
            return null;
        }

        public List<Player> GetPlayers()
        {
            Console.WriteLine("Details of the Players as follows");
            return oneDayTeam;
        }
    }
}
