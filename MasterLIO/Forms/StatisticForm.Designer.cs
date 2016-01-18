﻿namespace MasterLIO.Forms
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statisticSearchButton1 = new System.Windows.Forms.Button();
            this.statisticChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorCounttextBox3 = new System.Windows.Forms.TextBox();
            this.exerciseSpeedtextBox4 = new System.Windows.Forms.TextBox();
            this.assessmentTextBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.exerciseNumbercomboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер упражнения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата прохождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во ошибок:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Скорость:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Оценка:";
            // 
            // statisticSearchButton1
            // 
            this.statisticSearchButton1.Location = new System.Drawing.Point(392, 144);
            this.statisticSearchButton1.Name = "statisticSearchButton1";
            this.statisticSearchButton1.Size = new System.Drawing.Size(146, 35);
            this.statisticSearchButton1.TabIndex = 5;
            this.statisticSearchButton1.Text = "Найти";
            this.statisticSearchButton1.UseVisualStyleBackColor = true;
            this.statisticSearchButton1.Click += new System.EventHandler(this.statisticSearchButton1_Click);
            // 
            // statisticChart1
            // 
            chartArea2.Name = "ChartArea1";
            this.statisticChart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.statisticChart1.Legends.Add(legend2);
            this.statisticChart1.Location = new System.Drawing.Point(291, 24);
            this.statisticChart1.Name = "statisticChart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.statisticChart1.Series.Add(series2);
            this.statisticChart1.Size = new System.Drawing.Size(247, 107);
            this.statisticChart1.TabIndex = 6;
            this.statisticChart1.Text = "chart1";
            // 
            // errorCounttextBox3
            // 
            this.errorCounttextBox3.Location = new System.Drawing.Point(158, 104);
            this.errorCounttextBox3.Name = "errorCounttextBox3";
            this.errorCounttextBox3.Size = new System.Drawing.Size(100, 22);
            this.errorCounttextBox3.TabIndex = 9;
            // 
            // exerciseSpeedtextBox4
            // 
            this.exerciseSpeedtextBox4.Location = new System.Drawing.Point(158, 132);
            this.exerciseSpeedtextBox4.Name = "exerciseSpeedtextBox4";
            this.exerciseSpeedtextBox4.Size = new System.Drawing.Size(100, 22);
            this.exerciseSpeedtextBox4.TabIndex = 10;
            // 
            // assessmentTextBox5
            // 
            this.assessmentTextBox5.Location = new System.Drawing.Point(158, 162);
            this.assessmentTextBox5.Name = "assessmentTextBox5";
            this.assessmentTextBox5.Size = new System.Drawing.Size(100, 22);
            this.assessmentTextBox5.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // exerciseNumbercomboBox1
            // 
            this.exerciseNumbercomboBox1.FormattingEnabled = true;
            this.exerciseNumbercomboBox1.Location = new System.Drawing.Point(158, 42);
            this.exerciseNumbercomboBox1.Name = "exerciseNumbercomboBox1";
            this.exerciseNumbercomboBox1.Size = new System.Drawing.Size(100, 24);
            this.exerciseNumbercomboBox1.TabIndex = 13;
            this.exerciseNumbercomboBox1.SelectedIndexChanged += new System.EventHandler(this.exerciseNumbercomboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Пользователь";
            this.label7.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 189);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exerciseNumbercomboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.assessmentTextBox5);
            this.Controls.Add(this.exerciseSpeedtextBox4);
            this.Controls.Add(this.errorCounttextBox3);
            this.Controls.Add(this.statisticChart1);
            this.Controls.Add(this.statisticSearchButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button statisticSearchButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticChart1;
        private System.Windows.Forms.TextBox errorCounttextBox3;
        private System.Windows.Forms.TextBox exerciseSpeedtextBox4;
        private System.Windows.Forms.TextBox assessmentTextBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox exerciseNumbercomboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}