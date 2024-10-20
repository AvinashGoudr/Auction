using Auction.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auction.Repository.Resources
{
    public class AppDbContext : DbContext
    {
        //public DbSet<UserEntity> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string conStr = "Integrated Security = SSPI; " +
        //        @"Server=HMECL006031\MSSQLSERVER03;DataBase=Auction;";
        //    optionsBuilder.UseSqlServer(conStr);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(
                    new UserEntity
                    {
                        Id = 1,
                        Name = "Sushma",
                        Email = "sushma@gmail.com",
                        Password = "AQAAAAEAACcQAAAAEJKrb0th+FGYwdaRDuX0k1Zv47df9P+G3p17T6CghVF2lL0l2yi9FA3TcNqgUdtRiA==",
                    },
                    new UserEntity
                    {
                        Id = 2,
                        Name = "Kavya",
                        Email = "kavya@gmail.com",
                        Password = "AQAAAAEAACcQAAAAEJKrb0th+FGYwdaRDuX0k1Zv47df9P+G3p17T6CghVF2lL0l2yi9FA3TcNqgUdtRiA==",
                    },
                    new UserEntity
                    {
                        Id = 3,
                        Name = "Harshitha",
                        Email = "harshitha@gmail.com",
                        Password = "AQAAAAEAACcQAAAAEJKrb0th+FGYwdaRDuX0k1Zv47df9P+G3p17T6CghVF2lL0l2yi9FA3TcNqgUdtRiA==",
                    },
                    new UserEntity
                    {
                        Id = 4,
                        Name = "Avinash",
                        Email = "avinash@gmail.com",
                        Password = "AQAAAAEAACcQAAAAEJKrb0th+FGYwdaRDuX0k1Zv47df9P+G3p17T6CghVF2lL0l2yi9FA3TcNqgUdtRiA==",
                    });
        }
    }
}
