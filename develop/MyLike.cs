using tinder_1.Models;
using Microsoft.EntityFrameworkCore;
using tinder_1.DataBase;
using NLog;
namespace tinder_1
{
    /// <summary>
    /// класс списка избранных
    /// </summary>
    public partial class MyLike : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly Guid _userId;
        private List<Favorites> _favorites;
        private List<UserProfile> _favoriteProfiles;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// конструктор списка избранных
        /// </summary>
        public MyLike(Guid userId)
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _userId = userId;


            tableLayoutPanel.RowCount = 0;
            tableLayoutPanel.RowStyles.Clear();
        }

        private void MyLike_Load(object sender, EventArgs e)
        {
            LoadFavoriteProfiles();
            DisplayFavoriteProfiles();
        }

        private void LoadFavoriteProfiles()
        {
            _favorites = _dbContext.FavoriteProfiles.Where(f => f.UserId == _userId).ToList();
            _favoriteProfiles = _dbContext.UserProfiles.Include(p => p.City).Where(p => _favorites.Select(f => f.FavoriteUserId).Contains(p.UserId)).ToList();
        }

        private void DisplayFavoriteProfiles()
        {
            {
                tableLayoutPanel.Controls.Clear();
                tableLayoutPanel.RowCount = 0;

                if (!_favoriteProfiles.Any())
                {
                    MessageBox.Show("У вас нет избранных анкет.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var profile in _favoriteProfiles)
                {
                    var card = CreateProfileCard(profile);
                    tableLayoutPanel.RowCount++;
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
                    tableLayoutPanel.Controls.Add(card, 0, tableLayoutPanel.RowCount - 1);
                }
            }
        }

        private Panel CreateProfileCard(UserProfile profile)
        {
            var cardPanel = CreateProfileCardTemplate();

            var pctPhoto = (PictureBox)cardPanel.Controls[0];
            var lblName = (Label)cardPanel.Controls[1];
            var lblAge = (Label)cardPanel.Controls[2];
            var lblCity = (Label)cardPanel.Controls[3];
            var btnShowProfile = (Button)cardPanel.Controls[4];
            var btnDelete = (Button)cardPanel.Controls[5];

            LoadProfileImage(pctPhoto, profile.PhotoPath);

            lblName.Text = profile.Name ?? "Без имени";
            lblAge.Text = $"Возраст: {RepeateMethod.CalculateAge(profile.BirthDate)}";
            lblCity.Text = $"Город: {profile.City?.Name ?? "Не указан"}";

            btnShowProfile.Click += (s, e) => ViewProfile(profile.UserId);
            logger.Info("Пользователь переходит на форму просмотра профиля избранного пользователя");
            btnDelete.Click += (s, e) => DeleteFavorite(profile.UserId);
            logger.Info("Пользователь удаляет из избранных пользователя");

            return cardPanel;
        }

        private void LoadProfileImage(PictureBox pictureBox, string photoPath)
        {
            Image profileImage = RepeateMethod.ConvertBase64ToImage(photoPath);
            if (profileImage != null)
            {
                pictureBox.Image = profileImage;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox.Image = null;
            }
        }
        private void ViewProfile(Guid profileId)
        {
            var profileForm = new ShowProfile(profileId);
            profileForm.Show();
        }

        private void DeleteFavorite(Guid favoriteUserId)
        {
            try
            {
                var favorite = _dbContext.FavoriteProfiles.FirstOrDefault(f => f.FavoriteUserId == favoriteUserId && f.UserId == _userId);

                if (favorite != null)
                {
                    _dbContext.FavoriteProfiles.Remove(favorite);
                    _dbContext.SaveChanges();

                    _favorites = _dbContext.FavoriteProfiles.Where(f => f.UserId == _userId).ToList();
                    _favoriteProfiles = _dbContext.UserProfiles.Include(p => p.City).Where(p => _favorites.Select(f => f.FavoriteUserId).Contains(p.UserId)).ToList();

                    DisplayFavoriteProfiles();

                    MessageBox.Show("Анкета удалена из избранного!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var nextForm = new MyProfile(_userId);
            nextForm.Show();
            this.Close();
            logger.Info("Пользователь переходит на форму просмотра своего профиля ");
        }
    }
}