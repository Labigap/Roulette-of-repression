namespace RouletteOfRepression
{
    partial class NKORoll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NKORoll));
            this.NKOfon = new System.Windows.Forms.PictureBox();
            this.MenuExit = new System.Windows.Forms.Button();
            this.questionL = new System.Windows.Forms.Label();
            this.organizationL = new System.Windows.Forms.Label();
            this.PayL = new System.Windows.Forms.Label();
            this.Spinbtn = new System.Windows.Forms.Button();
            this.Contbtn = new System.Windows.Forms.Button();
            this.zapretbtn = new System.Windows.Forms.Button();
            this.Deportbtn = new System.Windows.Forms.Button();
            this.KillAllbtn = new System.Windows.Forms.Button();
            this.congratulations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NKOfon)).BeginInit();
            this.SuspendLayout();
            // 
            // NKOfon
            // 
            this.NKOfon.Image = ((System.Drawing.Image)(resources.GetObject("NKOfon.Image")));
            this.NKOfon.Location = new System.Drawing.Point(0, 0);
            this.NKOfon.Name = "NKOfon";
            this.NKOfon.Size = new System.Drawing.Size(1366, 768);
            this.NKOfon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NKOfon.TabIndex = 0;
            this.NKOfon.TabStop = false;
            // 
            // MenuExit
            // 
            this.MenuExit.BackColor = System.Drawing.Color.Navy;
            this.MenuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuExit.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuExit.ForeColor = System.Drawing.Color.Snow;
            this.MenuExit.Location = new System.Drawing.Point(550, 650);
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(148, 68);
            this.MenuExit.TabIndex = 9;
            this.MenuExit.Text = "Меню";
            this.MenuExit.UseVisualStyleBackColor = false;
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // questionL
            // 
            this.questionL.AutoSize = true;
            this.questionL.BackColor = System.Drawing.Color.Orange;
            this.questionL.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionL.Location = new System.Drawing.Point(12, 110);
            this.questionL.Name = "questionL";
            this.questionL.Size = new System.Drawing.Size(1326, 64);
            this.questionL.TabIndex = 10;
            this.questionL.Text = "У какой организации появятся проблемы сегодня?";
            // 
            // organizationL
            // 
            this.organizationL.AutoSize = true;
            this.organizationL.BackColor = System.Drawing.Color.DarkTurquoise;
            this.organizationL.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organizationL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.organizationL.Location = new System.Drawing.Point(179, 207);
            this.organizationL.Name = "organizationL";
            this.organizationL.Size = new System.Drawing.Size(263, 50);
            this.organizationL.TabIndex = 11;
            this.organizationL.Text = "Organization";
            // 
            // PayL
            // 
            this.PayL.AutoSize = true;
            this.PayL.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PayL.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayL.ForeColor = System.Drawing.Color.Black;
            this.PayL.Location = new System.Drawing.Point(299, 272);
            this.PayL.Name = "PayL";
            this.PayL.Size = new System.Drawing.Size(350, 50);
            this.PayL.TabIndex = 15;
            this.PayL.Text = "Вы заработали:";
            // 
            // Spinbtn
            // 
            this.Spinbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Spinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spinbtn.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spinbtn.ForeColor = System.Drawing.Color.Black;
            this.Spinbtn.Location = new System.Drawing.Point(503, 272);
            this.Spinbtn.Name = "Spinbtn";
            this.Spinbtn.Size = new System.Drawing.Size(246, 82);
            this.Spinbtn.TabIndex = 16;
            this.Spinbtn.Text = "Крутить ";
            this.Spinbtn.UseVisualStyleBackColor = false;
            this.Spinbtn.Click += new System.EventHandler(this.Spinbtn_Click);
            // 
            // Contbtn
            // 
            this.Contbtn.BackColor = System.Drawing.Color.Black;
            this.Contbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contbtn.ForeColor = System.Drawing.Color.White;
            this.Contbtn.Location = new System.Drawing.Point(492, 449);
            this.Contbtn.Name = "Contbtn";
            this.Contbtn.Size = new System.Drawing.Size(285, 69);
            this.Contbtn.TabIndex = 17;
            this.Contbtn.Text = "Продолжить";
            this.Contbtn.UseVisualStyleBackColor = false;
            this.Contbtn.Click += new System.EventHandler(this.Contbtn_Click);
            // 
            // zapretbtn
            // 
            this.zapretbtn.BackColor = System.Drawing.Color.Goldenrod;
            this.zapretbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zapretbtn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zapretbtn.Location = new System.Drawing.Point(520, 325);
            this.zapretbtn.Name = "zapretbtn";
            this.zapretbtn.Size = new System.Drawing.Size(215, 73);
            this.zapretbtn.TabIndex = 18;
            this.zapretbtn.Text = "Запретить";
            this.zapretbtn.UseVisualStyleBackColor = false;
            this.zapretbtn.Click += new System.EventHandler(this.zapretbtn_Click);
            // 
            // Deportbtn
            // 
            this.Deportbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Deportbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deportbtn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deportbtn.Location = new System.Drawing.Point(492, 419);
            this.Deportbtn.Name = "Deportbtn";
            this.Deportbtn.Size = new System.Drawing.Size(276, 63);
            this.Deportbtn.TabIndex = 19;
            this.Deportbtn.Text = "Депортировать";
            this.Deportbtn.UseVisualStyleBackColor = false;
            this.Deportbtn.Click += new System.EventHandler(this.Deportbtn_Click);
            // 
            // KillAllbtn
            // 
            this.KillAllbtn.BackColor = System.Drawing.Color.Red;
            this.KillAllbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KillAllbtn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KillAllbtn.Location = new System.Drawing.Point(492, 508);
            this.KillAllbtn.Name = "KillAllbtn";
            this.KillAllbtn.Size = new System.Drawing.Size(276, 58);
            this.KillAllbtn.TabIndex = 20;
            this.KillAllbtn.Text = "Расстрелять ";
            this.KillAllbtn.UseVisualStyleBackColor = false;
            this.KillAllbtn.Click += new System.EventHandler(this.KillAllbtn_Click);
            // 
            // congratulations
            // 
            this.congratulations.AutoSize = true;
            this.congratulations.BackColor = System.Drawing.Color.Goldenrod;
            this.congratulations.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.congratulations.Location = new System.Drawing.Point(483, 207);
            this.congratulations.Name = "congratulations";
            this.congratulations.Size = new System.Drawing.Size(282, 50);
            this.congratulations.TabIndex = 21;
            this.congratulations.Text = "Поздравляю!";
            // 
            // NKORoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.congratulations);
            this.Controls.Add(this.KillAllbtn);
            this.Controls.Add(this.Deportbtn);
            this.Controls.Add(this.zapretbtn);
            this.Controls.Add(this.Contbtn);
            this.Controls.Add(this.Spinbtn);
            this.Controls.Add(this.PayL);
            this.Controls.Add(this.organizationL);
            this.Controls.Add(this.questionL);
            this.Controls.Add(this.MenuExit);
            this.Controls.Add(this.NKOfon);
            this.Name = "NKORoll";
            this.Text = "Рулетка НКО";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NKOfon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NKOfon;
        private System.Windows.Forms.Button MenuExit;
        private System.Windows.Forms.Label questionL;
        private System.Windows.Forms.Label organizationL;
        private System.Windows.Forms.Label PayL;
        private System.Windows.Forms.Button Spinbtn;
        private System.Windows.Forms.Button Contbtn;
        private System.Windows.Forms.Button zapretbtn;
        private System.Windows.Forms.Button Deportbtn;
        private System.Windows.Forms.Button KillAllbtn;
        private System.Windows.Forms.Label congratulations;
    }
}