using DataAccess.Entities;
using DataAccess.Interfaces;
using DataAccess.Services;
using System;

namespace EFCodeFirstSroreGames
{
    class Program
    {

        private static IGameService _gameService = new GameService();
        static void Main(string[] args)
        {
            Game game1 = new Game
            {
                NameGame = "Need for Speed",
                Studio = "EAGames Sports",
                Release = new DateTime(2015,5,5),
                StyleGame=new StyleGame { 
                    Name="ArcadRaising",
                    Description="Info..."
                }
            };

            var style2 = new StyleGame
            {
                Name = "Shooter",
                Description = "Info..."
            };

            
            Game game2 = new Game
            {
                NameGame = "Contro Strike",
                Studio = "Valve",
                Release = new DateTime(2015, 5, 5),
                StyleGame=style2
            };
            _gameService.Create(game2);
            var games=_gameService.GetAll();
            foreach (var item in games)
            {
                Console.WriteLine(item.NameGame);
            }
        }
    }
}
