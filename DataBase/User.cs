using System.Text.RegularExpressions;

namespace tinder_1.Models
{
    /// <summary>
    /// класс пользователя 
    /// </summary>
    public class User
    {
        private string password;
        /// <summary>
        /// Уникальный идентификатор пользователя
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public required string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public required string Password
        {
            get
            {
                var passwordPattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

                if (Regex.IsMatch(password, passwordPattern))
                {
                    return password;
                }
                else
                {
                    throw new ArgumentException("Ненадежный пароль! Введите пароль снова", nameof(Password)
                    );
                }
            }
            set
            {
                password = value;
            }
        }
    }
}