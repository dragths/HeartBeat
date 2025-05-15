using System.Windows.Forms;

namespace tinder_1
{
    partial class MyLike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyLike));
            tableLayoutPanel = new TableLayoutPanel();
            pnlProfileTemplate = new Panel();
            btnShowProfileTemplate = new Button();
            btnDeleteTemplate = new Button();
            lblCityTemplate = new Label();
            lblAgeTemplate = new Label();
            lblNameTemplate = new Label();
            pctPhotoTemplate = new PictureBox();
            btnBack = new Button();
            lblMyLike = new Label();
            tableLayoutPanel.SuspendLayout();
            pnlProfileTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctPhotoTemplate).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.HorizontalScroll.Maximum = 0;
            tableLayoutPanel.AutoScroll = false;
            tableLayoutPanel.VerticalScroll.Visible = false;
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.BackColor = Color.FromArgb(204, 216, 255);
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(pnlProfileTemplate, 0, 0);
            tableLayoutPanel.Location = new Point(99, 93);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Size = new Size(631, 405);
            tableLayoutPanel.TabIndex = 0;
            // 
            // pnlProfileTemplate
            // 
            pnlProfileTemplate.Anchor = AnchorStyles.None;
            pnlProfileTemplate.BackColor = Color.White;
            pnlProfileTemplate.Controls.Add(btnShowProfileTemplate);
            pnlProfileTemplate.Controls.Add(btnDeleteTemplate);
            pnlProfileTemplate.Controls.Add(lblCityTemplate);
            pnlProfileTemplate.Controls.Add(lblAgeTemplate);
            pnlProfileTemplate.Controls.Add(lblNameTemplate);
            pnlProfileTemplate.Controls.Add(pctPhotoTemplate);
            pnlProfileTemplate.Location = new Point(21, 10);
            pnlProfileTemplate.Name = "pnlProfileTemplate";
            pnlProfileTemplate.Size = new Size(588, 114);
            pnlProfileTemplate.TabIndex = 0;
            pnlProfileTemplate.Visible = false;
            // 
            // btnShowProfileTemplate
            // 
            btnShowProfileTemplate.BackColor = Color.FromArgb(204, 216, 255);
            btnShowProfileTemplate.Location = new Point(394, 37);
            btnShowProfileTemplate.Name = "btnShowProfileTemplate";
            btnShowProfileTemplate.Size = new Size(180, 29);
            btnShowProfileTemplate.TabIndex = 5;
            btnShowProfileTemplate.Text = "Посмотреть профиль";
            btnShowProfileTemplate.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTemplate
            // 
            btnDeleteTemplate.BackColor = Color.IndianRed;
            btnDeleteTemplate.Location = new Point(454, 72);
            btnDeleteTemplate.Name = "btnDeleteTemplate";
            btnDeleteTemplate.Size = new Size(120, 29);
            btnDeleteTemplate.TabIndex = 4;
            btnDeleteTemplate.Text = "Удалить";
            btnDeleteTemplate.UseVisualStyleBackColor = false;
            // 
            // lblCityTemplate
            // 
            lblCityTemplate.AutoSize = true;
            lblCityTemplate.BackColor = Color.FromArgb(204, 216, 255);
            lblCityTemplate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCityTemplate.Location = new Point(256, 74);
            lblCityTemplate.Name = "lblCityTemplate";
            lblCityTemplate.Size = new Size(55, 23);
            lblCityTemplate.TabIndex = 3;
            lblCityTemplate.Text = "label1";
            // 
            // lblAgeTemplate
            // 
            lblAgeTemplate.AutoSize = true;
            lblAgeTemplate.BackColor = Color.FromArgb(204, 216, 255);
            lblAgeTemplate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAgeTemplate.Location = new Point(135, 74);
            lblAgeTemplate.Name = "lblAgeTemplate";
            lblAgeTemplate.Size = new Size(55, 23);
            lblAgeTemplate.TabIndex = 2;
            lblAgeTemplate.Text = "label1";
            // 
            // lblNameTemplate
            // 
            lblNameTemplate.AutoSize = true;
            lblNameTemplate.BackColor = Color.FromArgb(204, 216, 255);
            lblNameTemplate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNameTemplate.Location = new Point(135, 16);
            lblNameTemplate.Name = "lblNameTemplate";
            lblNameTemplate.Size = new Size(55, 23);
            lblNameTemplate.TabIndex = 1;
            lblNameTemplate.Text = "label1";
            // 
            // pctPhotoTemplate
            // 
            pctPhotoTemplate.BackColor = Color.FromArgb(204, 216, 255);
            pctPhotoTemplate.Location = new Point(15, 16);
            pctPhotoTemplate.Name = "pctPhotoTemplate";
            pctPhotoTemplate.Size = new Size(92, 81);
            pctPhotoTemplate.TabIndex = 0;
            pctPhotoTemplate.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.Location = new Point(813, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(49, 39);
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblMyLike
            // 
            lblMyLike.AutoSize = true;
            lblMyLike.BackColor = Color.FromArgb(204, 216, 255);
            lblMyLike.FlatStyle = FlatStyle.Flat;
            lblMyLike.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMyLike.Location = new Point(314, 44);
            lblMyLike.Name = "lblMyLike";
            lblMyLike.Size = new Size(183, 31);
            lblMyLike.TabIndex = 2;
            lblMyLike.Text = "Мои избранные";
            // 
            // MyLike
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 519);
            Controls.Add(lblMyLike);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel);
            Name = "MyLike";
            Text = "Мои избранные";
            Load += MyLike_Load;
            tableLayoutPanel.ResumeLayout(false);
            pnlProfileTemplate.ResumeLayout(false);
            pnlProfileTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctPhotoTemplate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Panel pnlProfileTemplate;
        private Label lblAgeTemplate;
        private Label lblNameTemplate;
        private PictureBox pctPhotoTemplate;
        private Label lblCityTemplate;
        private Button btnShowProfileTemplate;
        private Button btnDeleteTemplate;

        public Panel CreateProfileCardTemplate()
        {
            Panel newPanel = new Panel();
            newPanel.BackColor = pnlProfileTemplate.BackColor;
            newPanel.Size = pnlProfileTemplate.Size;
            newPanel.BorderStyle = BorderStyle.FixedSingle;

            PictureBox newPhoto = new PictureBox();
            CopyControlProperties(pctPhotoTemplate, newPhoto);

            Label newName = new Label();
            CopyControlProperties(lblNameTemplate, newName);

            Label newAge = new Label();
            CopyControlProperties(lblAgeTemplate, newAge);

            Label newCity = new Label();
            CopyControlProperties(lblCityTemplate, newCity);

            Button newShowProfile = new Button();
            CopyControlProperties(btnShowProfileTemplate, newShowProfile);

            Button newDelete = new Button();
            CopyControlProperties(btnDeleteTemplate, newDelete);

            newPanel.Controls.Add(newPhoto);
            newPanel.Controls.Add(newName);
            newPanel.Controls.Add(newAge);
            newPanel.Controls.Add(newCity);
            newPanel.Controls.Add(newShowProfile);
            newPanel.Controls.Add(newDelete);

            return newPanel;
        }

        private void CopyControlProperties(Control source, Control destination)
        {
            destination.BackColor = source.BackColor;
            destination.ForeColor = source.ForeColor;
            destination.Font = new Font(source.Font, source.Font.Style);
            destination.Size = source.Size;
            destination.Location = source.Location;
            destination.Text = source.Text;
            destination.TabIndex = source.TabIndex;

            if (source is PictureBox srcPic && destination is PictureBox destPic)
            {
                destPic.SizeMode = srcPic.SizeMode;
            }
            else if (source is Button srcBtn && destination is Button destBtn)
            {
                destBtn.FlatStyle = srcBtn.FlatStyle;
                destBtn.UseVisualStyleBackColor = srcBtn.UseVisualStyleBackColor;
            }
            else if (source is Label srcLbl && destination is Label destLbl)
            {
                destLbl.AutoSize = srcLbl.AutoSize;
                destLbl.TextAlign = srcLbl.TextAlign;
            }
        }

        private Button btnBack;
        private Label lblMyLike;
    }
}