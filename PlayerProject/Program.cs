using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlayerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Choice;
            do
            {
                Player obj = new Player();
                OneDayTeam team = new OneDayTeam();
                Console.WriteLine("Choose Operation");
                Console.WriteLine("1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players");
                int op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        {

                            team.Add(obj);
                            break;
                        }
                    case 2:
                        {
                            team.Remove(100);
                            break;
                        }
                    case 3:
                        {
                            team.GetPlayerByID(100);
                            Console.WriteLine("101 \t Virat\t 34");
                            break;
                        }
                    case 4:
                        {
                            team.GetPlayerByName("Sachine");
                            Console.WriteLine("104 \t MSD\t 34");
                            break;
                        }
                    case 5:
                        {
                            team.GetPlayers();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice!!!");
                            break;
                        }

                }
                Console.WriteLine("If you want to continue press....y");
                Choice = Console.ReadLine();
            } while (Choice == "y");
            Console.ReadKey();
        }
    }
}
