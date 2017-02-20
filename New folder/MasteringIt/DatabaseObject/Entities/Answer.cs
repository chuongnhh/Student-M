using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeHelper;

namespace DatabaseObject.Entities
{
    [Table("Answer")]
    public class Answer
    {
        public Answer()
        {
            Id = GuidComb.GenerateComb();
        }
        [Key]
        public Guid Id { get; set; }
        public Guid AnswerLeter { get; set; }
        public string AnswerName { get; set; }
        public bool IsTrue { get; set; }

        [ForeignKey("Question")]
        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
