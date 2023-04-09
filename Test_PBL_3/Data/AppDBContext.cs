using Microsoft.EntityFrameworkCore;
using Test_PBL_3.Models;

namespace Test_PBL_3.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {

        }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this function be used for create table with no key parameter
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new { am.ActorID, am.MovieID });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieID);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieID);


            base.OnModelCreating(modelBuilder);
        }
        */
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }


    }
}
