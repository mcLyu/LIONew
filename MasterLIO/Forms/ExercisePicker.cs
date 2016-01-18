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
        private void fillData(int level)
        {
            List<Exercise> list = DBUtils.LoadExercises(level);
            dataGridView1.Rows.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                string[] row1 = new string[2];
                row1[0] = list[i].name;
                if (list[i].text.Length > 10)
                {
                    row1[1] = list[i].text.Substring(0, 10);
                }
                else
                {
                    row1[1] = list[i].text;
                }
                dataGridView1.Rows.Add(row1);

            }
        }
        public ExercisePicker()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.Items.Add("Уровень 1");
            comboBox1.Items.Add("Уровень 2");
            comboBox1.Items.Add("Уровень 3");
            comboBox1.Items.Add("Уровень 4");
            comboBox1.Items.Add("Уровень 5");
            comboBox1.Items.Add("Уровень 6");
            comboBox1.Items.Add("Уровень 7");
            comboBox1.Items.Add("Уровень 8");
            comboBox1.Items.Add("Уровень 9");
           

            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].HeaderText = "Упражнение";
            dataGridView1.Columns[1].HeaderText = "Фрагмент";

            comboBox1.SelectedIndex = 0;
            fillData(comboBox1.SelectedIndex + 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillData(comboBox1.SelectedIndex + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int level = comboBox1.SelectedIndex + 1;
            List<Exercise>  list = DBUtils.LoadExercises(level);
            Session.CurrentExercise = list[dataGridView1.SelectedRows[0].Index];
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetExerciseForm());
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int level = comboBox1.SelectedIndex + 1;
            List<Exercise> list = DBUtils.LoadExercises(level);
            Session.CurrentExercise = list[dataGridView1.SelectedRows[0].Index];
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetExerciseForm());
        }
    }
}
