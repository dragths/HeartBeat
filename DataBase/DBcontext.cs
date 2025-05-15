using Microsoft.EntityFrameworkCore;
using tinder_1.Models;

namespace tinder_1.DataBase
{
    /// <summary>
    /// класс бд
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Таблица пользователей
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Таблица профилей пользователей
        /// </summary>
        public DbSet<UserProfile> UserProfiles { get; set; }

        /// <summary>
        /// Таблица избранных профилей
        /// </summary>
        public DbSet<Favorites> FavoriteProfiles { get; set; }

        /// <summary>
        /// Таблица полов
        /// </summary>
        public DbSet<Gender> Genders { get; set; }

        /// <summary>
        /// Таблица городов
        /// </summary>
        public DbSet<City> Cities { get; set; }

        /// <summary>
        /// Таблица хобби
        /// </summary>
        public DbSet<Hobby> Hobbies { get; set; }

        /// <summary>
        /// Таблица музыкальных жанров
        /// </summary>
        public DbSet<MusicGenre> MusicGenres { get; set; }

        /// <summary>
        /// Таблица жанров фильмов
        /// </summary>
        public DbSet<FilmGenre> FilmGenres { get; set; }

        /// <summary>
        /// Таблица отношений к вредным привычкам
        /// </summary>
        public DbSet<BadHabitsAttitude> BadHabitsAttitudes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString1 = "Host=localhost;Database=DBTinder;Username=postgres;Password=1234554321;";
            optionsBuilder.UseNpgsql(connectionString1);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users", "public");
            modelBuilder.Entity<UserProfile>().ToTable("UserProfiles", "public");
            modelBuilder.Entity<Favorites>().ToTable("Favorites", "public");
            modelBuilder.Entity<Gender>().ToTable("Genders", "public");
            modelBuilder.Entity<City>().ToTable("Cities", "public");
            modelBuilder.Entity<Hobby>().ToTable("Hobbies", "public");
            modelBuilder.Entity<MusicGenre>().ToTable("MusicGenres", "public");
            modelBuilder.Entity<FilmGenre>().ToTable("FilmGenres", "public");
            modelBuilder.Entity<BadHabitsAttitude>().ToTable("BadHabitsAttitudes", "public");
        }
    }
}