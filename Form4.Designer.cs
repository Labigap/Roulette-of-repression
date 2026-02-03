namespace RouletteOfRepression
{
    partial class ArrestRoll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrestRoll));
            this.fonarrest = new System.Windows.Forms.PictureBox();
            this.qeL = new System.Windows.Forms.Label();
            this.Spin = new System.Windows.Forms.Button();
            this.MenuExit = new System.Windows.Forms.Button();
            this.RollPeople = new System.Windows.Forms.Label();
            this.inagentbtn = new System.Windows.Forms.Button();
            this.arrestbtn = new System.Windows.Forms.Button();
            this.killbtn = new System.Windows.Forms.Button();
            this.Contbtn = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fonarrest)).BeginInit();
            this.SuspendLayout();
            // 
            // fonarrest
            // 
            this.fonarrest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fonarrest.Image = ((System.Drawing.Image)(resources.GetObject("fonarrest.Image")));
            this.fonarrest.Location = new System.Drawing.Point(0, 0);
            this.fonarrest.Name = "fonarrest";
            this.fonarrest.Size = new System.Drawing.Size(1350, 729);
            this.fonarrest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fonarrest.TabIndex = 0;
            this.fonarrest.TabStop = false;
            // 
            // qeL
            // 
            this.qeL.AutoSize = true;
            this.qeL.BackColor = System.Drawing.Color.DarkGreen;
            this.qeL.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qeL.ForeColor = System.Drawing.Color.SeaShell;
            this.qeL.Location = new System.Drawing.Point(180, 130);
            this.qeL.Name = "qeL";
            this.qeL.Size = new System.Drawing.Size(948, 64);
            this.qeL.TabIndex = 1;
            this.qeL.Text = "У кого появятся проблемы сегодня?";
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Spin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spin.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spin.ForeColor = System.Drawing.Color.Black;
            this.Spin.Location = new System.Drawing.Point(520, 320);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(246, 82);
            this.Spin.TabIndex = 2;
            this.Spin.Text = "Крутить ";
            this.Spin.UseVisualStyleBackColor = false;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
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
            this.MenuExit.TabIndex = 8;
            this.MenuExit.Text = "Меню";
            this.MenuExit.UseVisualStyleBackColor = false;
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // RollPeople
            // 
            this.RollPeople.AutoSize = true;
            this.RollPeople.BackColor = System.Drawing.Color.OliveDrab;
            this.RollPeople.Cursor = System.Windows.Forms.Cursors.Cross;
            this.RollPeople.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RollPeople.ForeColor = System.Drawing.Color.Gainsboro;
            this.RollPeople.Location = new System.Drawing.Point(180, 210);
            this.RollPeople.Name = "RollPeople";
            this.RollPeople.Size = new System.Drawing.Size(178, 65);
            this.RollPeople.TabIndex = 9;
            this.RollPeople.Text = "People";
            // 
            // inagentbtn
            // 
            this.inagentbtn.BackColor = System.Drawing.Color.Goldenrod;
            this.inagentbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inagentbtn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inagentbtn.Location = new System.Drawing.Point(458, 329);
            this.inagentbtn.Name = "inagentbtn";
            this.inagentbtn.Size = new System.Drawing.Size(376, 73);
            this.inagentbtn.TabIndex = 10;
            this.inagentbtn.Text = "Признать иноагентом";
            this.inagentbtn.UseVisualStyleBackColor = false;
            this.inagentbtn.Click += new System.EventHandler(this.inagentbtn_Click);
            // 
            // arrestbtn
            // 
            this.arrestbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.arrestbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrestbtn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrestbtn.Location = new System.Drawing.Point(504, 420);
            this.arrestbtn.Name = "arrestbtn";
            this.arrestbtn.Size = new System.Drawing.Size(276, 63);
            this.arrestbtn.TabIndex = 11;
            this.arrestbtn.Text = "Арестовать ";
            this.arrestbtn.UseVisualStyleBackColor = false;
            this.arrestbtn.Click += new System.EventHandler(this.arrestbtn_Click);
            // 
            // killbtn
            // 
            this.killbtn.BackColor = System.Drawing.Color.Red;
            this.killbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.killbtn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.killbtn.Location = new System.Drawing.Point(504, 506);
            this.killbtn.Name = "killbtn";
            this.killbtn.Size = new System.Drawing.Size(276, 58);
            this.killbtn.TabIndex = 12;
            this.killbtn.Text = "Ликвидировать";
            this.killbtn.UseVisualStyleBackColor = false;
            this.killbtn.Click += new System.EventHandler(this.killbtn_Click);
            // 
            // Contbtn
            // 
            this.Contbtn.BackColor = System.Drawing.Color.Black;
            this.Contbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contbtn.ForeColor = System.Drawing.Color.White;
            this.Contbtn.Location = new System.Drawing.Point(504, 431);
            this.Contbtn.Name = "Contbtn";
            this.Contbtn.Size = new System.Drawing.Size(285, 69);
            this.Contbtn.TabIndex = 13;
            this.Contbtn.Text = "Продолжить";
            this.Contbtn.UseVisualStyleBackColor = false;
            this.Contbtn.Click += new System.EventHandler(this.Contbtn_Click);
            // 
            // Pay
            // 
            this.Pay.AutoSize = true;
            this.Pay.BackColor = System.Drawing.Color.LawnGreen;
            this.Pay.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.ForeColor = System.Drawing.Color.Black;
            this.Pay.Location = new System.Drawing.Point(366, 267);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(350, 50);
            this.Pay.TabIndex = 14;
            this.Pay.Text = "Вы заработали:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ArrestRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.Contbtn);
            this.Controls.Add(this.killbtn);
            this.Controls.Add(this.arrestbtn);
            this.Controls.Add(this.inagentbtn);
            this.Controls.Add(this.RollPeople);
            this.Controls.Add(this.MenuExit);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.qeL);
            this.Controls.Add(this.fonarrest);
            this.Name = "ArrestRoll";
            this.Text = "Рулетка арестов";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fonarrest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fonarrest;
        private System.Windows.Forms.Label qeL;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button MenuExit;
        private System.Windows.Forms.Label RollPeople;
        private System.Windows.Forms.Button inagentbtn;
        private System.Windows.Forms.Button arrestbtn;
        private System.Windows.Forms.Button killbtn;
        private System.Windows.Forms.Button Contbtn;
        private System.Windows.Forms.Label Pay;
        private System.Windows.Forms.Timer timer1;
    }
}