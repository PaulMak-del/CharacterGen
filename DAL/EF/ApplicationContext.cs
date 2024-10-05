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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FF;Database=CharacterGen;Encrypt=False;Trusted_Connection=True;");
        }
    }
}
