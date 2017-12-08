using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DBConnection")
        { }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<Session> Session { get; set; }
        public DbSet<Movie> Movie { get; set; }

        public DbSet<Hall> Hall { get; set; }

    }
}
