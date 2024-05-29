using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace Messanger_Database
{
   
    public class Users_Model : DbContext
    {
        public DbSet<User> Users { get; set; }
        public Users_Model()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLLocalDB;
                                          initial catalog=Users_Database;
                                          integrated security=True;
                                          Connect Timeout=2;
                                          Encrypt=False;
                                          TrustServerCertificate=False;
                                          ApplicationIntent=ReadWrite;
                                          MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .IsRequired();

                entity.Property(e => e.Nickname)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(e => e.Login)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Password)
                      .IsRequired();

                entity.Property(e => e.Admin)
                      .IsRequired(false);
            });
        }
    }
}
