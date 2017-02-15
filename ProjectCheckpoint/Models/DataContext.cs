using System.Data.Entity;

namespace ProjectCheckpoint.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<User> User { get; set; }
    }
}
