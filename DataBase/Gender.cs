namespace tinder_1.Models
{
    /// <summary>
    /// класс пола пользователя
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Уникальный идентификатор пола
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название пола
        /// </summary>
        public required string Name { get; set; }
    }
}