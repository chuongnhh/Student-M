using CodeHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseObject.Entities
{
    [Table("Level")]
    public class Level
    {
        public Level()
        {
            Id = GuidComb.GenerateComb();
            Teams = new List<Team>();
            Games = new List<Game>();
        }
        [Key]
        public Guid Id { get; set; }
        public string LevelName { get; set; }

        public virtual IList<Team> Teams { get; set; }
        public virtual IList<Game> Games { get; set; }
    }
}
