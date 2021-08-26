using Microsoft.EntityFrameworkCore;
using PetMasters.Entidades;
using System;

namespace PetMasters.AulasEntity
{
    public class PetShopContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }

        private string StringConexao => "Server=(localdb)\\mssqllocaldb;Database=PetMastersDB;Trusted_Connection=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StringConexao);
        }
    }
}