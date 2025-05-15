namespace tinder_1.Models
{
    /// <summary>
    /// класс хобби пользователя
    /// </summary>
    public class Hobby
    {
        /// <summary>
        /// Уникальный идентификатор хобби
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название хобби
        /// </summary>
        public required string Name { get; set; }
    }
}