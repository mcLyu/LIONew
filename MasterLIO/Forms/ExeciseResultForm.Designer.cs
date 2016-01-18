namespace MasterLIO.Forms
{
    partial class ExeciseResultForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.time = new System.Windows.Forms.Label();
            this.wrongNumber = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(196, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Оценка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Controls.Add(this.wrongNumber);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(6, 59);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(35, 13);
            this.time.TabIndex = 4;
            this.time.Text = "label2";
            // 
            // wrongNumber
            // 
            this.wrongNumber.AutoSize = true;
            this.wrongNumber.Location = new System.Drawing.Point(6, 26);
            this.wrongNumber.Name = "wrongNumber";
            this.wrongNumber.Size = new System.Drawing.Size(35, 13);
            this.wrongNumber.TabIndex = 3;
            this.wrongNumber.Text = "label2";
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLabel.Location = new System.Drawing.Point(182, 63);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(0, 108);
            this.markLabel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ваш результат";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Завершить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Заново";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(6, 89);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(35, 13);
            this.speed.TabIndex = 5;
            this.speed.Text = "label2";
            // 
            // ExeciseResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ExeciseResultForm";
            this.Text = "ExeciseResultForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label wrongNumber;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label speed;
    }
}