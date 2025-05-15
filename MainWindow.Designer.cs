namespace tinder_1
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            lblName = new Label();
            pctPhoto = new PictureBox();
            tabPage2 = new TabPage();
            lbltxtAboutme = new Label();
            lblAboutme = new Label();
            lblcmbFilm = new Label();
            lblFilm = new Label();
            lblMusic = new Label();
            lblMusicGenre = new Label();
            lblBadHab = new Label();
            lblBadHabbits = new Label();
            lblcmbHobbies = new Label();
            lblHobbies = new Label();
            pctColor = new PictureBox();
            btnNext = new Button();
            btnLike = new Button();
            btnShowProfile = new Button();
            label1 = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctColor).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(277, 92);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(431, 471);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblName);
            tabPage1.Controls.Add(pctPhoto);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(423, 435);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Профиль";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblName.Location = new Point(28, 407);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // pctPhoto
            // 
            pctPhoto.BackColor = Color.WhiteSmoke;
            pctPhoto.Location = new Point(28, 15);
            pctPhoto.Name = "pctPhoto";
            pctPhoto.Size = new Size(371, 389);
            pctPhoto.TabIndex = 0;
            pctPhoto.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(lbltxtAboutme);
            tabPage2.Controls.Add(lblAboutme);
            tabPage2.Controls.Add(lblcmbFilm);
            tabPage2.Controls.Add(lblFilm);
            tabPage2.Controls.Add(lblMusic);
            tabPage2.Controls.Add(lblMusicGenre);
            tabPage2.Controls.Add(lblBadHab);
            tabPage2.Controls.Add(lblBadHabbits);
            tabPage2.Controls.Add(lblcmbHobbies);
            tabPage2.Controls.Add(lblHobbies);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(423, 438);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Подробнее";
            // 
            // lbltxtAboutme
            // 
            lbltxtAboutme.AutoSize = true;
            lbltxtAboutme.BackColor = Color.FromArgb(192, 192, 255);
            lbltxtAboutme.BorderStyle = BorderStyle.Fixed3D;
            lbltxtAboutme.Location = new Point(27, 189);
            lbltxtAboutme.MaximumSize = new Size(562, 230);
            lbltxtAboutme.MinimumSize = new Size(360, 172);
            lbltxtAboutme.Name = "lbltxtAboutme";
            lbltxtAboutme.Size = new Size(360, 172);
            lbltxtAboutme.TabIndex = 9;
            lbltxtAboutme.Text = "labelAboutMe";
            // 
            // lblAboutme
            // 
            lblAboutme.AutoSize = true;
            lblAboutme.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAboutme.Location = new Point(25, 144);
            lblAboutme.Name = "lblAboutme";
            lblAboutme.Size = new Size(79, 23);
            lblAboutme.TabIndex = 8;
            lblAboutme.Text = "Обо мне";
            // 
            // lblcmbFilm
            // 
            lblcmbFilm.AutoSize = true;
            lblcmbFilm.BackColor = Color.FromArgb(192, 192, 255);
            lblcmbFilm.BorderStyle = BorderStyle.Fixed3D;
            lblcmbFilm.Location = new Point(278, 108);
            lblcmbFilm.Name = "lblcmbFilm";
            lblcmbFilm.Size = new Size(79, 25);
            lblcmbFilm.TabIndex = 7;
            lblcmbFilm.Text = "labelFilm";
            // 
            // lblFilm
            // 
            lblFilm.AutoSize = true;
            lblFilm.Location = new Point(278, 84);
            lblFilm.Name = "lblFilm";
            lblFilm.Size = new Size(120, 23);
            lblFilm.TabIndex = 6;
            lblFilm.Text = "Жанр фильма";
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.BackColor = Color.FromArgb(192, 192, 255);
            lblMusic.BorderStyle = BorderStyle.Fixed3D;
            lblMusic.Location = new Point(278, 45);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(92, 25);
            lblMusic.TabIndex = 5;
            lblMusic.Text = "labelMusic";
            // 
            // lblMusicGenre
            // 
            lblMusicGenre.AutoSize = true;
            lblMusicGenre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMusicGenre.Location = new Point(278, 18);
            lblMusicGenre.Name = "lblMusicGenre";
            lblMusicGenre.Size = new Size(117, 23);
            lblMusicGenre.TabIndex = 4;
            lblMusicGenre.Text = "Жанр музыки";
            // 
            // lblBadHab
            // 
            lblBadHab.AutoSize = true;
            lblBadHab.BackColor = Color.FromArgb(192, 192, 255);
            lblBadHab.BorderStyle = BorderStyle.Fixed3D;
            lblBadHab.Location = new Point(27, 108);
            lblBadHab.Name = "lblBadHab";
            lblBadHab.Size = new Size(77, 25);
            lblBadHab.TabIndex = 3;
            lblBadHab.Text = "labelBad";
            // 
            // lblBadHabbits
            // 
            lblBadHabbits.AutoSize = true;
            lblBadHabbits.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblBadHabbits.Location = new Point(25, 82);
            lblBadHabbits.Name = "lblBadHabbits";
            lblBadHabbits.Size = new Size(163, 23);
            lblBadHabbits.TabIndex = 2;
            lblBadHabbits.Text = "Вредные привычки";
            // 
            // lblcmbHobbies
            // 
            lblcmbHobbies.AutoSize = true;
            lblcmbHobbies.BackColor = Color.FromArgb(192, 192, 255);
            lblcmbHobbies.BorderStyle = BorderStyle.Fixed3D;
            lblcmbHobbies.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblcmbHobbies.Location = new Point(27, 48);
            lblcmbHobbies.Name = "lblcmbHobbies";
            lblcmbHobbies.Size = new Size(80, 25);
            lblcmbHobbies.TabIndex = 1;
            lblcmbHobbies.Text = "labelHob";
            // 
            // lblHobbies
            // 
            lblHobbies.AutoSize = true;
            lblHobbies.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHobbies.Location = new Point(25, 18);
            lblHobbies.Name = "lblHobbies";
            lblHobbies.Size = new Size(95, 23);
            lblHobbies.TabIndex = 0;
            lblHobbies.Text = "Увлечения";
            // 
            // pctColor
            // 
            pctColor.BackColor = Color.FromArgb(192, 192, 255);
            pctColor.Location = new Point(231, 53);
            pctColor.Name = "pctColor";
            pctColor.Size = new Size(551, 605);
            pctColor.TabIndex = 2;
            pctColor.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(714, 300);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(60, 48);
            btnNext.TabIndex = 3;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLike
            // 
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.Image = (Image)resources.GetObject("btnLike.Image");
            btnLike.Location = new Point(462, 569);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(81, 76);
            btnLike.TabIndex = 4;
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // btnShowProfile
            // 
            btnShowProfile.BackColor = Color.FromArgb(192, 192, 255);
            btnShowProfile.FlatAppearance.BorderSize = 0;
            btnShowProfile.FlatStyle = FlatStyle.Flat;
            btnShowProfile.Location = new Point(821, 677);
            btnShowProfile.Name = "btnShowProfile";
            btnShowProfile.Size = new Size(199, 33);
            btnShowProfile.TabIndex = 5;
            btnShowProfile.Text = "Мой профиль";
            btnShowProfile.UseVisualStyleBackColor = false;
            btnShowProfile.Click += btnShowProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(382, 19);
            label1.Name = "label1";
            label1.Size = new Size(217, 31);
            label1.TabIndex = 6;
            label1.Text = "Подобрали для вас";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1046, 722);
            Controls.Add(label1);
            Controls.Add(btnShowProfile);
            Controls.Add(btnLike);
            Controls.Add(btnNext);
            Controls.Add(tabControl);
            Controls.Add(pctColor);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "MainWindow";
            Text = "Главное окно";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblHobbies;
        private PictureBox pctColor;
        private Label lblBadHabbits;
        private Label lblcmbHobbies;
        private Label lblMusic;
        private Label lblMusicGenre;
        private Label lblBadHab;
        private Label lblFilm;
        private Label lblcmbFilm;
        private Label lbltxtAboutme;
        private Label lblAboutme;
        private Button btnNext;
        private Button btnLike;
        private PictureBox pctPhoto;
        private Label lblName;
        private Button btnShowProfile;
        private Label label1;
    }
}