namespace RouletteOfRepression
{
    partial class Dop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dop));
            this.DopFon = new System.Windows.Forms.PictureBox();
            this.MenuExit = new System.Windows.Forms.Button();
            this.thanks = new System.Windows.Forms.Label();
            this.Authors = new System.Windows.Forms.Label();
            this.conn = new System.Windows.Forms.LinkLabel();
            this.telegram = new System.Windows.Forms.Button();
            this.GitHub = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DopFon)).BeginInit();
            this.SuspendLayout();
            // 
            // DopFon
            // 
            this.DopFon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DopFon.Image = ((System.Drawing.Image)(resources.GetObject("DopFon.Image")));
            this.DopFon.Location = new System.Drawing.Point(0, 0);
            this.DopFon.Name = "DopFon";
            this.DopFon.Size = new System.Drawing.Size(1350, 729);
            this.DopFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DopFon.TabIndex = 0;
            this.DopFon.TabStop = false;
            // 
            // MenuExit
            // 
            this.MenuExit.BackColor = System.Drawing.Color.Navy;
            this.MenuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuExit.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuExit.ForeColor = System.Drawing.Color.Snow;
            this.MenuExit.Location = new System.Drawing.Point(610, 570);
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(148, 68);
            this.MenuExit.TabIndex = 10;
            this.MenuExit.Text = "Меню";
            this.MenuExit.UseVisualStyleBackColor = false;
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // thanks
            // 
            this.thanks.AutoSize = true;
            this.thanks.BackColor = System.Drawing.Color.Maroon;
            this.thanks.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thanks.ForeColor = System.Drawing.Color.LightGray;
            this.thanks.Location = new System.Drawing.Point(510, 650);
            this.thanks.Name = "thanks";
            this.thanks.Size = new System.Drawing.Size(346, 50);
            this.thanks.TabIndex = 11;
            this.thanks.Text = "Спасибо за игру!";
            // 
            // Authors
            // 
            this.Authors.AutoSize = true;
            this.Authors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Authors.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authors.ForeColor = System.Drawing.Color.White;
            this.Authors.Location = new System.Drawing.Point(495, 20);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(376, 42);
            this.Authors.TabIndex = 12;
            this.Authors.Text = "Автор: Labigap studio";
            // 
            // conn
            // 
            this.conn.AutoSize = true;
            this.conn.BackColor = System.Drawing.Color.Teal;
            this.conn.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.conn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.conn.LinkColor = System.Drawing.Color.White;
            this.conn.Location = new System.Drawing.Point(505, 106);
            this.conn.Name = "conn";
            this.conn.Size = new System.Drawing.Size(351, 50);
            this.conn.TabIndex = 13;
            this.conn.TabStop = true;
            this.conn.Text = "Связь с автором:";
            // 
            // telegram
            // 
            this.telegram.BackColor = System.Drawing.Color.LightSteelBlue;
            this.telegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telegram.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telegram.ForeColor = System.Drawing.Color.Black;
            this.telegram.Location = new System.Drawing.Point(519, 191);
            this.telegram.Name = "telegram";
            this.telegram.Size = new System.Drawing.Size(321, 46);
            this.telegram.TabIndex = 17;
            this.telegram.Text = "Группа в телеграмме";
            this.telegram.UseVisualStyleBackColor = false;
            this.telegram.Click += new System.EventHandler(this.telegram_Click);
            // 
            // GitHub
            // 
            this.GitHub.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHub.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitHub.ForeColor = System.Drawing.Color.Black;
            this.GitHub.Location = new System.Drawing.Point(588, 272);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(170, 46);
            this.GitHub.TabIndex = 18;
            this.GitHub.Text = "GitHub";
            this.GitHub.UseVisualStyleBackColor = false;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mail.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail.Location = new System.Drawing.Point(526, 358);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(296, 33);
            this.mail.TabIndex = 19;
            this.mail.Text = "labigap1@gmail.com";
            // 
            // Dop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.telegram);
            this.Controls.Add(this.conn);
            this.Controls.Add(this.Authors);
            this.Controls.Add(this.thanks);
            this.Controls.Add(this.MenuExit);
            this.Controls.Add(this.DopFon);
            this.Name = "Dop";
            this.Text = "Дополнительно";
            this.Load += new System.EventHandler(this.Dop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DopFon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DopFon;
        private System.Windows.Forms.Button MenuExit;
        private System.Windows.Forms.Label thanks;
        private System.Windows.Forms.Label Authors;
        private System.Windows.Forms.LinkLabel conn;
        private System.Windows.Forms.Button telegram;
        private System.Windows.Forms.Button GitHub;
        private System.Windows.Forms.Label mail;
    }
}