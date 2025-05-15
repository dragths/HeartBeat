using System.Text.RegularExpressions;

namespace tinder_1.Models
{
    /// <summary>
    /// Представляет профиль пользователя
    /// </summary>
    public class UserProfile
    {
        private string name;
        private string phoneNumber;
        private DateTime birthDate;

        /// <summary>
        /// Уникальный идентификатор профиля
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Ссылка на объект пользователя
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name
        {
            get
            {
                if (Regex.IsMatch(name, "^[а-яА-Я]*$"))
                {
                    if (Char.IsUpper(name[0]))
                    {
                        return name;
                    }
                    else
                    {
                        throw new ArgumentException("Имя должно начинаться с заглавной буквы", nameof(Name));

                    }
                }
                else
                {
                    throw new ArgumentException("Имя может содержать только буквенные символы", nameof(Name));
                }
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Номер телефона пользователя
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                if (Regex.Match(phoneNumber, "^[0-9]{11}$").Success)
                {
                    return phoneNumber;
                }
                else
                {
                    throw new ArgumentException("Номер телефона должен содержать ровно 11 цифр", nameof(PhoneNumber));
                }
            }
            set
            {
                phoneNumber = value;
            }
        }

        /// <summary>
        /// Идентификатор пола пользователя
        /// </summary>
        public Guid? GenderId { get; set; }

        /// <summary>
        /// Ссылка на объект пола
        /// </summary>
        public virtual Gender Gender { get; set; }

        /// <summary>
        /// Дата рождения пользователя
        /// </summary>
        public DateTime? BirthDate
        {
            get
            {
                if (DateTime.Now.AddYears(-18) >= birthDate)
                {
                    return birthDate;
                }
                else
                {
                    throw new ArgumentException("Пользователь должен быть старше 18 лет", nameof(BirthDate));
                }
            }
            set
            {
                birthDate = (DateTime)value;
            }
        }

        /// <summary>
        /// Идентификатор города пользователя
        /// </summary>
        public Guid? CityId { get; set; }

        /// <summary>
        /// Ссылка на объект города
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// Путь к фотографии пользователя
        /// </summary>
        public string PhotoPath { get; set; }

        /// <summary>
        /// Идентификатор хобби пользователя
        /// </summary>
        public Guid? HobbyId { get; set; }

        /// <summary>
        /// Ссылка на объект хобби
        /// </summary>
        public virtual Hobby Hobby { get; set; }

        /// <summary>
        /// Идентификатор музыкального жанра
        /// </summary>
        public Guid? MusicGenreId { get; set; }

        /// <summary>
        /// Ссылка на объект музыкального жанра
        /// </summary>
        public virtual MusicGenre MusicGenre { get; set; }

        /// <summary>
        /// Идентификатор жанра фильмов
        /// </summary>
        public Guid? FilmGenreId { get; set; }

        /// <summary>
        /// Ссылка на объект жанра фильмов
        /// </summary>
        public virtual FilmGenre FilmGenre { get; set; }

        /// <summary>
        /// Идентификатор отношения к вредным привычкам
        /// </summary>
        public Guid? BadHabitsAttitudeId { get; set; }

        /// <summary>
        /// Ссылка на объект отношения к вредным привычкам
        /// </summary>
        public virtual BadHabitsAttitude BadHabitsAttitude { get; set; }

        /// <summary>
        /// Информация о себе
        /// </summary>
        public string? AboutMe { get; set; }
    }
}