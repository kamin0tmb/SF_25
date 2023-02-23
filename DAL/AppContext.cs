using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using SF_25.DAL.Entitys;

namespace SF_25.DAL
{
    public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<UserEntity> Users { get; set; }

        // Объекты таблицы Books
        public DbSet<BookEntity> Books { get; set; }

        // Объекты таблицы Authors
        public DbSet<AuthorEntity> Authors { get; set; }

        // Объекты таблицы Genres
        public DbSet<GenreEntity> Genres { get; set; }

        // Объекты таблицы Orders
        public DbSet<OrderEntity> Orders { get; set; }

        // Объекты таблицы Publishing_houses
        public DbSet<Publishing_houseEntity> Publishing_houses { get; set; }

        public bool Exists()
        {
            return (this.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists();
        }

        public bool CreatedDB()
        {
            return Database.EnsureCreated();
        }

        public bool DeletedDB()
        {
            return Database.EnsureDeleted();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString.MsSqlConnection);
        }
    }
}
