namespace tinder_1.Models
{
    /// <summary>
    /// Класс для отношения пользователя к вредным привычкам
    /// </summary>
    public class BadHabitsAttitude
    {
        /// <summary>
        /// Уникальный идентификатор записи об отношении к вредной привычке
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название или описание отношения к вредной привычке
        /// </summary>
        public required string Name { get; set; }
    }
}