namespace tinder_1
{
    partial class Questionnary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questionnary));
            lblQuestion = new Label();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            picbPhoto = new PictureBox();
            btnDownloadPhoto = new Button();
            txtName = new TextBox();
            cmbSex = new ComboBox();
            cmbCity = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lblName = new Label();
            lblSex = new Label();
            lblDate = new Label();
            lblCity = new Label();
            btnFollow = new Button();
            txtPhone = new TextBox();
            lblNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)picbPhoto).BeginInit();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.FlatStyle = FlatStyle.Popup;
            lblQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblQuestion.Location = new Point(271, 27);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(266, 31);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Давайте познакомимся!";
            // 
            // picbPhoto
            // 
            picbPhoto.AccessibleName = "";
            picbPhoto.BackColor = Color.FromArgb(204, 216, 255);
            picbPhoto.BorderStyle = BorderStyle.FixedSingle;
            picbPhoto.Location = new Point(28, 72);
            picbPhoto.Name = "picbPhoto";
            picbPhoto.Size = new Size(338, 299);
            picbPhoto.TabIndex = 15;
            picbPhoto.TabStop = false;
            // 
            // btnDownloadPhoto
            // 
            btnDownloadPhoto.BackColor = Color.FromArgb(192, 192, 255);
            btnDownloadPhoto.FlatStyle = FlatStyle.Popup;
            btnDownloadPhoto.Location = new Point(85, 377);
            btnDownloadPhoto.Name = "btnDownloadPhoto";
            btnDownloadPhoto.Size = new Size(220, 28);
            btnDownloadPhoto.TabIndex = 16;
            btnDownloadPhoto.Text = "Нажмите, чтобы загрузить ";
            btnDownloadPhoto.UseVisualStyleBackColor = false;
            btnDownloadPhoto.Click += btnDownloadPhoto_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(204, 216, 255);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(441, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 27);
            txtName.TabIndex = 20;
            // 
            // cmbSex
            // 
            cmbSex.BackColor = Color.FromArgb(204, 216, 255);
            cmbSex.FlatStyle = FlatStyle.Flat;
            cmbSex.FormattingEnabled = true;
            cmbSex.Location = new Point(441, 159);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(255, 28);
            cmbSex.TabIndex = 21;
            // 
            // cmbCity
            // 
            cmbCity.BackColor = Color.FromArgb(204, 216, 255);
            cmbCity.FlatStyle = FlatStyle.Flat;
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(441, 276);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(255, 28);
            cmbCity.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Plum;
            dateTimePicker1.BackColor = Color.FromArgb(195, 195, 255);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(192, 192, 255);
            dateTimePicker1.Location = new Point(441, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblName.Location = new Point(441, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(47, 25);
            lblName.TabIndex = 25;
            lblName.Text = "Имя";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.BackColor = Color.Transparent;
            lblSex.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSex.Location = new Point(441, 131);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(45, 25);
            lblSex.TabIndex = 26;
            lblSex.Text = "Пол";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDate.Location = new Point(441, 190);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(137, 25);
            lblDate.TabIndex = 27;
            lblDate.Text = "Дата рождения";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCity.Location = new Point(441, 248);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(63, 25);
            lblCity.TabIndex = 28;
            lblCity.Text = "Город";
            // 
            // btnFollow
            // 
            btnFollow.BackColor = Color.FromArgb(192, 192, 255);
            btnFollow.FlatStyle = FlatStyle.Popup;
            btnFollow.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnFollow.Location = new Point(501, 418);
            btnFollow.Name = "btnFollow";
            btnFollow.Size = new Size(227, 29);
            btnFollow.TabIndex = 29;
            btnFollow.Text = "Нажмите, чтобы продолжить";
            btnFollow.UseVisualStyleBackColor = false;
            btnFollow.Click += btnFollow_Click;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(204, 216, 255);
            txtPhone.Location = new Point(441, 344);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(255, 27);
            txtPhone.TabIndex = 30;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.Transparent;
            lblNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNumber.Location = new Point(441, 316);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(150, 25);
            lblNumber.TabIndex = 31;
            lblNumber.Text = "Номер телефона";
            // 
            // Questionnary
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(817, 496);
            Controls.Add(lblNumber);
            Controls.Add(txtPhone);
            Controls.Add(btnFollow);
            Controls.Add(lblCity);
            Controls.Add(lblDate);
            Controls.Add(lblSex);
            Controls.Add(lblName);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbCity);
            Controls.Add(cmbSex);
            Controls.Add(txtName);
            Controls.Add(btnDownloadPhoto);
            Controls.Add(picbPhoto);
            Controls.Add(lblQuestion);
            Name = "Questionnary";
            Text = "Анкета";
            ((System.ComponentModel.ISupportInitialize)picbPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private PictureBox picbPhoto;
        private Button btnDownloadPhoto;
        private TextBox txtName;
        private ComboBox cmbSex;
        private ComboBox cmbCity;
        private DateTimePicker dateTimePicker1;
        private Label lblName;
        private Label lblSex;
        private Label lblDate;
        private Label lblCity;
        private Button btnFollow;
        private TextBox txtPhone;
        private Label lblNumber;
    }
}