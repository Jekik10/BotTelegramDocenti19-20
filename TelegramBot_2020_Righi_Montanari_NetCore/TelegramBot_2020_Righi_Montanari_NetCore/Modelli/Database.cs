
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TelegramBot {
    public class Database : DbContext
    {
        public DbSet<Professore> Professori { get; set; }
        public DbSet<Studente> Studenti { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlite("Data Source=Database.sqlite");
        }
    }
}