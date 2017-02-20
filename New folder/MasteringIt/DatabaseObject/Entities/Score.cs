using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseObject.Entities
{
    [Table("Score")]
    public class Score
    {
        [Key, ForeignKey("Team"), Column(Order = 1)]
        public Guid TeamId { get; set; }
        [Key, ForeignKey("Game"), Column(Order = 2)]
        public Guid GameId { get; set; }
        [Key, ForeignKey("Level"), Column(Order = 3)]
        public Guid LevelId { get; set; }

        public int ScoreNumber { get; set; }

        public virtual Team Team { get; set; }
        public virtual Game Game { get; set; }
        public virtual Level Level { get; set; }
    }
}
