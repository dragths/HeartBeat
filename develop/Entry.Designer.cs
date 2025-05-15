namespace tinder_1
{
    partial class Entry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            lblTitle = new Label();
            lnlLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            lblNoAccount = new Label();
            btnEntry = new Button();
            btnRegistration = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(287, 78);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HeartBeat";
            // 
            // lnlLogin
            // 
            lnlLogin.AutoSize = true;
            lnlLogin.BackColor = Color.Transparent;
            lnlLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lnlLogin.Location = new Point(240, 143);
            lnlLogin.Name = "lnlLogin";
            lnlLogin.Size = new Size(62, 25);
            lnlLogin.TabIndex = 1;
            lnlLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(240, 201);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(74, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(204, 216, 255);
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Location = new Point(240, 171);
            textBoxLogin.MaximumSize = new Size(300, 25);
            textBoxLogin.MinimumSize = new Size(200, 23);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(270, 25);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(204, 216, 255);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(240, 229);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(270, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.BackColor = Color.Transparent;
            lblNoAccount.Location = new Point(220, 349);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(105, 20);
            lblNoAccount.TabIndex = 6;
            lblNoAccount.Text = "Нет аккаунта?";
            // 
            // btnEntry
            // 
            btnEntry.BackColor = Color.FromArgb(192, 192, 255);
            btnEntry.BackgroundImageLayout = ImageLayout.Center;
            btnEntry.FlatAppearance.BorderSize = 0;
            btnEntry.FlatStyle = FlatStyle.Popup;
            btnEntry.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEntry.ForeColor = SystemColors.ActiveCaptionText;
            btnEntry.Location = new Point(258, 277);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(232, 32);
            btnEntry.TabIndex = 7;
            btnEntry.Text = "Вход";
            btnEntry.UseVisualStyleBackColor = true;
            btnEntry.Click += btnEntry_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.FromArgb(192, 192, 255);
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatStyle = FlatStyle.Popup;
            btnRegistration.Location = new Point(351, 349);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(159, 29);
            btnRegistration.TabIndex = 8;
            btnRegistration.Text = "Регистрация";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // Entry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 485);
            Controls.Add(btnRegistration);
            Controls.Add(btnEntry);
            Controls.Add(lblNoAccount);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(lnlLogin);
            Controls.Add(lblTitle);
            ForeColor = SystemColors.ControlText;
            Name = "Entry";
            RightToLeft = RightToLeft.No;
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lnlLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label lblNoAccount;
        private Button btnEntry;
        private Button btnRegistration;
    }
}