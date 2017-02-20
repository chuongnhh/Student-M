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
    [Table("Member")]
    public class Member
    {
        public Member()
        {
            Id = GuidComb.GenerateComb();
        }
        [Key]
        public Guid Id { get; set; }
        public string MemberName { get; set; }

        [ForeignKey("Team")]
        public Guid TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
