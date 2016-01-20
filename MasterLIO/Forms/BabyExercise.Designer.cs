namespace MasterLIO.Forms
{
    partial class BabyExercise
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
            this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblMissed = new System.Windows.Forms.ToolStripStatusLabel();
            this.speed = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCorrect = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Letter1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Letter4 = new System.Windows.Forms.Label();
            this.Letter3 = new System.Windows.Forms.Label();
            this.Letter2 = new System.Windows.Forms.Label();
            this.Letter5 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // difficultyProgressBar
            // 
            this.difficultyProgressBar.AutoToolTip = true;
            this.difficultyProgressBar.Name = "difficultyProgressBar";
            this.difficultyProgressBar.Size = new System.Drawing.Size(330, 16);
            // 
            // lblMissed
            // 
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(62, 17);
            this.lblMissed.Text = "Ошибок:?";
            // 
            // speed
            // 
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(109, 17);
            this.speed.Text = "Скорость: ?  сим/c";
            // 
            // lblCorrect
            // 
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(77, 17);
            this.lblCorrect.Text = "Правильно:?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCorrect,
            this.lblMissed,
            this.speed,
            this.difficultyProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(619, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Letter5);
            this.panel1.Controls.Add(this.Letter4);
            this.panel1.Controls.Add(this.Letter2);
            this.panel1.Controls.Add(this.Letter3);
            this.panel1.Controls.Add(this.Letter1);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 119);
            this.panel1.TabIndex = 14;
            // 
            // Letter1
            // 
            this.Letter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Letter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Letter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Letter1.Location = new System.Drawing.Point(3, 0);
            this.Letter1.Name = "Letter1";
            this.Letter1.Size = new System.Drawing.Size(113, 119);
            this.Letter1.TabIndex = 15;
            this.Letter1.Text = "A";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Letter4
            // 
            this.Letter4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Letter4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Letter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Letter4.Location = new System.Drawing.Point(360, 0);
            this.Letter4.Name = "Letter4";
            this.Letter4.Size = new System.Drawing.Size(113, 119);
            this.Letter4.TabIndex = 16;
            this.Letter4.Text = "A";
            // 
            // Letter3
            // 
            this.Letter3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Letter3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Letter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Letter3.Location = new System.Drawing.Point(241, 0);
            this.Letter3.Name = "Letter3";
            this.Letter3.Size = new System.Drawing.Size(113, 119);
            this.Letter3.TabIndex = 17;
            this.Letter3.Text = "A";
            // 
            // Letter2
            // 
            this.Letter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Letter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Letter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Letter2.Location = new System.Drawing.Point(122, 0);
            this.Letter2.Name = "Letter2";
            this.Letter2.Size = new System.Drawing.Size(113, 119);
            this.Letter2.TabIndex = 18;
            this.Letter2.Text = "A";
            // 
            // Letter5
            // 
            this.Letter5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Letter5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Letter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Letter5.Location = new System.Drawing.Point(479, 0);
            this.Letter5.Name = "Letter5";
            this.Letter5.Size = new System.Drawing.Size(113, 119);
            this.Letter5.TabIndex = 19;
            this.Letter5.Text = "A";
            // 
            // BabyExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BabyExercise";
            this.Text = "BabyExercise";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BabyExercise_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblMissed;
        private System.Windows.Forms.ToolStripStatusLabel speed;
        private System.Windows.Forms.ToolStripStatusLabel lblCorrect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Letter1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Letter5;
        private System.Windows.Forms.Label Letter4;
        private System.Windows.Forms.Label Letter2;
        private System.Windows.Forms.Label Letter3;

    }
}