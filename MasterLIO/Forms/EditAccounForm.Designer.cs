namespace MasterLIO.Forms
{
    partial class EditAccounForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createUserButton1 = new System.Windows.Forms.Button();
            this.deleteUserbutton2 = new System.Windows.Forms.Button();
            this.approveButton3 = new System.Windows.Forms.Button();
            this.rsButton1 = new RsDesign.Controls.STD.RsButton();
            this.rsButton2 = new RsDesign.Controls.STD.RsButton();
            this.rsButton3 = new RsDesign.Controls.STD.RsButton();
            this.logintextBox2 = new RsDesign.Controls.STD.RsTextBox();
            this.passwordtextBox2 = new RsDesign.Controls.STD.RsTextBox();
            this.rolecomboBox1 = new RsDesign.Controls.STD.RsComboBox();
            this.textBox1 = new RsDesign.Controls.STD.RsTextBox();
            this.userlistBox1 = new RsDesign.Controls.STD.RsListBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolecomboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(240, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(234, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(355, 98);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 39);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Показать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(254, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Роль:";
            // 
            // createUserButton1
            // 
            this.createUserButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.createUserButton1.Location = new System.Drawing.Point(11, 221);
            this.createUserButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createUserButton1.Name = "createUserButton1";
            this.createUserButton1.Size = new System.Drawing.Size(111, 36);
            this.createUserButton1.TabIndex = 9;
            this.createUserButton1.Text = "Создать";
            this.createUserButton1.UseVisualStyleBackColor = true;
            this.createUserButton1.Click += new System.EventHandler(this.createUserButton1_Click);
            // 
            // deleteUserbutton2
            // 
            this.deleteUserbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.deleteUserbutton2.Location = new System.Drawing.Point(176, 221);
            this.deleteUserbutton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteUserbutton2.Name = "deleteUserbutton2";
            this.deleteUserbutton2.Size = new System.Drawing.Size(114, 36);
            this.deleteUserbutton2.TabIndex = 10;
            this.deleteUserbutton2.Text = "Удалить";
            this.deleteUserbutton2.UseVisualStyleBackColor = true;
            this.deleteUserbutton2.Click += new System.EventHandler(this.deleteUserbutton2_Click);
            // 
            // approveButton3
            // 
            this.approveButton3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.approveButton3.Location = new System.Drawing.Point(355, 230);
            this.approveButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approveButton3.Name = "approveButton3";
            this.approveButton3.Size = new System.Drawing.Size(121, 19);
            this.approveButton3.TabIndex = 11;
            this.approveButton3.Text = "Изменить";
            this.approveButton3.UseVisualStyleBackColor = true;
            this.approveButton3.Click += new System.EventHandler(this.approveButton3_Click);
            // 
            // rsButton1
            // 
            this.rsButton1.BorderColor = System.Drawing.Color.DimGray;
            this.rsButton1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.rsButton1.Location = new System.Drawing.Point(12, 222);
            this.rsButton1.Name = "rsButton1";
            this.rsButton1.Size = new System.Drawing.Size(151, 36);
            this.rsButton1.SplitToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton1.TabIndex = 12;
            this.rsButton1.Text = "Создать";
            this.rsButton1.ToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton1.Click += new System.EventHandler(this.rsButton1_Click);
            // 
            // rsButton2
            // 
            this.rsButton2.BorderColor = System.Drawing.Color.DimGray;
            this.rsButton2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.rsButton2.Location = new System.Drawing.Point(176, 222);
            this.rsButton2.Name = "rsButton2";
            this.rsButton2.Size = new System.Drawing.Size(151, 36);
            this.rsButton2.SplitToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton2.TabIndex = 13;
            this.rsButton2.Text = "Удалить";
            this.rsButton2.ToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton2.Click += new System.EventHandler(this.rsButton2_Click);
            // 
            // rsButton3
            // 
            this.rsButton3.BorderColor = System.Drawing.Color.DimGray;
            this.rsButton3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.rsButton3.Location = new System.Drawing.Point(342, 220);
            this.rsButton3.Name = "rsButton3";
            this.rsButton3.Size = new System.Drawing.Size(151, 36);
            this.rsButton3.SplitToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton3.TabIndex = 14;
            this.rsButton3.Text = "Изменить";
            this.rsButton3.ToolTip.Size = new System.Drawing.Size(6, 7);
            this.rsButton3.Click += new System.EventHandler(this.rsButton3_Click);
            // 
            // logintextBox2
            // 
            this.logintextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logintextBox2.Location = new System.Drawing.Point(335, 18);
            this.logintextBox2.Name = "logintextBox2";
            this.logintextBox2.Size = new System.Drawing.Size(141, 34);
            this.logintextBox2.TabIndex = 15;
            this.logintextBox2.ToolTip.Size = new System.Drawing.Size(6, 7);
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.passwordtextBox2.Location = new System.Drawing.Point(335, 58);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.Size = new System.Drawing.Size(142, 35);
            this.passwordtextBox2.TabIndex = 16;
            this.passwordtextBox2.ToolTip.Size = new System.Drawing.Size(6, 7);
            // 
            // rolecomboBox1
            // 
            this.rolecomboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rolecomboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.rolecomboBox1.Location = new System.Drawing.Point(335, 151);
            this.rolecomboBox1.Name = "rolecomboBox1";
            this.rolecomboBox1.Size = new System.Drawing.Size(142, 34);
            this.rolecomboBox1.TabIndex = 17;
            this.rolecomboBox1.ToolTip.Size = new System.Drawing.Size(6, 7);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.textBox1.Location = new System.Drawing.Point(11, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 34);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Поиск...";
            this.textBox1.ToolTip.Size = new System.Drawing.Size(6, 7);
            // 
            // userlistBox1
            // 
            this.userlistBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.userlistBox1.FormattingEnabled = true;
            this.userlistBox1.Location = new System.Drawing.Point(11, 59);
            this.userlistBox1.Name = "userlistBox1";
            this.userlistBox1.Size = new System.Drawing.Size(152, 126);
            this.userlistBox1.TabIndex = 19;
            this.userlistBox1.ToolTip.Size = new System.Drawing.Size(6, 7);
            // 
            // EditAccounForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 274);
            this.Controls.Add(this.userlistBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rolecomboBox1);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.logintextBox2);
            this.Controls.Add(this.rsButton3);
            this.Controls.Add(this.rsButton2);
            this.Controls.Add(this.rsButton1);
            this.Controls.Add(this.approveButton3);
            this.Controls.Add(this.deleteUserbutton2);
            this.Controls.Add(this.createUserButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "EditAccounForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать аккаунты";
            ((System.ComponentModel.ISupportInitialize)(this.rolecomboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createUserButton1;
        private System.Windows.Forms.Button deleteUserbutton2;
        private System.Windows.Forms.Button approveButton3;
        private RsDesign.Controls.STD.RsButton rsButton1;
        private RsDesign.Controls.STD.RsButton rsButton2;
        private RsDesign.Controls.STD.RsButton rsButton3;
        private RsDesign.Controls.STD.RsTextBox logintextBox2;
        private RsDesign.Controls.STD.RsTextBox passwordtextBox2;
        private RsDesign.Controls.STD.RsComboBox rolecomboBox1;
        private RsDesign.Controls.STD.RsTextBox textBox1;
        private RsDesign.Controls.STD.RsListBox userlistBox1;
    }
}