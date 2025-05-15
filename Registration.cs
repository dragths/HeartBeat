using NLog;
using System.Text.RegularExpressions;
using tinder_1.DataBase;
using tinder_1.Models;

namespace tinder_1
{
    /// <summary>
    /// класс формы регистрации
    /// </summary>
    public partial class Registration : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private bool isPasswordVisible = false;
        private static Logger logger = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// конструктор формы регистрации
        /// </summary>
        public Registration()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            txtPasswordRepeate.PasswordChar = '*';
            this.CenterToScreen();

            _dbContext = new ApplicationDbContext();
        }

        private void btnRegistration2_Click(object sender, EventArgs e)
        {

            string login = textBoxLogin.Text;
            logger.Info("Пользователь вводит логин");
            string pass = textBoxPassword.Text;
            logger.Info("Пользователь вводит пароль");
            string passRepeate = txtPasswordRepeate.Text;
            logger.Info("Пользователь подтверждает пароль");

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(passRepeate))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pass != passRepeate)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(pass, @"^(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$"))
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов, хотя бы одну цифру или спецсимвол, а также хотя бы одну заглавную и одну строчную латинскую букву.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(login, @"^[a-zA-Z][a-zA-Z0-9]{1,19}$"))
            {
                MessageBox.Show("Логин должен содержать от 2 до 20 символов, начинаться с буквы и состоять только из латинских букв и цифр.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (LoginIsTaken(login))
            {
                MessageBox.Show("Такой логин уже занят!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Guid userId = RegisterNewUser(login, pass);

                MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Info("Пользователь зарегистрировался");

                var nextForm = new Questionnary(userId);
                nextForm.Show();
                this.Hide();
                logger.Info("Пользователь переходит на первую форму анкеты");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool LoginIsTaken(string login)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Login == login) != null;
        }
        private Guid RegisterNewUser(string login, string password)
        {
            try
            {
                var newUser = new User
                {
                    Login = login,
                    Password = RepeateMethod.Hashing(password),
                };

                _dbContext.Users.Add(newUser);
                _dbContext.SaveChanges();

                return newUser.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void btnCheckPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            RepeateMethod.TogglePasswordVisibility(textBoxPassword, isPasswordVisible);
        }

        private void btnCheckRepPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            RepeateMethod.TogglePasswordVisibility(txtPasswordRepeate, isPasswordVisible);
        }
    }
}