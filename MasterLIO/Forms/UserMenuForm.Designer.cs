namespace MasterLIO.Forms
{
    partial class UserMenuForm
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
            this.ExerciseButton = new System.Windows.Forms.Button();
            this.statistic = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оСоздателяхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rsButton1 = new RsDesign.Controls.STD.RsButton();
            this.rsButton2 = new RsDesign.Controls.STD.RsButton();
            this.rsButton3 = new RsDesign.Controls.STD.RsButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExerciseButton
            // 
            this.ExerciseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.ExerciseButton.Location = new System.Drawing.Point(13, 32);
            this.ExerciseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExerciseButton.Name = "ExerciseButton";
            this.ExerciseButton.Size = new System.Drawing.Size(379, 62);
            this.ExerciseButton.TabIndex = 0;
            this.ExerciseButton.Text = "Упражнение";
            this.ExerciseButton.UseVisualStyleBackColor = true;
            this.ExerciseButton.Click += new System.EventHandler(this.ExerciseButton_Click);
            // 
            // statistic
            // 
            this.statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.statistic.Location = new System.Drawing.Point(13, 101);
            this.statistic.Margin = new System.Windows.Forms.Padding(4);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(379, 62);
            this.statistic.TabIndex = 1;
            this.statistic.Text = "Статистика";
            this.statistic.UseVisualStyleBackColor = true;
            this.statistic.Click += new System.EventHandler(this.statistic_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.exitButton.Location = new System.Drawing.Point(13, 169);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(379, 62);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оСоздателяхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 28);
            this.menuStrip1.TabIndex = 3;
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
            // rsButton1
            // 
            this.rsButton1.BorderColor = System.Drawing.Color.DimGray;
            this.rsButton1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.rsButton1.Location = new System.Drawing.Point(13, 32);
            this.rsButton1.Name = "rsButton1";
            this.rsButton1.Size = new System.Drawing.Size(379, 62);
            this.rsButton1.SplitToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton1.TabIndex = 4;
            this.rsButton1.Text = "Упражнения";
            this.rsButton1.ToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton1.Click += new System.EventHandler(this.rsButton1_Click);
            // 
            // rsButton2
            // 
            this.rsButton2.BorderColor = System.Drawing.Color.DimGray;
            this.rsButton2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.rsButton2.Location = new System.Drawing.Point(13, 101);
            this.rsButton2.Name = "rsButton2";
            this.rsButton2.Size = new System.Drawing.Size(379, 62);
            this.rsButton2.SplitToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton2.TabIndex = 5;
            this.rsButton2.Text = "Статистика";
            this.rsButton2.ToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton2.Click += new System.EventHandler(this.rsButton2_Click);
            // 
            // rsButton3
            // 
            this.rsButton3.BorderColor = System.Drawing.Color.DimGray;
            this.rsButton3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.rsButton3.Location = new System.Drawing.Point(13, 169);
            this.rsButton3.Name = "rsButton3";
            this.rsButton3.Size = new System.Drawing.Size(379, 62);
            this.rsButton3.SplitToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton3.TabIndex = 6;
            this.rsButton3.Text = "Выход";
            this.rsButton3.ToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton3.Click += new System.EventHandler(this.rsButton3_Click);
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 252);
            this.Controls.Add(this.rsButton3);
            this.Controls.Add(this.rsButton2);
            this.Controls.Add(this.rsButton1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statistic);
            this.Controls.Add(this.ExerciseButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UserMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExerciseButton;
        private System.Windows.Forms.Button statistic;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оСоздателяхToolStripMenuItem;
        private RsDesign.Controls.STD.RsButton rsButton1;
        private RsDesign.Controls.STD.RsButton rsButton2;
        private RsDesign.Controls.STD.RsButton rsButton3;
    }
}