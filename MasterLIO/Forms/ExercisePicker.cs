using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterLIO.Forms
{
    public partial class ExercisePicker : Form
    {
        public ExercisePicker()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            comboBox1.Items.Add("Уровень 1");
            comboBox1.Items.Add("Уровень 2");
            comboBox1.Items.Add("Уровень 3");
            comboBox1.Items.Add("Уровень 4");
            comboBox1.Items.Add("Уровень 5");
            comboBox1.Items.Add("Уровень 6");
            comboBox1.Items.Add("Уровень 7");
            comboBox1.Items.Add("Уровень 8");
            comboBox1.Items.Add("Уровень 9");

            comboBox1.SelectedIndex = 0;

            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].HeaderText = "Упражнение";
            dataGridView1.Columns[1].HeaderText = "Описание";
            string[] row1 = { "One", "1" };
            string[] row2 = { "Two", "2" };

            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
        }
    }
}
