using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface  IGameService
    {
       public  List<Game> GetAll();
       public Game GetById(int id);
       public void Create(Game game);
       public void Delete(int id);
       public void Update(Game game);


    }
}
