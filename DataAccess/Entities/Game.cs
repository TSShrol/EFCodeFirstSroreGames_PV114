using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
   [Table("CompGame")]
   public class Game
    {
        public int Id { get; set; }
      
        [Required]
        [MaxLength(50)]
        public string NameGame { get; set; }
        public int StudioId { get; set; }

        public DateTime Release { get; set; }
        public int CountSell { get; set; }
        //foregin key 
        public int StyleGameId { get; set; }

        //navigetion property
        public Studio Studio { get; set; }
        public StyleGame StyleGame { get; set; }
    }
    
}
//Режим гри: однокористувацький, багатокористувацький.Кількість проданих копій.