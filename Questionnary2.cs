using NLog;
using System.Data;
using tinder_1.DataBase;
using tinder_1.Models;

namespace tinder_1
 { 
    /// <summary>
     /// класс формы анкета1
     /// </summary>
    public partial class Questionnary2 : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private Guid _userId;
        private UserProfile _userProfile;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// конструктор формы анкета2
        /// </summary>
        public Questionnary2(Guid userId)
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _userProfile = _dbContext.UserProfiles.Find(userId);
            _userId = userId;
            LoadUserProfile();
            
            this.CenterToScreen();
 
        }
        private void LoadUserProfile()
        {
            _userProfile = _dbContext.UserProfiles.FirstOrDefault(up => up.UserId == _userId);

            if (_userProfile == null)
            {
                MessageBox.Show("Профиль не найден!"); 
                return;
            }
            LoadHobbies();
            LoadRelationship();
            LoadFilm();
            LoadMusic();

            txtAboutme.Text = _userProfile.AboutMe;
        }
        private void LoadHobbies()
        {
            var hobbies = _dbContext.Hobbies.
                    Select(e => e.Name).
                    Distinct().
                    OrderBy(g => g).
                    ToArray();

            cmbHobbies.Items.AddRange(hobbies);
        }
        private void LoadFilm()
        {
            var films = _dbContext.FilmGenres
                .Select(e => e.Name)
                .Distinct()
                .OrderBy(c => c)
                .ToArray();

            cmbFilm.Items.AddRange(films);
        }
        private void LoadMusic()
        {
            var music = _dbContext.MusicGenres
                   .Select(e => e.Name)
                   .Distinct()
                   .OrderBy(c => c)
                   .ToArray();

            cmbMusic.Items.AddRange(music);
        }
        private void LoadRelationship()
        {
            var relat = _dbContext.BadHabitsAttitudes
                     .Select(e => e.Name)
                     .Distinct()
                     .OrderBy(c => c)
                     .ToArray();

            cmbRelationship.Items.AddRange(relat);
        }
        private bool CheckForm()
        {
            string aboutme = txtAboutme.Text;
            bool isValid = true;

            if (aboutme == string.Empty)
            {
                txtAboutme.BackColor = Color.LightPink;
                isValid = false;
            }
            if (cmbHobbies.Text == string.Empty || cmbMusic.Text == string.Empty || cmbFilm.Text == string.Empty || cmbRelationship.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            return isValid;
        }
        private void SaveProfile()
        {
            try
            {
                Guid? hobbyId = _dbContext.Hobbies.FirstOrDefault(hobby => hobby.Name == cmbHobbies.Text)?.Id;
                Guid? musicGenreId = _dbContext.MusicGenres.FirstOrDefault(music => music.Name == cmbMusic.Text)?.Id;
                Guid? filmGenreId = _dbContext.FilmGenres.FirstOrDefault(film => film.Name == cmbFilm.Text)?.Id;
                Guid? badHabitsAttitudeId = _dbContext.BadHabitsAttitudes.FirstOrDefault(attitude => attitude.Name == cmbRelationship.Text)?.Id;

                _userProfile.HobbyId = hobbyId;
                _userProfile.BadHabitsAttitudeId = badHabitsAttitudeId;
                _userProfile.MusicGenreId = musicGenreId;
                _userProfile.FilmGenreId = filmGenreId;
                _userProfile.AboutMe = txtAboutme.Text;

                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                return;
            }
            SaveProfile();
            logger.Info("Пользователь заполняет данные");

            var nextForm = new MainWindow(_userId);
            nextForm.Show();
            this.Hide();
            logger.Info("Пользователь переходит на главную форму");
        }
    }
}