using NLog;
using System.Data;
using System.Text.RegularExpressions;
using tinder_1.DataBase;
using tinder_1.Models;

namespace tinder_1
{
    /// <summary>
    /// класс формы анкета1
    /// </summary>
    public partial class Questionnary : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private Guid _userId;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// конструктор формы анкета1
        /// </summary>
        public Questionnary(Guid userId)
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            dateTimePicker1.Value = DateTime.Now.AddYears(-18);

            LoadGenders();
            LoadCities();
            this.CenterToScreen(); 
            _userId = userId;
        }
        private void LoadGenders()
        {
            var gengers = _dbContext.Genders.
                     Select(e => e.Name).
                     Distinct().
                     OrderBy(g => g).
                     ToArray();


            cmbSex.Items.AddRange(gengers);
        }
        private void LoadCities()
        {
            var cities = _dbContext.Cities.
                     Select(e => e.Name).
                     Distinct().
                     OrderBy(g => g).
                     ToArray();

            cmbCity.Items.AddRange(cities);
        }

        private bool CheckName(string name)
        {
            if (string.IsNullOrEmpty(name) || !char.IsUpper(name[0]))
            {
                return false;
            }

            foreach (char character in name)
            {
                if (!char.IsLetter(character))
                { 
                    return false;
                }
            }

            return true;
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {  
                return; 
            }
            try
            {
                SaveProfile();
                logger.Info("Пользователь заполняет данные");

                var nextForm = new Questionnary2(_userId);
                nextForm.Show();
                this.Hide();
                logger.Info("Пользователь переходит на вторую форму анкеты");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckForm()
        {
            
            string name = txtName.Text;
            DateTime minDate = DateTime.Now.AddYears(-18);
            string phone = txtPhone.Text;
            bool isValid = true;
            if (cmbCity.Text== string.Empty||cmbSex.Text== string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            if (name == string.Empty || phone== string.Empty)
            {
                txtPhone.BackColor = Color.LightPink;
                txtName.BackColor = Color.LightPink;
                isValid = false;
            }
            if (name != string.Empty)
            {
                if (!CheckName(name))
                {
                    MessageBox.Show("Имя должно начинаться с большой буквы и содержать только буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isValid = false;
                }
            }
            if (!Regex.IsMatch(phone,@"^((\+7|7|8)+([0-9]){10})$" ))
            {
                MessageBox.Show("Номер телефона должен содержать ровно 11 цифр и начинаться с 7/+7/8!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            if (dateTimePicker1.Value > minDate)
            {
                MessageBox.Show("Вам должно быть не менее 18 лет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (picbPhoto.Image == null)
            {
                picbPhoto.BackColor = Color.LightPink;
                isValid = false;
            }


            return isValid;
        }
        private string ConvertImage(Image selectedImage)
        {
            string photoBase64 = null;
            if (selectedImage != null)
            {
                MemoryStream ms = new MemoryStream();
                selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                photoBase64 = Convert.ToBase64String(imageBytes);
                ms.Dispose();
            }
            return photoBase64;

        }

        private void SaveProfile()
        {
            Guid? genderId = _dbContext.Genders.FirstOrDefault(gender => gender.Name == cmbSex.Text)?.Id;
            Guid? cityId = _dbContext.Cities.FirstOrDefault(city => city.Name == cmbCity.Text)?.Id;


            var user1 = new UserProfile
            {
                UserId = _userId,
                Name = txtName.Text,
                PhoneNumber = txtPhone.Text,
                GenderId = genderId,
                BirthDate = dateTimePicker1.Value.ToUniversalTime(),
                CityId = cityId,
                PhotoPath = ConvertImage(picbPhoto.Image)
            };
            _dbContext.UserProfiles.Add(user1);
            _dbContext.SaveChanges();

        }

        private void btnDownloadPhoto_Click(object sender, EventArgs e)
        {
             RepeateMethod.LoadImage(picbPhoto);
        }
    }
}