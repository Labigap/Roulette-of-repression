namespace RouletteOfRepression
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MenuFon = new System.Windows.Forms.PictureBox();
            this.rknbtn = new System.Windows.Forms.Button();
            this.hi = new System.Windows.Forms.Label();
            this.NKOBtn = new System.Windows.Forms.Button();
            this.DopBtn = new System.Windows.Forms.Button();
            this.arrestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MenuFon)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuFon
            // 
            this.MenuFon.Image = ((System.Drawing.Image)(resources.GetObject("MenuFon.Image")));
            this.MenuFon.Location = new System.Drawing.Point(0, 0);
            this.MenuFon.Name = "MenuFon";
            this.MenuFon.Size = new System.Drawing.Size(1366, 768);
            this.MenuFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuFon.TabIndex = 4;
            this.MenuFon.TabStop = false;
            // 
            // rknbtn
            // 
            this.rknbtn.BackColor = System.Drawing.Color.Transparent;
            this.rknbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rknbtn.BackgroundImage")));
            this.rknbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rknbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rknbtn.ForeColor = System.Drawing.Color.LightYellow;
            this.rknbtn.Location = new System.Drawing.Point(92, 122);
            this.rknbtn.Name = "rknbtn";
            this.rknbtn.Size = new System.Drawing.Size(500, 250);
            this.rknbtn.TabIndex = 10;
            this.rknbtn.Text = "РКН Рулетка";
            this.rknbtn.UseVisualStyleBackColor = false;
            this.rknbtn.Click += new System.EventHandler(this.rknbtn_Click);
            // 
            // hi
            // 
            this.hi.AutoSize = true;
            this.hi.BackColor = System.Drawing.Color.Black;
            this.hi.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hi.ForeColor = System.Drawing.Color.White;
            this.hi.Location = new System.Drawing.Point(403, 26);
            this.hi.Name = "hi";
            this.hi.Size = new System.Drawing.Size(533, 64);
            this.hi.TabIndex = 11;
            this.hi.Text = "Добро пожаловать!";
            // 
            // NKOBtn
            // 
            this.NKOBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.NKOBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NKOBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NKOBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NKOBtn.Location = new System.Drawing.Point(92, 425);
            this.NKOBtn.Name = "NKOBtn";
            this.NKOBtn.Size = new System.Drawing.Size(500, 250);
            this.NKOBtn.TabIndex = 12;
            this.NKOBtn.Text = "Преследование НКО";
            this.NKOBtn.UseVisualStyleBackColor = false;
            this.NKOBtn.Click += new System.EventHandler(this.NKOBtn_Click);
            // 
            // DopBtn
            // 
            this.DopBtn.BackColor = System.Drawing.Color.Maroon;
            this.DopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DopBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DopBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DopBtn.Location = new System.Drawing.Point(740, 425);
            this.DopBtn.Name = "DopBtn";
            this.DopBtn.Size = new System.Drawing.Size(500, 250);
            this.DopBtn.TabIndex = 13;
            this.DopBtn.Text = "Дополнения";
            this.DopBtn.UseVisualStyleBackColor = false;
            this.DopBtn.Click += new System.EventHandler(this.DopBtn_Click);
            // 
            // arrestBtn
            // 
            this.arrestBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.arrestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrestBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrestBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.arrestBtn.Location = new System.Drawing.Point(740, 122);
            this.arrestBtn.Name = "arrestBtn";
            this.arrestBtn.Size = new System.Drawing.Size(500, 250);
            this.arrestBtn.TabIndex = 14;
            this.arrestBtn.Text = "Рулетка арестов";
            this.arrestBtn.UseVisualStyleBackColor = false;
            this.arrestBtn.Click += new System.EventHandler(this.arrestBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.arrestBtn);
            this.Controls.Add(this.DopBtn);
            this.Controls.Add(this.NKOBtn);
            this.Controls.Add(this.hi);
            this.Controls.Add(this.rknbtn);
            this.Controls.Add(this.MenuFon);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuFon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MenuFon;
        private System.Windows.Forms.Button rknbtn;
        private System.Windows.Forms.Label hi;
        private System.Windows.Forms.Button NKOBtn;
        private System.Windows.Forms.Button DopBtn;
        private System.Windows.Forms.Button arrestBtn;
    }
}