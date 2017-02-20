using CodeHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseObject.Entities
{
    [Table("Game")]
    public class Game
    {
        public Game()
        {
            Id = GuidComb.GenerateComb();
            Questions = new List<Question>();
        }
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public int GameTime { get; set; }

        [ForeignKey("Level")]
        public Guid LevelId { get; set; }
        public virtual Level Level { get; set; }

        public virtual IList<Question> Questions { get; set; }
    }
}
