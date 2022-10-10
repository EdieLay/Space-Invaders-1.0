namespace Space_Invaders
{
    partial class NameForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.buttonPlay1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Space_Invaders.Resource1.Background;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.pictureBox0);
            this.panel1.Controls.Add(this.buttonPlay1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 652);
            this.panel1.TabIndex = 10;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(479, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(35, 44);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "X";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameField.Location = new System.Drawing.Point(131, 249);
            this.userNameField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(329, 43);
            this.userNameField.TabIndex = 5;
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackgroundImage = global::Space_Invaders.Resource1.Background;
            this.pictureBox0.Image = global::Space_Invaders.Resource1.User;
            this.pictureBox0.Location = new System.Drawing.Point(46, 229);
            this.pictureBox0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(79, 85);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox0.TabIndex = 4;
            this.pictureBox0.TabStop = false;
            // 
            // buttonPlay1
            // 
            this.buttonPlay1.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonPlay1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonPlay1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonPlay1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonPlay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlay1.Location = new System.Drawing.Point(118, 377);
            this.buttonPlay1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPlay1.Name = "buttonPlay1";
            this.buttonPlay1.Size = new System.Drawing.Size(297, 93);
            this.buttonPlay1.TabIndex = 3;
            this.buttonPlay1.Text = "ИГРАТЬ";
            this.buttonPlay1.UseVisualStyleBackColor = false;
            this.buttonPlay1.Click += new System.EventHandler(this.buttonPlay1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(118, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "ВВЕДИТЕ ВАШ НИКНЕЙМ";
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 652);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private TextBox userNameField;
        private PictureBox pictureBox0;
        private Button buttonPlay1;
        private Label label1;
        private Button buttonExit;
    }
}