using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace GigHub.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Following> Followings { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //fluentAPI
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .HasRequired(a => a.Gig)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationUser>()  
                .HasMany(u => u.Followers)  //an application user has many followers.
                .WithRequired(f => f.Followee)  //and each follower has a required followee
                .WillCascadeOnDelete(false); //bc multiple cascade paths problem 

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Followees)  //an application user has many followees.
                .WithRequired(f => f.Follower) // and each follower has a required follower
                .WillCascadeOnDelete(false);    //bc multiple cascade paths problem 

            base.OnModelCreating(modelBuilder);
        }
    }
}