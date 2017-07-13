using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CocktailInspiration.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<IngredientQuantity> IngredientQuantity { get; set; }

        private string _databasePath;

        public DatabaseContext()
        {
#if __IOS__
            _databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "CocktailInspiration.db");
#elif __ANDROID__
            _databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "CocktailInspiration.db");
#else
            _databasePath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "CocktailInspiration.db");
#endif
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
