using Core.Persistence.Repositories;
using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<User> Users { get; set; }


        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //    base.OnConfiguring(
            //        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SomeConnectionString")));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Users
            #region UserModelBuilder
            modelBuilder.Entity<User>(a =>
            {
                a.ToTable("Users").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Surname).HasColumnName("Surname");
                a.Property(p => p.FullName).HasColumnName("FullName");
                a.Property(p => p.UserName).HasColumnName("UserName");
                a.Property(p => p.Password).HasColumnName("Password");
                a.Property(p => p.Email).HasColumnName("Email");
                a.Property(p => p.DataStatus).HasColumnName("DataStatus");
                a.Property(p => p.CreatedUserId).HasColumnName("CreatedUserId");
                a.Property(p => p.UpdatedUserId).HasColumnName("UpdatedUserId");
                a.Property(p => p.CreatedAt).HasColumnName("CreatedAt");
                a.Property(p => p.UpdatedAt).HasColumnName("UpdatedAt");
            });
            #endregion
            #endregion

            //Seed data
            #region UserSeedData
            User[] userSeeds =
            {
                new User
                {
                    Id = 1,
                    Name = "Yönetici",
                    Surname = "Admin",
                    FullName = "Yönetici Admin",
                    Email = "admin@mail.com",
                    UserName = "admin",
                    Password = "9K7Cwg3Qw/8FR/S9VvrNdgl8znxhPagMZ4QrajV/3AQ=", //admin
                    CreatedAt = new DateTime(2020, 03, 09),
                    DataStatus = DataStatus.Activated
                }
            };
            modelBuilder.Entity<User>().HasData(userSeeds);
            #endregion


        }
    }
}
