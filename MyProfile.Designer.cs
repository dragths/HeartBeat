namespace tinder_1
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            txtName = new TextBox();
            pctPhoto = new PictureBox();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblCity = new Label();
            lblGender = new Label();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblDateBirthday = new Label();
            dtTimeBirthday = new DateTimePicker();
            lblHobbies = new Label();
            cmbHobbies = new ComboBox();
            cmbRelationship = new ComboBox();
            lblRelationship = new Label();
            lblFilm = new Label();
            lblMusic = new Label();
            cmbFilm = new ComboBox();
            cmbMusic = new ComboBox();
            lblAboutMe = new Label();
            txtAboutMe = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnShowMyLike = new Button();
            cmbCity = new ComboBox();
            cmbGender = new ComboBox();
            btnUpdatePhoto = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(204, 216, 255);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.Location = new Point(341, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 31);
            txtName.TabIndex = 0;
            // 
            // pctPhoto
            // 
            pctPhoto.BackColor = Color.FromArgb(204, 216, 255);
            pctPhoto.Location = new Point(12, 12);
            pctPhoto.Name = "pctPhoto";
            pctPhoto.Size = new Size(238, 199);
            pctPhoto.TabIndex = 1;
            pctPhoto.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLogin.Location = new Point(270, 59);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(58, 23);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(204, 216, 255);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Location = new Point(270, 85);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(213, 27);
            txtLogin.TabIndex = 3;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCity.Location = new Point(271, 115);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(57, 23);
            lblCity.TabIndex = 4;
            lblCity.Text = "Город";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblGender.Location = new Point(271, 168);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(41, 23);
            lblGender.TabIndex = 6;
            lblGender.Text = "Пол";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.Transparent;
            lblPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPhoneNumber.Location = new Point(542, 59);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(143, 23);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Номер телефона";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(204, 216, 255);
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Location = new Point(542, 85);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(214, 27);
            txtPhoneNumber.TabIndex = 9;
            // 
            // lblDateBirthday
            // 
            lblDateBirthday.AutoSize = true;
            lblDateBirthday.BackColor = Color.Transparent;
            lblDateBirthday.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDateBirthday.Location = new Point(542, 115);
            lblDateBirthday.Name = "lblDateBirthday";
            lblDateBirthday.Size = new Size(132, 23);
            lblDateBirthday.TabIndex = 11;
            lblDateBirthday.Text = "Дата рождения";
            // 
            // dtTimeBirthday
            // 
            dtTimeBirthday.CalendarMonthBackground = Color.FromArgb(192, 192, 255);
            dtTimeBirthday.Location = new Point(542, 141);
            dtTimeBirthday.Name = "dtTimeBirthday";
            dtTimeBirthday.Size = new Size(214, 27);
            dtTimeBirthday.TabIndex = 12;
            // 
            // lblHobbies
            // 
            lblHobbies.AutoSize = true;
            lblHobbies.BackColor = Color.Transparent;
            lblHobbies.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHobbies.Location = new Point(12, 245);
            lblHobbies.Name = "lblHobbies";
            lblHobbies.Size = new Size(95, 23);
            lblHobbies.TabIndex = 13;
            lblHobbies.Text = "Увлечения";
            // 
            // cmbHobbies
            // 
            cmbHobbies.BackColor = Color.FromArgb(204, 216, 255);
            cmbHobbies.FormattingEnabled = true;
            cmbHobbies.Location = new Point(12, 268);
            cmbHobbies.Name = "cmbHobbies";
            cmbHobbies.Size = new Size(286, 28);
            cmbHobbies.TabIndex = 14;
            // 
            // cmbRelationship
            // 
            cmbRelationship.BackColor = Color.FromArgb(204, 216, 255);
            cmbRelationship.FormattingEnabled = true;
            cmbRelationship.Location = new Point(12, 325);
            cmbRelationship.Name = "cmbRelationship";
            cmbRelationship.Size = new Size(286, 28);
            cmbRelationship.TabIndex = 15;
            // 
            // lblRelationship
            // 
            lblRelationship.AutoSize = true;
            lblRelationship.BackColor = Color.Transparent;
            lblRelationship.Font = new Font("Segoe UI", 10F);
            lblRelationship.Location = new Point(12, 299);
            lblRelationship.Name = "lblRelationship";
            lblRelationship.Size = new Size(286, 23);
            lblRelationship.TabIndex = 16;
            lblRelationship.Text = "Отношение к вредным привычкам";
            // 
            // lblFilm
            // 
            lblFilm.AutoSize = true;
            lblFilm.BackColor = Color.Transparent;
            lblFilm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFilm.Location = new Point(12, 356);
            lblFilm.Name = "lblFilm";
            lblFilm.Size = new Size(212, 23);
            lblFilm.TabIndex = 17;
            lblFilm.Text = "Любимый жанр фильмов";
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.BackColor = Color.Transparent;
            lblMusic.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMusic.Location = new Point(12, 413);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(199, 23);
            lblMusic.TabIndex = 18;
            lblMusic.Text = "Любимый жанр музыки";
            // 
            // cmbFilm
            // 
            cmbFilm.BackColor = Color.FromArgb(204, 216, 255);
            cmbFilm.FormattingEnabled = true;
            cmbFilm.Location = new Point(12, 382);
            cmbFilm.Name = "cmbFilm";
            cmbFilm.Size = new Size(286, 28);
            cmbFilm.TabIndex = 19;
            // 
            // cmbMusic
            // 
            cmbMusic.BackColor = Color.FromArgb(204, 216, 255);
            cmbMusic.FormattingEnabled = true;
            cmbMusic.Location = new Point(12, 439);
            cmbMusic.Name = "cmbMusic";
            cmbMusic.Size = new Size(286, 28);
            cmbMusic.TabIndex = 20;
            // 
            // lblAboutMe
            // 
            lblAboutMe.AutoSize = true;
            lblAboutMe.BackColor = Color.Transparent;
            lblAboutMe.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAboutMe.Location = new Point(341, 245);
            lblAboutMe.Name = "lblAboutMe";
            lblAboutMe.Size = new Size(89, 23);
            lblAboutMe.TabIndex = 21;
            lblAboutMe.Text = "Описание";
            // 
            // txtAboutMe
            // 
            txtAboutMe.BackColor = Color.FromArgb(204, 216, 255);
            txtAboutMe.BorderStyle = BorderStyle.None;
            txtAboutMe.Location = new Point(341, 268);
            txtAboutMe.MaximumSize = new Size(700, 700);
            txtAboutMe.MinimumSize = new Size(200, 100);
            txtAboutMe.Multiline = true;
            txtAboutMe.Name = "txtAboutMe";
            txtAboutMe.Size = new Size(415, 199);
            txtAboutMe.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 98, 98);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(12, 500);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(199, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Удалить аккаунт";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(100, 174, 131);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(270, 500);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(199, 29);
            btnEdit.TabIndex = 24;
            btnEdit.Text = "Редактировать ";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnShowMyLike
            // 
            btnShowMyLike.BackColor = Color.FromArgb(171, 87, 213);
            btnShowMyLike.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowMyLike.FlatAppearance.BorderSize = 0;
            btnShowMyLike.FlatStyle = FlatStyle.Flat;
            btnShowMyLike.Location = new Point(607, 500);
            btnShowMyLike.Name = "btnShowMyLike";
            btnShowMyLike.Size = new Size(228, 29);
            btnShowMyLike.TabIndex = 25;
            btnShowMyLike.Text = "Мои избранные";
            btnShowMyLike.UseVisualStyleBackColor = false;
            btnShowMyLike.Click += btnShowMyLike_Click;
            // 
            // cmbCity
            // 
            cmbCity.BackColor = Color.FromArgb(204, 216, 255);
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(271, 137);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(213, 28);
            cmbCity.TabIndex = 26;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(204, 216, 255);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(271, 194);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(213, 28);
            cmbGender.TabIndex = 27;
            // 
            // btnUpdatePhoto
            // 
            btnUpdatePhoto.BackColor = Color.FromArgb(192, 192, 255);
            btnUpdatePhoto.FlatStyle = FlatStyle.Popup;
            btnUpdatePhoto.Location = new Point(12, 217);
            btnUpdatePhoto.Name = "btnUpdatePhoto";
            btnUpdatePhoto.Size = new Size(237, 25);
            btnUpdatePhoto.TabIndex = 28;
            btnUpdatePhoto.Text = "Обновить фото";
            btnUpdatePhoto.UseVisualStyleBackColor = false;
            btnUpdatePhoto.Click += btnUpdatePhoto_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.Location = new Point(808, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(44, 37);
            btnBack.TabIndex = 29;
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(864, 551);
            Controls.Add(btnBack);
            Controls.Add(btnUpdatePhoto);
            Controls.Add(cmbGender);
            Controls.Add(cmbCity);
            Controls.Add(btnShowMyLike);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(txtAboutMe);
            Controls.Add(lblAboutMe);
            Controls.Add(cmbMusic);
            Controls.Add(cmbFilm);
            Controls.Add(lblMusic);
            Controls.Add(lblFilm);
            Controls.Add(lblRelationship);
            Controls.Add(cmbRelationship);
            Controls.Add(cmbHobbies);
            Controls.Add(lblHobbies);
            Controls.Add(dtTimeBirthday);
            Controls.Add(lblDateBirthday);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblGender);
            Controls.Add(lblCity);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(pctPhoto);
            Controls.Add(txtName);
            Name = "MyProfile";
            Text = "Мой профиль";
            ((System.ComponentModel.ISupportInitialize)pctPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private PictureBox pctPhoto;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblCity;
        private Label lblGender;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblDateBirthday;
        private DateTimePicker dtTimeBirthday;
        private Label lblHobbies;
        private ComboBox cmbHobbies;
        private ComboBox cmbRelationship;
        private Label lblRelationship;
        private Label lblFilm;
        private Label lblMusic;
        private ComboBox cmbFilm;
        private ComboBox cmbMusic;
        private Label lblAboutMe;
        private TextBox txtAboutMe;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnShowMyLike;
        private ComboBox cmbCity;
        private ComboBox cmbGender;
        private Button btnUpdatePhoto;
        private Button btnBack;
    }
}