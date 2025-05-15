using tinder_1.DataBase;
using tinder_1.Models;
using Microsoft.EntityFrameworkCore;
using NLog;

namespace tinder_1
{
    /// <summary>
    /// Класс формы профиля пользователя
    /// </summary>
    public partial class MyProfile : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private Guid _userId;
        private UserProfile _userProfile;
        private bool _isEditMode = false;
        private Image selectedImage = null;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Конструктор формы профиля пользователя
        /// </summary>
        public MyProfile(Guid userId)
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _userId = userId;
            _userProfile = _dbContext.UserProfiles.Include(up => up.User).FirstOrDefault(up => up.UserId == _userId);

            InitializeComboBoxes();
            DisplayUserData();
            SetReadOnlyMode(true);

            this.CenterToScreen();
        }

        private void InitializeComboBoxes()
        {
            cmbCity.DataSource = _dbContext.Cities.ToList();
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "Id";

            cmbGender.DataSource = _dbContext.Genders.ToList();
            cmbGender.DisplayMember = "Name";
            cmbGender.ValueMember = "Id";

            cmbHobbies.DataSource = _dbContext.Hobbies.ToList();
            cmbHobbies.DisplayMember = "Name";
            cmbHobbies.ValueMember = "Id";

            cmbRelationship.DataSource = _dbContext.BadHabitsAttitudes.ToList();
            cmbRelationship.DisplayMember = "Name";
            cmbRelationship.ValueMember = "Id";

            cmbFilm.DataSource = _dbContext.FilmGenres.ToList();
            cmbFilm.DisplayMember = "Name";
            cmbFilm.ValueMember = "Id";

            cmbMusic.DataSource = _dbContext.MusicGenres.ToList();
            cmbMusic.DisplayMember = "Name";
            cmbMusic.ValueMember = "Id";
        }

        private void DisplayUserData()
        {
            if (_userProfile == null)
            {
                return;
            }

            txtName.Text = _userProfile.Name ?? string.Empty;
            txtLogin.Text = _userProfile.User?.Login ?? string.Empty;
            txtPhoneNumber.Text = _userProfile.PhoneNumber ?? string.Empty;

            if (_userProfile.CityId.HasValue)
            {
                cmbCity.SelectedValue = _userProfile.CityId.Value;
            }
            if (_userProfile.BirthDate.HasValue)
            {
                dtTimeBirthday.Value = _userProfile.BirthDate.Value;
            }
            else
            {
                dtTimeBirthday.Value = DateTime.Now.AddYears(-18);
            }
            if (_userProfile.GenderId.HasValue)
            {
                cmbGender.SelectedValue = _userProfile.GenderId.Value;
            }

            txtAboutMe.Text = _userProfile.AboutMe ?? string.Empty;

            if (_userProfile.HobbyId.HasValue)
            {
                cmbHobbies.SelectedValue = _userProfile.HobbyId.Value;
            }
            if (_userProfile.BadHabitsAttitudeId.HasValue)
            {
                cmbRelationship.SelectedValue = _userProfile.BadHabitsAttitudeId.Value;
            }
            if (_userProfile.FilmGenreId.HasValue)
            {
                cmbFilm.SelectedValue = _userProfile.FilmGenreId.Value;
            }
            if (_userProfile.MusicGenreId.HasValue)
            {
                cmbMusic.SelectedValue = _userProfile.MusicGenreId.Value;
            }
            if (!string.IsNullOrEmpty(_userProfile.PhotoPath))
            {
                byte[] imageBytes = Convert.FromBase64String(_userProfile.PhotoPath);
                MemoryStream ms = new MemoryStream(imageBytes);
                Image img = Image.FromStream(ms);
                pctPhoto.Image = img;
                pctPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void SaveProfile()
        {
            try
            {
                if (_userProfile == null)
                {
                    MessageBox.Show("Профиль пользователя не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _userProfile.GenderId = (Guid)cmbGender.SelectedValue;
                _userProfile.CityId = (Guid)cmbCity.SelectedValue;
                _userProfile.BadHabitsAttitudeId = (Guid)cmbRelationship.SelectedValue;
                _userProfile.MusicGenreId = (Guid)cmbMusic.SelectedValue;
                _userProfile.FilmGenreId = (Guid)cmbFilm.SelectedValue;
                _userProfile.HobbyId = (Guid)cmbHobbies.SelectedValue;
                _userProfile.AboutMe = txtAboutMe.Text;
                _userProfile.Name = txtName.Text;
                _userProfile.PhoneNumber = txtPhoneNumber.Text;
                _userProfile.User.Login = txtLogin.Text;

                if (selectedImage != null)
                {
                    MemoryStream ms = new MemoryStream();
                    selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageBytes = ms.ToArray();
                    _userProfile.PhotoPath = Convert.ToBase64String(imageBytes);
                }

                _dbContext.SaveChanges();
                selectedImage = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении аккаунта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetReadOnlyMode(bool readOnly)
        {
            txtName.ReadOnly = readOnly;
            txtLogin.ReadOnly = readOnly;
            txtPhoneNumber.ReadOnly = readOnly;
            cmbCity.Enabled = !readOnly;
            dtTimeBirthday.Enabled = !readOnly;
            cmbGender.Enabled = !readOnly;
            txtAboutMe.ReadOnly = readOnly;
            cmbHobbies.Enabled = !readOnly;
            cmbRelationship.Enabled = !readOnly;
            cmbFilm.Enabled = !readOnly;
            cmbMusic.Enabled = !readOnly;
            btnUpdatePhoto.Visible = !readOnly;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdatePhoto_Click(object sender, EventArgs e)
        {
            RepeateMethod.LoadImage(pctPhoto);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowMyLike_Click(object sender, EventArgs e)
        {
            
        }
    }
}