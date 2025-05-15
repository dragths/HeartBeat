namespace tinder_1.Models
{
    /// <summary>
    /// класс жанров музыки
    /// </summary>
    public class MusicGenre
    {
        /// <summary>
        /// Уникальный идентификатор жанра
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название музыкального жанра
        /// </summary>
        public required string Name { get; set; }
    }
}