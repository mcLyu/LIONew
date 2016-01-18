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
    public enum EXERCISE_MODE { STANDART, BABY }

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
            dataGridView1.MouseWheel += new MouseEventHandler(dataGridView1_MouseWheel);
            radioButton1.Checked = true;
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
            dataGridView1.Focus();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillData(comboBox1.SelectedIndex + 1);
            dataGridView1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int level = comboBox1.SelectedIndex + 1;
                List<Exercise> list = DBUtils.LoadExercises(level);
                Session.CurrentExercise = list[dataGridView1.SelectedRows[0].Index];
                if (radioButton1.Checked)
                {
                    Session.mode = 1;
                    FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetExerciseForm());

                }
                else if (radioButton2.Checked)
                {
                    Session.mode = 0;
                    FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetExerciseBabyForm());

                }
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int level = comboBox1.SelectedIndex + 1;
                List<Exercise> list = DBUtils.LoadExercises(level);
                Session.CurrentExercise = list[dataGridView1.SelectedRows[0].Index];

                if (radioButton1.Checked)
                {
                    Session.mode = 1;
                    FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetExerciseForm());

                }
                else if (radioButton2.Checked)
                {
                    Session.mode = 0;
                    FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetExerciseBabyForm());

                }
            }
        }

        private void ExercisePicker_Load(object sender, EventArgs e)
        {
           
            fillData(comboBox1.SelectedIndex + 1);
            dataGridView1.TabIndex = 0;
        }

        void dataGridView1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int currentIndex = dataGridView1.SelectedRows[0].Index;

                if (e.Delta > 0 && currentIndex > 0)
                {
                    currentIndex--;
                    dataGridView1.Rows[currentIndex].Selected = true;
                }
                else if (e.Delta < 0 && currentIndex < dataGridView1.Rows.Count - 1)
                {
                    currentIndex++;
                    dataGridView1.Rows[currentIndex].Selected = true;
                }
            }
        }

    }
}
