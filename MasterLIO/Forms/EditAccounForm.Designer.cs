﻿namespace MasterLIO.Forms
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userlistBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logintextBox2 = new System.Windows.Forms.TextBox();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rolecomboBox1 = new System.Windows.Forms.ComboBox();
            this.createUserButton1 = new System.Windows.Forms.Button();
            this.deleteUserbutton2 = new System.Windows.Forms.Button();
            this.approveButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Поиск...";
            this.textBox1.Visible = false;
            // 
            // userlistBox1
            // 
            this.userlistBox1.FormattingEnabled = true;
            this.userlistBox1.Location = new System.Drawing.Point(9, 50);
            this.userlistBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userlistBox1.Name = "userlistBox1";
            this.userlistBox1.Size = new System.Drawing.Size(114, 108);
            this.userlistBox1.TabIndex = 1;
            this.userlistBox1.SelectedIndexChanged += new System.EventHandler(this.userlistBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // logintextBox2
            // 
            this.logintextBox2.Location = new System.Drawing.Point(211, 20);
            this.logintextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logintextBox2.Name = "logintextBox2";
            this.logintextBox2.Size = new System.Drawing.Size(76, 20);
            this.logintextBox2.TabIndex = 4;
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Location = new System.Drawing.Point(211, 41);
            this.passwordtextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.Size = new System.Drawing.Size(76, 20);
            this.passwordtextBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(163, 64);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Показать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Роль:";
            // 
            // rolecomboBox1
            // 
            this.rolecomboBox1.FormattingEnabled = true;
            this.rolecomboBox1.Location = new System.Drawing.Point(200, 102);
            this.rolecomboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rolecomboBox1.Name = "rolecomboBox1";
            this.rolecomboBox1.Size = new System.Drawing.Size(92, 21);
            this.rolecomboBox1.TabIndex = 8;
            // 
            // createUserButton1
            // 
            this.createUserButton1.Location = new System.Drawing.Point(140, 138);
            this.createUserButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createUserButton1.Name = "createUserButton1";
            this.createUserButton1.Size = new System.Drawing.Size(56, 19);
            this.createUserButton1.TabIndex = 9;
            this.createUserButton1.Text = "Создать";
            this.createUserButton1.UseVisualStyleBackColor = true;
            this.createUserButton1.Click += new System.EventHandler(this.createUserButton1_Click);
            // 
            // deleteUserbutton2
            // 
            this.deleteUserbutton2.Location = new System.Drawing.Point(200, 138);
            this.deleteUserbutton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteUserbutton2.Name = "deleteUserbutton2";
            this.deleteUserbutton2.Size = new System.Drawing.Size(56, 19);
            this.deleteUserbutton2.TabIndex = 10;
            this.deleteUserbutton2.Text = "Удалить";
            this.deleteUserbutton2.UseVisualStyleBackColor = true;
            this.deleteUserbutton2.Click += new System.EventHandler(this.deleteUserbutton2_Click);
            // 
            // approveButton3
            // 
            this.approveButton3.Location = new System.Drawing.Point(261, 138);
            this.approveButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.approveButton3.Name = "approveButton3";
            this.approveButton3.Size = new System.Drawing.Size(76, 19);
            this.approveButton3.TabIndex = 11;
            this.approveButton3.Text = "Подтвердить";
            this.approveButton3.UseVisualStyleBackColor = true;
            this.approveButton3.Click += new System.EventHandler(this.approveButton3_Click);
            // 
            // EditAccounForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 167);
            this.Controls.Add(this.approveButton3);
            this.Controls.Add(this.deleteUserbutton2);
            this.Controls.Add(this.createUserButton1);
            this.Controls.Add(this.rolecomboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.logintextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userlistBox1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditAccounForm";
            this.Text = "EditAccounForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox userlistBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logintextBox2;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rolecomboBox1;
        private System.Windows.Forms.Button createUserButton1;
        private System.Windows.Forms.Button deleteUserbutton2;
        private System.Windows.Forms.Button approveButton3;
    }
}