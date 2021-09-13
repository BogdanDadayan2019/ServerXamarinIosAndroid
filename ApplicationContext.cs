using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaleWeb2
{
    public class ApplicationContext : DbContext
    {

        public DbSet<ClothesType> ClothesType { get; set; }

        public DbSet<Clothes> Clothes { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=192.168.0.188;user=nameuser;password=bugagamanb9k;database=ClothesTypeDb1;", new MySqlServerVersion(new Version(8, 0, 11)));

        }

    }
}
