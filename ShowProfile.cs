using tinder_1.DataBase;
using tinder_1.Models;
using Microsoft.EntityFrameworkCore;

namespace tinder_1
{
    /// <summary>
    /// Класс формы профиля избранного
    /// </summary>
    public partial class ShowProfile : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly Guid _userId;
        private UserProfile _userProfile;

        /// <summary>
        /// Конструктор формы профиля избранного
        /// </summary>
        public ShowProfile(Guid userId)
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _userId = userId;

            _userProfile = _dbContext.UserProfiles
                .Include(up => up.User)
                .Include(up => up.City)
                .Include(up => up.Gender)
                .Include(up => up.Hobby)
                .Include(up => up.BadHabitsAttitude)
                .Include(up => up.FilmGenre)
                .Include(up => up.MusicGenre)
                .FirstOrDefault(up => up.UserId == _userId);

            DisplayProfileData();
            this.CenterToScreen();
        }
        private void DisplayProfileData()
        {
            if (_userProfile == null)
            {
                MessageBox.Show("Профиль не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lbltxtName.Text = _userProfile.Name ?? "Не указано";
            lblName.Text = _userProfile.User?.Login ?? "Не указано";
            lbltxtPhone.Text = _userProfile.PhoneNumber ?? "Не указано";
            dtTimeBirthday.Text = _userProfile.BirthDate?.ToShortDateString() ?? "Не указано";
            lblcmbCity.Text = _userProfile.City?.Name ?? "Не указано";
            lblcmbGender.Text = _userProfile.Gender?.Name ?? "Не указано";
            lblcmbHobbies.Text = _userProfile.Hobby?.Name ?? "Не указано";
            lblcmbBadHab.Text = _userProfile.BadHabitsAttitude?.Name ?? "Не указано";
            lblcmbFilm.Text = _userProfile.FilmGenre?.Name ?? "Не указано";
            lblcmbMusic.Text = _userProfile.MusicGenre?.Name ?? "Не указано";
            lbltxtAboutme.Text = _userProfile.AboutMe ?? "Нет описания";

            Image profileImage = RepeateMethod.ConvertBase64ToImage(_userProfile.PhotoPath);
            if (profileImage != null)
            {
                pctPhoto.Image = profileImage;
                pctPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pctPhoto.Image = null;
            }
        }
    }
}