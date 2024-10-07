using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    /**
    Контекст для работы с БД
     */
    public class ApplicationContext : DbContext
    {
        // Entities
        public DbSet<Race> Races { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Ability> Abiliteis { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<MoralPosition> MoralPositions { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<SavingThrows> SavingThrows { get; set; }
        public DbSet<Ability_Character> Ability_Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FF;Database=CharacterGen;Encrypt=False;Trusted_Connection=True;");
        }
    }
}
