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
        List<KeyboardArea> areasList  = new List<KeyboardArea>();

        public CreateExercise()
        {
            InitializeComponent();
        }

        private bool checkParams()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите название упражнения!");
                return false;
            }
            if (areasTextBox.Text == "")
            {
                MessageBox.Show("Выберите зоны клавиатуры");
                return false;
            }
            return true;
        }

        private bool validateAll()
        {
            if (textBox1.Text == "")
            {
                //MessageBox.Show("Введите название упражнения!");
                return false;
            }
            if (areasTextBox.Text=="")
            {
                //MessageBox.Show("Выберите зоны клавиатуры");
                return false;
            }

            textBox1.BackColor = Color.GreenYellow;
            areasTextBox.BackColor = Color.GreenYellow;
            richTextBox1.ReadOnly = false;
            richTextBox1.BackColor = Color.White;
            richTextBox1.MaxLength = (int)numericUpDown1.Value;
            return true;
        }

        private void selectAreaButton_Click(object sender, EventArgs e)
        {
            //areasList.Clear();
            areasTextBox.Text = "";

            Form f = new SelectAreaForm(ref areasList);
            f.ShowDialog();

            areasTextBox.Text = Exercise.getAreasAsNums(areasList);
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
                String s = Exercise.getAreasAsNums(lines[3].ToString());
                List<KeyboardArea> areas = Exercise.getAreasList(s);

                areasList.AddRange(areas);
                numericUpDown3.Value = Convert.ToDecimal(lines[4]);
                numericUpDown2.Value = Convert.ToDecimal(lines[5]);
                numericUpDown1.Value = Convert.ToDecimal(lines[1].Length);
            }
            validateAll();

        }

        //Подтвердить
        private void button4_Click(object sender, EventArgs e)
        {
            if (lastValidateCorrect())
            {
                String name = textBox1.Text;
                String text = richTextBox1.Text;
                int maxErrors = (int)numericUpDown2.Value;
                int maxTime = (int)numericUpDown3.Value;
                List<KeyboardArea> areas = Exercise.getAreasList(areasTextBox.Text);
                int level = Convert.ToInt32(textBox4.Text);

                Exercise exercise = new Exercise(name, text, areas, maxErrors, maxTime, level);
                DBUtils.SaveExercise(exercise);
                MessageBox.Show("Упражнение создано успешно.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
        }

        private bool lastValidateCorrect()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите название упражнения!");
                return false;
            }
            if (areasTextBox.Text == "")
            {
                MessageBox.Show("Выберите зоны клавиатуры");
                return false;
            }
            if (!areasUsedCorrected())
            {
                MessageBox.Show("В тексте упражнения есть символы, не принадлежащие выбранным зонам!");
                return false;
            }
            return true;
        }

        private bool areasUsedCorrected()
        {
            List<KeyboardArea> areas = Exercise.getAreasList(Exercise.getAreasAsString(areasList));
            foreach(char s in richTextBox1.Text)
            {
                char ch = Char.ToLower(s);
                bool b = false;
                foreach (KeyboardArea area in areas)
                {
                    if (AreaHelper.getAreaSymbols(area).Contains(ch))
                    {
                        b = true;
                        break;
                    }
                }
                if (b == false) return b;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!checkParams())
            {
                return;
            }
            Random rnd = new Random();
            List<char> exerChars = new List<char>();
            foreach (KeyboardArea area in areasList)
            {
                char[] symbols = AreaHelper.getAreaSymbols(area);
                exerChars.AddRange(symbols);
            }
            
            int maxGen = exerChars.Count;
            String exerciseText = "";

            for (int i = 0; i < numericUpDown1.Value; i++)
                exerciseText += exerChars[rnd.Next(0, maxGen)];

            richTextBox1.Text = exerciseText;
        }
    }
}
