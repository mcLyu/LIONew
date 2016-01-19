namespace MasterLIO.Forms
{
    partial class AdminMenuForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.statistic = new System.Windows.Forms.Button();
            this.ExerciseButton = new System.Windows.Forms.Button();
            this.CreateExercsieButton = new System.Windows.Forms.Button();
            this.EditAccountButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оСоздателяхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.exitButton.Location = new System.Drawing.Point(96, 317);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(379, 62);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // statistic
            // 
            this.statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.statistic.Location = new System.Drawing.Point(96, 110);
            this.statistic.Margin = new System.Windows.Forms.Padding(4);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(379, 62);
            this.statistic.TabIndex = 4;
            this.statistic.Text = "Статистика";
            this.statistic.UseVisualStyleBackColor = true;
            this.statistic.Click += new System.EventHandler(this.statistic_Click);
            // 
            // ExerciseButton
            // 
            this.ExerciseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.ExerciseButton.Location = new System.Drawing.Point(96, 41);
            this.ExerciseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExerciseButton.Name = "ExerciseButton";
            this.ExerciseButton.Size = new System.Drawing.Size(379, 62);
            this.ExerciseButton.TabIndex = 3;
            this.ExerciseButton.Text = "Упражнение";
            this.ExerciseButton.UseVisualStyleBackColor = true;
            this.ExerciseButton.Click += new System.EventHandler(this.ExerciseButton_Click);
            // 
            // CreateExercsieButton
            // 
            this.CreateExercsieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.CreateExercsieButton.Location = new System.Drawing.Point(96, 179);
            this.CreateExercsieButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateExercsieButton.Name = "CreateExercsieButton";
            this.CreateExercsieButton.Size = new System.Drawing.Size(379, 62);
            this.CreateExercsieButton.TabIndex = 6;
            this.CreateExercsieButton.Text = "Создание упражнения";
            this.CreateExercsieButton.UseVisualStyleBackColor = true;
            this.CreateExercsieButton.Click += new System.EventHandler(this.CreateExercsieButton_Click);
            // 
            // EditAccountButton
            // 
            this.EditAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.EditAccountButton.Location = new System.Drawing.Point(96, 248);
            this.EditAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditAccountButton.Name = "EditAccountButton";
            this.EditAccountButton.Size = new System.Drawing.Size(379, 62);
            this.EditAccountButton.TabIndex = 7;
            this.EditAccountButton.Text = "Управление учетными записями";
            this.EditAccountButton.UseVisualStyleBackColor = true;
            this.EditAccountButton.Click += new System.EventHandler(this.EditAccountButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оСоздателяхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оСоздателяхToolStripMenuItem
            // 
            this.оСоздателяхToolStripMenuItem.Name = "оСоздателяхToolStripMenuItem";
            this.оСоздателяхToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.оСоздателяхToolStripMenuItem.Text = "О создателях";
            this.оСоздателяхToolStripMenuItem.Click += new System.EventHandler(this.оСоздателяхToolStripMenuItem_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 392);
            this.Controls.Add(this.EditAccountButton);
            this.Controls.Add(this.CreateExercsieButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statistic);
            this.Controls.Add(this.ExerciseButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button statistic;
        private System.Windows.Forms.Button ExerciseButton;
        private System.Windows.Forms.Button CreateExercsieButton;
        private System.Windows.Forms.Button EditAccountButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оСоздателяхToolStripMenuItem;
    }
}