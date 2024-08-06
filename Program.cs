using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace O_O_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<VideoGame> games = new List<VideoGame>();
            VideoGame game1 = new VideoGame("Roblox", "Roblox Corp", "6+");
            VideoGame game2 = new VideoGame("World Of WarCraft", "Blizzard", "13+");
            VideoGame game3 = new VideoGame("Minecraft", "Mojang Studios", "10+");
            VideoGame game4 = new VideoGame("Grand Theft Auto V", "Rockstar Games", "18+");

            games.Add(game1);
            games.Add(game2);
            games.Add(game3);
            games.Add(game4);

            foreach (VideoGame game in games)
            {
                Console.WriteLine("Name: " + game.name);
                Console.WriteLine("Publisher: " + game.publisher);
                Console.WriteLine("Age Rating: " + game.rating);
                Console.WriteLine("");
            }




            Console.ReadLine();
        }
    }
}
