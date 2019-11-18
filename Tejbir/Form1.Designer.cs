namespace tajinder_dog_race
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.setbet = new System.Windows.Forms.Button();
            this.readyrace = new System.Windows.Forms.Button();
            this.selectplayer = new System.Windows.Forms.ComboBox();
            this.selectdog = new System.Windows.Forms.ComboBox();
            this.selectamount = new System.Windows.Forms.ComboBox();
            this.Players = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).BeginInit();
            this.SuspendLayout();
            // 
            // setbet
            // 
            this.setbet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setbet.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setbet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setbet.Location = new System.Drawing.Point(703, 395);
            this.setbet.Name = "setbet";
            this.setbet.Size = new System.Drawing.Size(153, 42);
            this.setbet.TabIndex = 4;
            this.setbet.Text = "Set Bett";
            this.setbet.UseVisualStyleBackColor = false;
            this.setbet.Click += new System.EventHandler(this.setbet_Click);
            // 
            // readyrace
            // 
            this.readyrace.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.readyrace.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyrace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.readyrace.Location = new System.Drawing.Point(703, 443);
            this.readyrace.Name = "readyrace";
            this.readyrace.Size = new System.Drawing.Size(153, 42);
            this.readyrace.TabIndex = 5;
            this.readyrace.Text = "Ready";
            this.readyrace.UseVisualStyleBackColor = false;
            this.readyrace.Click += new System.EventHandler(this.readyrace_Click);
            // 
            // selectplayer
            // 
            this.selectplayer.FormattingEnabled = true;
            this.selectplayer.Items.AddRange(new object[] {
            "Tajinder",
            "Harman",
            "Jarman"});
            this.selectplayer.Location = new System.Drawing.Point(773, 23);
            this.selectplayer.Name = "selectplayer";
            this.selectplayer.Size = new System.Drawing.Size(121, 21);
            this.selectplayer.TabIndex = 6;
            // 
            // selectdog
            // 
            this.selectdog.FormattingEnabled = true;
            this.selectdog.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.selectdog.Location = new System.Drawing.Point(773, 65);
            this.selectdog.Name = "selectdog";
            this.selectdog.Size = new System.Drawing.Size(121, 21);
            this.selectdog.TabIndex = 7;
            // 
            // selectamount
            // 
            this.selectamount.FormattingEnabled = true;
            this.selectamount.Location = new System.Drawing.Point(773, 109);
            this.selectamount.Name = "selectamount";
            this.selectamount.Size = new System.Drawing.Size(121, 21);
            this.selectamount.TabIndex = 8;
            // 
            // Players
            // 
            this.Players.AutoSize = true;
            this.Players.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Players.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Players.Location = new System.Drawing.Point(689, 24);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(60, 20);
            this.Players.TabIndex = 9;
            this.Players.Text = "Players";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(689, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dogs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(673, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bet Amount";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 74);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(12, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(647, 74);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(9, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(650, 74);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(9, 391);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(650, 74);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picture1
            // 
            this.picture1.Image = global::tajinder_dog_race.Properties.Resources.kuta1;
            this.picture1.Location = new System.Drawing.Point(9, 24);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(114, 73);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 16;
            this.picture1.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Image = global::tajinder_dog_race.Properties.Resources.kuta2;
            this.picture2.Location = new System.Drawing.Point(9, 135);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(114, 73);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2.TabIndex = 17;
            this.picture2.TabStop = false;
            // 
            // picture3
            // 
            this.picture3.Image = global::tajinder_dog_race.Properties.Resources.kuta3;
            this.picture3.Location = new System.Drawing.Point(9, 264);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(114, 73);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture3.TabIndex = 18;
            this.picture3.TabStop = false;
            // 
            // picture4
            // 
            this.picture4.Image = global::tajinder_dog_race.Properties.Resources.kuta6;
            this.picture4.Location = new System.Drawing.Point(9, 391);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(114, 73);
            this.picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture4.TabIndex = 19;
            this.picture4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(672, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Balance";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(672, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(672, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picture4);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Players);
            this.Controls.Add(this.selectamount);
            this.Controls.Add(this.selectdog);
            this.Controls.Add(this.selectplayer);
            this.Controls.Add(this.readyrace);
            this.Controls.Add(this.setbet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button setbet;
        private System.Windows.Forms.Button readyrace;
        private System.Windows.Forms.ComboBox selectplayer;
        private System.Windows.Forms.ComboBox selectdog;
        private System.Windows.Forms.ComboBox selectamount;
        private System.Windows.Forms.Label Players;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.PictureBox picture4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

