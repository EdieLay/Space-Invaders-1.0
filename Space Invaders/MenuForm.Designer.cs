namespace Space_Invaders
{
    partial class MenuForm
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
            this.buttomResults = new System.Windows.Forms.Button();
            this.buttomPlay0 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Space_Invaders.Resource1.Background;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttomResults);
            this.panel1.Controls.Add(this.buttomPlay0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 652);
            this.panel1.TabIndex = 0;
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
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttomResults
            // 
            this.buttomResults.BackColor = System.Drawing.Color.SkyBlue;
            this.buttomResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttomResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttomResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttomResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttomResults.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttomResults.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttomResults.Location = new System.Drawing.Point(120, 337);
            this.buttomResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttomResults.Name = "buttomResults";
            this.buttomResults.Size = new System.Drawing.Size(297, 93);
            this.buttomResults.TabIndex = 1;
            this.buttomResults.Text = "РЕЗУЛЬТАТЫ";
            this.buttomResults.UseVisualStyleBackColor = false;
            this.buttomResults.Click += new System.EventHandler(this.buttomResults_Click);
            // 
            // buttomPlay0
            // 
            this.buttomPlay0.BackColor = System.Drawing.Color.SkyBlue;
            this.buttomPlay0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttomPlay0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttomPlay0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttomPlay0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttomPlay0.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttomPlay0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttomPlay0.Location = new System.Drawing.Point(120, 189);
            this.buttomPlay0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttomPlay0.Name = "buttomPlay0";
            this.buttomPlay0.Size = new System.Drawing.Size(297, 93);
            this.buttomPlay0.TabIndex = 0;
            this.buttomPlay0.Text = "ИГРАТЬ";
            this.buttomPlay0.UseVisualStyleBackColor = false;
            this.buttomPlay0.Click += new System.EventHandler(this.buttonPlay0_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 652);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttomPlay0;
        private Button buttomResults;
        private Button buttonExit;
    }
}