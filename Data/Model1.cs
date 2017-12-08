namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Cinema> Cinema { get; set; }
        public virtual DbSet<Hall> Hall { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Cinema>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Cinema>()
                .HasMany(e => e.Hall)
                .WithRequired(e => e.Cinema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Movie>()
                .Property(e => e.Discription)
                .IsFixedLength();

            modelBuilder.Entity<Movie>()
                .Property(e => e.Image)
                .IsFixedLength();

            modelBuilder.Entity<Movie>()
                .Property(e => e.Tecnology)
                .IsFixedLength();

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.Session)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Session>()
                .HasMany(e => e.Cinema)
                .WithRequired(e => e.Session)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
