using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        //for many to many relationship add some instructions in appdbcontext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //for combination of pk--->HasKey
          //  modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            //{
            //    am.ActorId,
            //    am.MovieId,
            //});
          //  modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            //modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
            base.OnModelCreating(modelBuilder);
        }
        //definig table name for each model
        public DbSet<Actor> Actors { get; set; }    
        public DbSet<Movie> Movies { get; set; }
        //public DbSet<Actor_Movie>Actors_Movies  { get; set; }
        public DbSet<user> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
