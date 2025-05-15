namespace tinder_1
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            lblRegistration = new Label();
            lblLogin = new Label();
            lblPassword = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            btnRegistration2 = new Button();
            lblPasswortRepeate = new Label();
            txtPasswordRepeate = new TextBox();
            btnCheckPassword = new Button();
            btnCheckRepPassword = new Button();
            SuspendLayout();
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.BackColor = Color.Transparent;
            lblRegistration.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRegistration.Location = new Point(292, 75);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(176, 38);
            lblRegistration.TabIndex = 0;
            lblRegistration.Text = "Регистрация";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLogin.Location = new Point(272, 113);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(62, 25);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.Location = new Point(272, 171);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(74, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(204, 216, 255);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(272, 199);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(222, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(204, 216, 255);
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Location = new Point(272, 141);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(222, 27);
            textBoxLogin.TabIndex = 4;
            // 
            // btnRegistration2
            // 
            btnRegistration2.BackColor = Color.FromArgb(192, 192, 255);
            btnRegistration2.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistration2.FlatStyle = FlatStyle.Popup;
            btnRegistration2.Location = new Point(292, 300);
            btnRegistration2.Name = "btnRegistration2";
            btnRegistration2.Size = new Size(176, 29);
            btnRegistration2.TabIndex = 5;
            btnRegistration2.Text = "Регистрироваться";
            btnRegistration2.UseVisualStyleBackColor = false;
            btnRegistration2.Click += btnRegistration2_Click;
            // 
            // lblPasswortRepeate
            // 
            lblPasswortRepeate.AutoSize = true;
            lblPasswortRepeate.BackColor = Color.Transparent;
            lblPasswortRepeate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPasswortRepeate.Location = new Point(272, 229);
            lblPasswortRepeate.Name = "lblPasswortRepeate";
            lblPasswortRepeate.Size = new Size(156, 23);
            lblPasswortRepeate.TabIndex = 6;
            lblPasswortRepeate.Text = "Повторите пароль";
            // 
            // txtPasswordRepeate
            // 
            txtPasswordRepeate.BackColor = Color.FromArgb(204, 216, 255);
            txtPasswordRepeate.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordRepeate.Location = new Point(272, 255);
            txtPasswordRepeate.Name = "txtPasswordRepeate";
            txtPasswordRepeate.Size = new Size(222, 27);
            txtPasswordRepeate.TabIndex = 7;
            // 
            // btnCheckPassword
            // 
            btnCheckPassword.BackColor = Color.Transparent;
            btnCheckPassword.BackgroundImage = (Image)resources.GetObject("btnCheckPassword.BackgroundImage");
            btnCheckPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnCheckPassword.FlatStyle = FlatStyle.Popup;
            btnCheckPassword.Location = new Point(460, 199);
            btnCheckPassword.Name = "btnCheckPassword";
            btnCheckPassword.Size = new Size(34, 27);
            btnCheckPassword.TabIndex = 8;
            btnCheckPassword.TextAlign = ContentAlignment.TopLeft;
            btnCheckPassword.UseVisualStyleBackColor = false;
            btnCheckPassword.Click += btnCheckPassword_Click;
            // 
            // btnCheckRepPassword
            // 
            btnCheckRepPassword.BackColor = Color.Transparent;
            btnCheckRepPassword.BackgroundImage = (Image)resources.GetObject("btnCheckRepPassword.BackgroundImage");
            btnCheckRepPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnCheckRepPassword.FlatStyle = FlatStyle.Popup;
            btnCheckRepPassword.Location = new Point(460, 255);
            btnCheckRepPassword.Name = "btnCheckRepPassword";
            btnCheckRepPassword.Size = new Size(34, 27);
            btnCheckRepPassword.TabIndex = 9;
            btnCheckRepPassword.TextAlign = ContentAlignment.TopLeft;
            btnCheckRepPassword.UseVisualStyleBackColor = false;
            btnCheckRepPassword.Click += btnCheckRepPassword_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 450);
            Controls.Add(btnCheckRepPassword);
            Controls.Add(btnCheckPassword);
            Controls.Add(txtPasswordRepeate);
            Controls.Add(lblPasswortRepeate);
            Controls.Add(btnRegistration2);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(lblRegistration);
            Name = "Registration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistration;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Button btnRegistration2;
        private Label lblPasswortRepeate;
        private TextBox txtPasswordRepeate;
        private Button btnCheckPassword;
        private Button btnCheckRepPassword;
    }
}