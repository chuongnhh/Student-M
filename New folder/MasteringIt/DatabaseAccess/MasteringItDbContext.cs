using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseObject.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DatabaseAccess
{
    public class MasteringItDbContext:DbContext
    {
        public MasteringItDbContext():base("name = MasteringItDbContext")
        {

        }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
