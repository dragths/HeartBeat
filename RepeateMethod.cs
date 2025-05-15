using System.Security.Cryptography;
using System.Text;

namespace tinder_1
{
    /// <summary>
    /// повтор методов
    /// </summary>
    public static class RepeateMethod
    {
        /// <summary>
        /// хэширование
        /// </summary>
        public static string Hashing(string password)
        {
            using MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(hash);
        }

        /// <summary>
        /// загрузка изображений
        /// </summary>
        public static void LoadImage(PictureBox pictureBox)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(dialog.FileName);
                pictureBox.Image = selectedImage;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// Калькулятор возраста
        /// </summary>
        public static int CalculateAge(DateTime? birthDate)
        {
            if (!birthDate.HasValue)
            {
                return 0;
            }
            var age = DateTime.Today.Year - birthDate.Value.Year;
            if (birthDate.Value.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        /// <summary>
        /// перевод из Byte64 в изображение
        /// </summary>
        public static Image ConvertBase64ToImage(string base64String)
        {
            if (string.IsNullOrEmpty(base64String))
            {
                return null;
            }

            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using MemoryStream ms = new MemoryStream(imageBytes);
                return Image.FromStream(ms);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Показ пароля
        /// </summary>
        public static void TogglePasswordVisibility(TextBox textBoxPassword, bool isVisible)
        {
            if (isVisible)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
            textBoxPassword.Refresh();
        }
    }
}