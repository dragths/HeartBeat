namespace tinder_1.Models
{
    /// <summary>
    /// Класс города пользователя
    /// </summary>
    public class City
    {
        /// <summary>
        /// Уникальный идентификатор города
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название города
        /// </summary>
        public required string Name { get; set; }
    }
}