using NLog;
using tinder_1.DataBase;
using tinder_1.Properties;

namespace tinder_1
{
    /// <summary>
    /// класс формы входа
    /// </summary>
    public partial class Entry : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private Guid _userId;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// конструктор формы входа
        /// </summary>
        public Entry()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            this.CenterToScreen();

            _dbContext = new ApplicationDbContext();       
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void CheckLogin()
        {
            var login = textBoxLogin.Text;
            logger.Info("Пользователь вводит логин");  
            var pass = textBoxPassword.Text;
            logger.Info("Пользователь вводит пароль");

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                textBoxLogin.BackColor = Color.LightPink;
                textBoxPassword.BackColor = Color.LightPink;

                return;
            }

            if (UserExists(login, pass))
            {
                MessageBox.Show("Успешный вход","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
                logger.Info("Пользователь входит в приложение");

                var nextForm = new MainWindow(_userId);
                nextForm.Show();
                this.Hide();
                logger.Info("Пользователь переходит на главную страницу");
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль","Ошибка" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool UserExists(string login, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Login == login && u.Password == RepeateMethod.Hashing(password));
            if (user != null)
            {
                _userId = user.Id;
                return true;
            }
            return false;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            var nextform = new Registration();
            nextform.Show();
            this.Hide();
            logger.Info("Пользователь переходит на форму регистрации");
        }
    }
}