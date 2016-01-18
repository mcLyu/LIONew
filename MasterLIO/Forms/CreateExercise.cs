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
    public partial class CreateExercise : Form
    {

        public CreateExercise()
        {
            InitializeComponent();
        }

        private void validateAll()
        {
            if ((textBox1.Text != "")
                && (areasTextBox.Text!=""))
            {
                textBox1.BackColor = Color.GreenYellow;
                areasTextBox.BackColor = Color.GreenYellow;
                richTextBox1.ReadOnly = false;
                richTextBox1.BackColor = Color.White;
            }
        }

        private void selectAreaButton_Click(object sender, EventArgs e)
        {
            List<KeyboardArea> areasList = new List<KeyboardArea>();
            Form f = new SelectAreaForm(ref areasList);
            f.ShowDialog();


            areasTextBox.Text = Exercise.getAreasAsString(areasList);
            textBox4.Text = areasList.Count.ToString();

            areasTextBox.BackColor = Color.GreenYellow;

            if (textBox1.Text == "")
            {
                List<Exercise> exercises = DBUtils.LoadExercises(areasList.Count);
                int maxnum = 0;
                int num;
                foreach (Exercise exercise in exercises)
                {
                    num = Convert.ToInt16(exercise.id.ToString().Substring(1));
                    if (num > maxnum) maxnum = num;
                }

                maxnum++;
                textBox1.Text = "Упражнение " + maxnum;
                textBox1.BackColor = Color.GreenYellow;
            }

            validateAll();
        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.BackColor = Color.GreenYellow;

            validateAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog() { Filter = "Файлы упражнений(*.exercise)|*.exercise" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openFileDialog1.FileName;
                string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                for (int i = 0; i < lines.Length;i++ )
                {
                    lines[i] = lines[i].Substring(lines[i].IndexOf('=')+1);
                }
                textBox1.Text = lines[0];
                richTextBox1.Text = lines[1];
                textBox4.Text = lines[2];
                areasTextBox.Text = lines[3];
                numericUpDown3.Value = Convert.ToDecimal(lines[4]);
                numericUpDown2.Value = Convert.ToDecimal(lines[5]);
            }
            validateAll();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String text = richTextBox1.Text;
            int maxErrors = (int) numericUpDown2.Value;
            int maxTime = (int) numericUpDown3.Value;
            List<KeyboardArea> areas = Exercise.getAreasList(areasTextBox.Text);
            int level = Convert.ToInt32(textBox4.Text);

            Exercise exercise = new Exercise(name,text,areas,maxErrors,maxTime,level);
            DBUtils.SaveExercise(exercise);
        }
    }
}
