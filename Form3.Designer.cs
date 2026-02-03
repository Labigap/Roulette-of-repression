namespace RouletteOfRepression
{
    partial class RKNRoll
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RKNRoll));
            this.fonrkn = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.whatban = new System.Windows.Forms.Label();
            this.RollApp = new System.Windows.Forms.Label();
            this.slowdownbtn = new System.Windows.Forms.Button();
            this.banbtn = new System.Windows.Forms.Button();
            this.MenuExit = new System.Windows.Forms.Button();
            this.spinmenutim = new System.Windows.Forms.Timer(this.components);
            this.Pay = new System.Windows.Forms.Label();
            this.Contbtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fonrkn)).BeginInit();
            this.SuspendLayout();
            // 
            // fonrkn
            // 
            this.fonrkn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fonrkn.Image = ((System.Drawing.Image)(resources.GetObject("fonrkn.Image")));
            this.fonrkn.Location = new System.Drawing.Point(0, 0);
            this.fonrkn.Name = "fonrkn";
            this.fonrkn.Size = new System.Drawing.Size(1350, 729);
            this.fonrkn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fonrkn.TabIndex = 0;
            this.fonrkn.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(540, 295);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(246, 82);
            this.Start.TabIndex = 1;
            this.Start.Text = "Крутить ";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // whatban
            // 
            this.whatban.AutoSize = true;
            this.whatban.BackColor = System.Drawing.Color.MidnightBlue;
            this.whatban.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whatban.ForeColor = System.Drawing.Color.White;
            this.whatban.Location = new System.Drawing.Point(330, 130);
            this.whatban.Name = "whatban";
            this.whatban.Size = new System.Drawing.Size(705, 64);
            this.whatban.TabIndex = 2;
            this.whatban.Text = "Что заблокируем сегодня?";
            // 
            // RollApp
            // 
            this.RollApp.AutoSize = true;
            this.RollApp.BackColor = System.Drawing.Color.Indigo;
            this.RollApp.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RollApp.ForeColor = System.Drawing.Color.Gainsboro;
            this.RollApp.Location = new System.Drawing.Point(553, 215);
            this.RollApp.Name = "RollApp";
            this.RollApp.Size = new System.Drawing.Size(118, 65);
            this.RollApp.TabIndex = 4;
            this.RollApp.Text = "App";
            // 
            // slowdownbtn
            // 
            this.slowdownbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.slowdownbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slowdownbtn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slowdownbtn.Location = new System.Drawing.Point(524, 314);
            this.slowdownbtn.Name = "slowdownbtn";
            this.slowdownbtn.Size = new System.Drawing.Size(276, 63);
            this.slowdownbtn.TabIndex = 5;
            this.slowdownbtn.Text = "Замедлить ";
            this.slowdownbtn.UseVisualStyleBackColor = false;
            this.slowdownbtn.Click += new System.EventHandler(this.slowdownbtn_Click);
            // 
            // banbtn
            // 
            this.banbtn.BackColor = System.Drawing.Color.Red;
            this.banbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.banbtn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.banbtn.Location = new System.Drawing.Point(524, 412);
            this.banbtn.Name = "banbtn";
            this.banbtn.Size = new System.Drawing.Size(276, 64);
            this.banbtn.TabIndex = 6;
            this.banbtn.Text = "Заблокировать ";
            this.banbtn.UseVisualStyleBackColor = false;
            this.banbtn.Click += new System.EventHandler(this.banbtn_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.BackColor = System.Drawing.Color.Navy;
            this.MenuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuExit.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuExit.ForeColor = System.Drawing.Color.Snow;
            this.MenuExit.Location = new System.Drawing.Point(580, 550);
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(148, 68);
            this.MenuExit.TabIndex = 7;
            this.MenuExit.Text = "Меню";
            this.MenuExit.UseVisualStyleBackColor = false;
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // spinmenutim
            // 
            this.spinmenutim.Enabled = true;
            this.spinmenutim.Interval = 50;
            this.spinmenutim.Tick += new System.EventHandler(this.spinmenutim_Tick);
            // 
            // Pay
            // 
            this.Pay.AutoSize = true;
            this.Pay.BackColor = System.Drawing.Color.LawnGreen;
            this.Pay.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.ForeColor = System.Drawing.Color.Black;
            this.Pay.Location = new System.Drawing.Point(275, 181);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(350, 50);
            this.Pay.TabIndex = 8;
            this.Pay.Text = "Вы заработали:";
            // 
            // Contbtn
            // 
            this.Contbtn.BackColor = System.Drawing.Color.Black;
            this.Contbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contbtn.ForeColor = System.Drawing.Color.White;
            this.Contbtn.Location = new System.Drawing.Point(524, 337);
            this.Contbtn.Name = "Contbtn";
            this.Contbtn.Size = new System.Drawing.Size(291, 69);
            this.Contbtn.TabIndex = 9;
            this.Contbtn.Text = "Продолжить";
            this.Contbtn.UseVisualStyleBackColor = false;
            this.Contbtn.Click += new System.EventHandler(this.Contbtn_Click);
            // 
            // RKNRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Contbtn);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.MenuExit);
            this.Controls.Add(this.banbtn);
            this.Controls.Add(this.slowdownbtn);
            this.Controls.Add(this.RollApp);
            this.Controls.Add(this.whatban);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.fonrkn);
            this.Name = "RKNRoll";
            this.Text = "Рулетка блокировок";
            this.Load += new System.EventHandler(this.RKNRoll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fonrkn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fonrkn;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label whatban;
        private System.Windows.Forms.Label RollApp;
        private System.Windows.Forms.Button slowdownbtn;
        private System.Windows.Forms.Button banbtn;
        private System.Windows.Forms.Button MenuExit;
        private System.Windows.Forms.Timer spinmenutim;
        private System.Windows.Forms.Label Pay;
        private System.Windows.Forms.Button Contbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}