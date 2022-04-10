using System.Data.Entity;

namespace ToyotaBPKAssessment.EFObjects
{
    public class BPKContext : DbContext
    {
        public BPKContext() : base()
        {

        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}