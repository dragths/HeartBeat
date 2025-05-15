using Microsoft.EntityFrameworkCore;
using NLog;
using tinder_1.DataBase;
using tinder_1.Models;

namespace tinder_1
{
    /// <summary>
    /// класс главной формы
    /// </summary>
    public partial class MainWindow : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private Guid _userId;
        private UserProfile _userProfile;
        private List<UserProfile> _recommendedProfiles;
        private int _currentProfileIndex = 0;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// конструктор главной формы
        /// </summary>
        public MainWindow(Guid userId)
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _userId = userId;
            _userProfile = _dbContext.UserProfiles.FirstOrDefault(up => up.UserId == _userId);

            LoadRecommendations();
            if (_recommendedProfiles != null && _recommendedProfiles.Count > 0)
            {
                DisplayProfile(_recommendedProfiles[0]);
            }
            else
            {
                pctPhoto.Image = null;
                lblName.Text = string.Empty;
                lblcmbHobbies.Text = string.Empty;
                lblBadHab.Text = string.Empty;
                lblMusic.Text = string.Empty;
                lblcmbFilm.Text = string.Empty;
                lbltxtAboutme.Text = string.Empty;
                MessageBox.Show("Нет доступных рекомендаций.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.CenterToScreen();
        }

        private void LoadRecommendations()
        {
            var allProfiles = _dbContext.UserProfiles
                .Include(up => up.User)
                .Include(up => up.Gender)
                .Include(up => up.City)
                .Include(up => up.Hobby)
                .Include(up => up.MusicGenre)
                .Include(up => up.FilmGenre)
                .Include(up => up.BadHabitsAttitude)
                .Where(up => up.UserId != _userId)
                .ToList();

            var favoriteProfiles = _dbContext.FavoriteProfiles.Where(f => f.UserId == _userId).Select(f => f.FavoriteUserId).ToList();

            var favoriteUserProfiles = _dbContext.UserProfiles
                .Include(up => up.User)
                .Include(up => up.Gender)
                .Include(up => up.City)
                .Include(up => up.Hobby)
                .Include(up => up.MusicGenre)
                .Include(up => up.FilmGenre)
                .Include(up => up.BadHabitsAttitude)
                .Where(up => favoriteProfiles.Contains(up.UserId))
                .ToList();

            var favoriteCities = favoriteUserProfiles.Select(up => up.CityId).Distinct().ToList();
            var favoriteHobbies = favoriteUserProfiles.Select(up => up.HobbyId).Distinct().ToList();
            var favoriteBadHabits = favoriteUserProfiles.Select(up => up.BadHabitsAttitudeId).Distinct().ToList();
            var favoriteFilmGenres = favoriteUserProfiles.Select(up => up.FilmGenreId).Distinct().ToList();
            var favoriteMusicGenres = favoriteUserProfiles.Select(up => up.MusicGenreId).Distinct().ToList();

            var oppositeGenderProfiles = allProfiles.Where(up => up.GenderId != _userProfile.GenderId && !favoriteProfiles.Contains(up.UserId)).ToList();

            var additionalProfiles = allProfiles
                .Where(up => (favoriteCities.Contains(up.CityId) ||
                              favoriteHobbies.Contains(up.HobbyId) ||
                              favoriteBadHabits.Contains(up.BadHabitsAttitudeId) ||
                              favoriteFilmGenres.Contains(up.FilmGenreId) ||
                              favoriteMusicGenres.Contains(up.MusicGenreId)) &&
                              up.UserId != _userId &&
                              !favoriteProfiles.Contains(up.UserId) &&
                              up.GenderId != _userProfile.GenderId) 
                .ToList();

            var combinedProfiles = oppositeGenderProfiles .Concat(additionalProfiles).GroupBy(up => up.UserId).Select(g => g.First()).ToList();

            _recommendedProfiles = combinedProfiles
                .OrderByDescending(up => CalculateMatchScore(up, favoriteProfiles.Contains(up.UserId), favoriteCities, favoriteHobbies, favoriteBadHabits, favoriteFilmGenres, favoriteMusicGenres))
                .ToList();
        }

        private int CalculateMatchScore(UserProfile profile, bool isFavorite, List<Guid?> favoriteCities, List<Guid?> favoriteHobbies, List<Guid?> favoriteBadHabits, List<Guid?> favoriteFilmGenres, List<Guid?> favoriteMusicGenres)
        {
            int score = 0;

            if (_userProfile.CityId == profile.CityId)
            {
                score += 1;
            }
            if (_userProfile.HobbyId == profile.HobbyId)
            {
                score += 1;
            }
            if (_userProfile.BadHabitsAttitudeId == profile.BadHabitsAttitudeId)
            {
                score += 1;
            }
            if (_userProfile.FilmGenreId == profile.FilmGenreId)
            {
                score += 1;
            }
            if (_userProfile.MusicGenreId == profile.MusicGenreId)
            {
                score += 1;
            }

            if (favoriteCities != null && favoriteCities.Contains(profile.CityId))
            {
                score += 2;
            }
            if (favoriteHobbies != null && favoriteHobbies.Contains(profile.HobbyId))
            {
                score += 2;
            }
            if (favoriteBadHabits != null && favoriteBadHabits.Contains(profile.BadHabitsAttitudeId))
            {
                score += 2;
            }
            if (favoriteFilmGenres != null && favoriteFilmGenres.Contains(profile.FilmGenreId))
            {
                score += 2;
            }
            if (favoriteMusicGenres != null && favoriteMusicGenres.Contains(profile.MusicGenreId))
            {
                score += 2;
            }

            return score;
        }

        private void DisplayProfile(UserProfile profile)
        {
            DisplayProfileTab(profile);
            DisplayDetailsTab(profile);
        }

        private void DisplayDetailsTab(UserProfile profile)
        {
            lblcmbHobbies.Text = profile.Hobby?.Name ?? "Не указано";
            lblBadHab.Text = profile.BadHabitsAttitude?.Name ?? "Не указано";
            lblMusic.Text = profile.MusicGenre?.Name ?? "Не указано";
            lblcmbFilm.Text = profile.FilmGenre?.Name ?? "Не указано";
            lbltxtAboutme.Text = profile.AboutMe ?? "Не указано";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_recommendedProfiles.Count == 0)
            {
                return;
            }

            _currentProfileIndex++;
            if (_currentProfileIndex < _recommendedProfiles.Count)
            {
                DisplayProfile(_recommendedProfiles[_currentProfileIndex]);
                logger.Info("Пользователь пролистывает следующий профиль");
            }
            else
            {
                _currentProfileIndex = _recommendedProfiles.Count;
                pctPhoto.Image = null;
                lblName.Text = string.Empty;
                lblcmbHobbies.Text = string.Empty;
                lblBadHab.Text = string.Empty;
                lblMusic.Text = string.Empty;
                lblcmbFilm.Text = string.Empty;
                lbltxtAboutme.Text = string.Empty;
                MessageBox.Show("Больше нет доступных рекомендаций.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            try
            {
                if (_recommendedProfiles.Count == 0)
                {
                    return;
                }

                var currentProfile = _recommendedProfiles[_currentProfileIndex];
                var existingFavorite = _dbContext.FavoriteProfiles.Any(f => f.UserId == _userId && f.FavoriteUserId == currentProfile.UserId);

                if (!existingFavorite)
                {
                    var newFavorite = new Favorites
                    {
                        Id = Guid.NewGuid(),
                        UserId = _userId,
                        FavoriteUserId = currentProfile.UserId
                    };

                    _dbContext.FavoriteProfiles.Add(newFavorite);
                    _dbContext.SaveChanges();
                    logger.Info("Пользователь добавляет профиль в избранные");

                    MessageBox.Show("Профиль добавлен в избранное!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _recommendedProfiles.RemoveAt(_currentProfileIndex);

                    if (_recommendedProfiles.Count > 0)
                    {
                        _currentProfileIndex = _currentProfileIndex % _recommendedProfiles.Count;
                        DisplayProfile(_recommendedProfiles[_currentProfileIndex]);
                    }
                    else
                    {
                        pctPhoto.Image = null;
                        lblName.Text = string.Empty;
                        lblcmbHobbies.Text = string.Empty;
                        lblBadHab.Text = string.Empty;
                        lblMusic.Text = string.Empty;
                        lblcmbFilm.Text = string.Empty;
                        lbltxtAboutme.Text = string.Empty;
                        MessageBox.Show("Больше нет доступных рекомендаций.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Этот профиль уже добавлен в избранное!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка добавления профиля в избранные: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void DisplayProfileTab(UserProfile profile)
        {
            lblName.Text = $"{profile.Name}, {RepeateMethod.CalculateAge(profile.BirthDate)}, {profile.City?.Name ?? "Город не указан"}";
            var profileImage = RepeateMethod.ConvertBase64ToImage(profile.PhotoPath);
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

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            var nextForm = new MyProfile(_userId);
            nextForm.Show();
            this.Hide();
            logger.Info("Пользователь переходит на форму просмотра своего профиля");
        }
    }
}