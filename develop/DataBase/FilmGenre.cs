namespace tinder_1.Models
{
    /// <summary>
    /// класс жанров фильмов
    /// </summary>
    public class FilmGenre
    {
        /// <summary>
        /// Уникальный идентификатор жанра
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название жанра фильмов
        /// </summary>
        public required string Name { get; set; }
    }
}