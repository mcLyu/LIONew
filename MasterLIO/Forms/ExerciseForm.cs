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
using System.IO;
using System.Threading;

namespace MasterLIO.Forms
{
    public partial class ExerciseForm : Form
    {
        Dictionary<Char, Point> points = new Dictionary<char, Point>();

        List<Char> list;
        int index;
        Exercise exercise;
        bool isRuning;
        Stopwatch watch;
        Stats stats;
        bool mistake = false;
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
            initPoints();
            if (Session.mode == 0)
                initBabyMode();
            else
                initStandartMode();


        }

        public void initStandartMode()
        {
            exercise = Session.CurrentExercise;
            list = exercise.getTextsAsArrayChar();
            this.BackColor = Color.AliceBlue;

            this.Refresh();

            stats = new Stats();

            pictureBox1.Load("1.jpg");

            index = 0;
            difficultyProgressBar.Minimum = 0;
            difficultyProgressBar.Maximum = list.Count;
            isRuning = true;

            watch = new Stopwatch();
            watch.Start();
        }

        public void initBabyMode()
        {
            exercise = Session.CurrentExercise;
            list = exercise.getTextsAsArrayChar();
            this.BackColor = Color.Pink;
            this.Refresh();

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
            int assigment;

            if (maxErrorsCount == 0)
            {
                assigment = (int)Math.Round(5 * (1 - errorsCount));
            }
            else
            {
                assigment = (int)Math.Round(5 * (1 - errorsCount / maxErrorsCount));

            }

            if (index < list.Count && listBox1.Items.Count < 4)
            {

                listBox1.Items.Add(list[index].ToString());
                index++;

            }


            double speedDouble = (double)stats.Total / watch.Elapsed.Seconds;


            if (watch.Elapsed.Seconds > exercise.maxTime && exercise.maxTime != 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Time is out.");
                assigment = 0;
                isRuning = false;
                timer1.Stop();
                watch.Stop();

                Session.CurrentResultInfo = new ExerciseResultInfo(exercise, DateTime.Today, stats.Missed, assigment, Math.Round(speedDouble, 1), watch.Elapsed.Seconds);
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

            if (stats.Missed >= exercise.maxErrors && stats.Missed != 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                isRuning = false;
                timer1.Stop();
                watch.Stop();

                Session.CurrentResultInfo = new ExerciseResultInfo(exercise, DateTime.Today, stats.Missed, assigment, Math.Round(speedDouble, 1), watch.Elapsed.Seconds);
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

                ExerciseResultInfo result = new ExerciseResultInfo(exercise, DateTime.Today, stats.Missed, assigment, Math.Round(speedDouble, 1), watch.Elapsed.Seconds);

                Statistic stat = new Statistic(Session.user.userId);
                stat.addResult(result);


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
                    DBUtils.saveUserStatictis(stat);
                    this.Close();
                }

            }
        }


        Graphics g;
        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char keyChar = e.KeyChar;
            g = pictureBox1.CreateGraphics();

            if (points.ContainsKey(keyChar))
            {
                Point point = points[keyChar];
                Pen pen = new Pen(Brushes.Indigo, 5); 
                if (keyChar != ' ')
                g.DrawPolygon(pen, new Point[] { point, new Point(point.X + 30, point.Y), new Point(point.X + 30, point.Y + 30), new Point(point.X, point.Y + 30) });
                else g.DrawPolygon(pen, new Point[] { point, new Point(point.X + 250, point.Y), new Point(point.X + 250, point.Y + 30), new Point(point.X, point.Y + 30) });
            }
                if (isRuning && listBox1.Items.Count > 0)
                {

                
                    Char firstChar = Convert.ToChar(listBox1.Items[0]);

                    if (firstChar.Equals(keyChar))
                    {
                        listBox1.Items.Remove(listBox1.Items[0]);
                        listBox1.Refresh();
                        stats.Update(true);
                        difficultyProgressBar.Value = stats.Correct;
                    }
                    else
                    {
                        if (stats.Missed <= exercise.maxErrors)
                        {
                            stats.Update(false);
                            mistake = true;
                            timer2.Start();
                        }
                    }
                    double speedDouble = (double)stats.Total / watch.Elapsed.Seconds;
                    lblCorrect.Text = "Правильно: " + stats.Correct;
                    lblMissed.Text = "Ошибок: " + stats.Missed;
                    speed.Text = "Скорость: " + Math.Round(speedDouble, 1) + "сим/c";

                }
                Thread.Sleep(100);
                pictureBox1.Invalidate();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (mistake)
            {
                mistake = false;
                listBox1.BackColor = Color.Red;
            }
            else
            {
                listBox1.BackColor = Color.Azure;
                timer2.Stop();

            }
        }

        private void ExerciseForm_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox1.Load("1.jpg");
        }

        private void initPoints()
        {
            points.Add('а', new Point(283, 75));
            points.Add('б', new Point(452, 109));
            points.Add('в', new Point(243, 76));
            points.Add('г', new Point(382, 43));
            points.Add('д', new Point(472, 77));
            points.Add('е', new Point(304, 44));
            points.Add('ж', new Point(510, 77));
            points.Add('з', new Point(496, 44));
            points.Add('и', new Point(339, 108));
            points.Add('й', new Point(153, 43));
            points.Add('к', new Point(268, 43));
            points.Add('л', new Point(431, 75));
            points.Add('м', new Point(300, 108));
            points.Add('н', new Point(342, 42));
            points.Add('о', new Point(395, 76));
            points.Add('п', new Point(319, 76));
            points.Add('р', new Point(357, 75));
            points.Add('с', new Point(263, 109));
            points.Add('т', new Point(375, 108));
            points.Add('у', new Point(229, 44));
            points.Add('ф', new Point(168, 76));
            points.Add('х', new Point(534, 42));
            points.Add('ц', new Point(192, 43));
            points.Add('ч', new Point(224, 106));
            points.Add('ш', new Point(419, 43));
            points.Add('щ', new Point(456, 43));
            points.Add('ъ', new Point(574, 42));
            points.Add('ы', new Point(204, 76));
            points.Add('ь', new Point(415, 108));
            points.Add('э', new Point(548, 75));
            points.Add('ю', new Point(489, 109));
            points.Add('я', new Point(187, 109));
            points.Add('1', new Point(135, 12));
            points.Add('2', new Point(175, 12));
            points.Add('3', new Point(215, 12));
            points.Add('4', new Point(255, 12));
            points.Add('5', new Point(290, 12));
            points.Add('6', new Point(330, 12));
            points.Add('7', new Point(365, 12));
            points.Add('8', new Point(403, 12));
            points.Add('9', new Point(442, 12));
            points.Add('0', new Point(481, 12));
            points.Add(' ', new Point(230, 140));
        }


        /*String stringPoints = "";


        private void button1_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText("ппцнах.txt", stringPoints);
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            stringPoints += " " + e.X;
            stringPoints += "," + e.Y;
            stringPoints += "    ";
        }*/


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
