using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProjectCheckpoint.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
    }
}
