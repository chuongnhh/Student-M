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
    [Table("Question")]
    public class Question
    {
        public Question()
        {
            Id = GuidComb.GenerateComb();
            Answers = new List<Answer>();
        }
        [Key]
        public Guid Id { get; set; }
        public string QuestionName { get; set; }

        public virtual IList<Answer> Answers { get; set; }
        [ForeignKey("Game")]
        public Guid GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}
