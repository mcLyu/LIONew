namespace MasterLIO
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.rsButton1 = new RsDesign.Controls.STD.RsButton();
            this.loginField = new RsDesign.Controls.STD.RsTextBox();
            this.passwordField = new RsDesign.Controls.STD.RsTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.loginButton.Location = new System.Drawing.Point(318, 221);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(139, 51);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // rsButton1
            // 
            this.rsButton1.BorderColor = System.Drawing.Color.DimGray;
            this.rsButton1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.rsButton1.Location = new System.Drawing.Point(318, 221);
            this.rsButton1.Name = "rsButton1";
            this.rsButton1.Size = new System.Drawing.Size(139, 51);
            this.rsButton1.SplitToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton1.TabIndex = 5;
            this.rsButton1.Text = "Войти";
            this.rsButton1.ToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton1.Click += new System.EventHandler(this.rsButton1_Click);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.loginField.Location = new System.Drawing.Point(166, 63);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(251, 45);
            this.loginField.TabIndex = 6;
            this.loginField.Text = "Lyubaikin";
            this.loginField.ToolTip.Size = new System.Drawing.Size(6, 7);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.passwordField.Location = new System.Drawing.Point(165, 134);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(252, 45);
            this.passwordField.TabIndex = 7;
            this.passwordField.Text = "qwerty";
            this.passwordField.ToolTip.Size = new System.Drawing.Size(6, 7);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 294);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.rsButton1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private RsDesign.Controls.STD.RsButton rsButton1;
        private RsDesign.Controls.STD.RsTextBox loginField;
        private RsDesign.Controls.STD.RsTextBox passwordField;
    }
}