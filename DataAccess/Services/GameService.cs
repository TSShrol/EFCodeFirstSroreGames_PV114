using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class GameService : IGameService
    {
        public void Create(Game game)
        {
            using StoreGamesContext db = new StoreGamesContext();
            db.Add(game);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAll()
        {
            using StoreGamesContext db = new StoreGamesContext();
            return db.Games.ToList();

        }

        public Game GetById(int id)
        {
           using StoreGamesContext db = new StoreGamesContext();
            var game = db.Games.Find(id);
            //var game = db.Games.FirstOrDefault(g=>g.id==id);
            return game;
        }

        public void Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
