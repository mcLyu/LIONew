using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MasterLIO.Forms
{
    public partial class ExerciseForm : Form
    {
        List<Char> list;
        int index;
        Exercise exercise;
        bool isRuning;
        Stopwatch watch;
        Stats stats;
        private void clearAll()
        {
            list = exercise.getTextsAsArrayChar();

            index = 0;
            difficultyProgressBar.Minimum = 0;
            difficultyProgressBar.Maximum = list.Count;
            isRuning = true;
            listBox1.Items.Clear();
            listBox1.Refresh();
            timer1.Enabled = true;
            timer1.Start();
            watch = new Stopwatch();
            watch.Start();
            stats = new Stats();
        }


        public ExerciseForm()
        {
            InitializeComponent();
            exercise = Session.CurrentExercise;
            list = exercise.getTextsAsArrayChar();

            stats = new Stats();

            pictureBox1.Load("1.jpg");

            index = 0;
            difficultyProgressBar.Minimum = 0;
            difficultyProgressBar.Maximum = list.Count;
            isRuning = true;

            watch = new Stopwatch();
            watch.Start();

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            double errorsCount = stats.Missed;
            double maxErrorsCount = exercise.maxErrors;


            int assigment = (int)(5 * (1 - errorsCount / maxErrorsCount));

            if (index < list.Count && listBox1.Items.Count < 4)
            {
                listBox1.Items.Add(list[index]);
                index++;

            }


            double speedDouble = (double)stats.Total / watch.Elapsed.Seconds;

            if (stats.Missed >= exercise.maxErrors)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                isRuning = false;
                timer1.Stop();
                watch.Stop();
                watch.Reset();

                Session.CurrentResultInfo = new ExerciseResultInfo(exercise, new DateTime(), stats.Missed, assigment, Math.Round(speedDouble, 1), watch.Elapsed.Seconds);
                ExeciseResultForm execiseResult = new ExeciseResultForm();
                execiseResult.ShowDialog();
                int command = execiseResult.getCommand();
                execiseResult.Close();
                if (command == 1)
                {
                    clearAll();
                }

                if (command == 2)
                {
                    this.Close();
                }
            }

            if (stats.Correct == list.Count)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Win!!!!");
                timer1.Stop();
                watch.Stop();
                isRuning = false;

                ExerciseResultInfo result = new ExerciseResultInfo(exercise, new DateTime(), stats.Missed, assigment, Math.Round(speedDouble, 1), watch.Elapsed.Seconds);

                Statistic stat = new Statistic(Session.UserId);
                stat.addResult(result);
                DBUtils.saveUserStatictis(stat);

                Session.CurrentResultInfo = result;


                ExeciseResultForm execiseResult = new ExeciseResultForm();
                execiseResult.ShowDialog();
                int command = execiseResult.getCommand();
                execiseResult.Close();
                if (command == 1)
                {
                    clearAll();
                }

                if (command == 2)
                {
                    this.Close();
                }

            }
        }



        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isRuning && listBox1.Items.Count > 0)
            {

                Char keyChar = e.KeyChar;
                Char firstChar = (Char)listBox1.Items[0];

                if (firstChar.Equals(keyChar))
                {
                    listBox1.Items.Remove(listBox1.Items[0]);
                    listBox1.Refresh();
                    stats.Update(true);
                    difficultyProgressBar.Value = stats.Correct;
                }
                else
                {
                    stats.Update(false);
                }
                double speedDouble = (double)stats.Total / watch.Elapsed.Seconds;
                lblCorrect.Text = "Правильно: " + stats.Correct;
                lblMissed.Text = "Ошибок: " + stats.Missed;
                speed.Text = "Скорость: " + Math.Round(speedDouble, 1) + "сим/c";

            }
        }


    }


    class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;
        public void Update(bool correctKey)
        {
            Total++;
            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }
            Accuracy = 100 * Correct / (Missed + Correct);
        }
    }

}
