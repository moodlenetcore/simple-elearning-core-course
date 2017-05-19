using Microsoft.EntityFrameworkCore;

namespace simple_elearning
{
    public class SimpleELearningContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=SimpleElearningDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}