namespace tinder_1.Models
{
    /// <summary>
    /// класс для избранных 
    /// </summary>
    public class Favorites
    {
        /// <summary>
        /// Уникальный идентификатор записи
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Идентификатор избранного пользователя
        /// </summary>
        public Guid FavoriteUserId { get; set; }
    }
}