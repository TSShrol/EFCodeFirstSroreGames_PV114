using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class StyleGame
    {
        //primary key
        public int Id { get; set; } 
        //public int StyleGameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = "Info...";

        public List<Game> Games { get; set; }

    }
}
