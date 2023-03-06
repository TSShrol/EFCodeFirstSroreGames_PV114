using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Studio
    {
        public int Id { get; set; }
        public String NameStudio { get; set; }
        public String Founder { get; set; }
        public String Country { get; set; }

        List<Game> Games { get; set; }
    }
}
