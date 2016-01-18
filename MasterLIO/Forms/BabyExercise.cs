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
    public partial class BabyExercise : Form
    {
        List<Char> list;
        int index;
        Exercise exercise;
        bool isRuning;
        Stopwatch watch;
        Stats stats;
        int currentLabel;
        bool mistake = false;
        bool isOpening = true;
        bool isShuting = false;
        int exerciseType;
        List<Label> listOfBox = new List<Label>();


        private void updateRow()
        {
            
            currentLabel = 0;
            isShuting = false;
            timer1.Start();
        }
        private void clearAll()
        {
           
            list = exercise.getTextsAsArrayChar();

            index = 0;
            currentLabel = 0;
            difficultyProgressBar.Minimum = 0;
            difficultyProgressBar.Maximum = list.Count;
            isRuning = true;
            timer2.Enabled = true;
            timer2.Start();
            watch = new Stopwatch();
            watch.Start();
            stats = new Stats();
            foreach (Label labl in listOfBox)
            {
                labl.BackColor = Color.Blue;
            }

        }

        private void initBoxList(){
            for(int i = 0;i<5;i++) listOfBox[i].Text = "";

                    for(int i = index;i<index+5;i++) {
                        if (i >= list.Count) break;
                        listOfBox[i % 5 ].Text = list[i].ToString();
                    }

                    foreach (Label labl in listOfBox)
                    {
                        labl.BackColor = SystemColors.ActiveCaption;
                    }
        }
        public BabyExercise()
        {
            InitializeComponent();

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
            panel1.Visible = true;
            exerciseType = 1;

            listOfBox.Add(Letter1);
            listOfBox.Add(Letter2);
            listOfBox.Add(Letter3);
            listOfBox.Add(Letter4);
            listOfBox.Add(Letter5);

            initBoxList();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isShuting)
            {
                if (isOpening == true)
                {
                    panel1.Height += 5;
                }
                else
                {
                    panel1.Height -= 5;
                }
                if (panel1.Height > 120)
                {
                    isOpening = false;
                    isShuting = true;

                    timer1.Stop();

                }
                if (panel1.Height == 0)
                {
                    isOpening = true;
                    initBoxList();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isShuting)
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



                double speedDouble = (double)stats.Total / watch.Elapsed.Seconds;

                if (stats.Missed >= exercise.maxErrors && stats.Missed != 0)
                {

                    //listBox1.Items.Add("Game over");
                    isRuning = false;
                    timer2.Stop();
                    watch.Stop();

                    Session.CurrentResultInfo = new ExerciseResultInfo(exercise, DateTime.Today, stats.Missed, assigment, Math.Round(speedDouble, 1), watch.Elapsed.Seconds);
                    ExeciseResultForm execiseResult = new ExeciseResultForm();
                    execiseResult.ShowDialog();
                    int command = execiseResult.getCommand();
                    execiseResult.Close();
                    if (command == 1)
                    {
                        clearAll();
                        initBoxList();
                    }

                    if (command == 2)
                    {
                        this.Close();
                    }
                }

                if (stats.Correct == list.Count)
                {
                    //listBox1.Items.Clear();
                    //listBox1.Items.Add("Win!!!!");
                    timer2.Stop();
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
                        initBoxList();
                    }

                    if (command == 2)
                    {
                        DBUtils.saveUserStatictis(stat);
                        this.Close();
                    }

                }
            }
        }

        private void BabyExercise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isRuning && index<list.Count && isShuting)
            {

                Char keyChar = e.KeyChar;
                Char firstChar = (Char)listOfBox[currentLabel].Text[0];

                if (firstChar.Equals(keyChar))
                {
                    listOfBox[currentLabel].BackColor = Color.Red;//Смена цвета
                    currentLabel++;
                    index++;
                    
                    stats.Update(true);
                    difficultyProgressBar.Value = stats.Correct;
                }
                else
                {
                    if (stats.Missed <= exercise.maxErrors)
                    {
                       stats.Update(false);
                        //mistake = true;
                        //timer2.Start();
                    }
                }
                double speedDouble = (double)stats.Total / watch.Elapsed.Seconds;
                lblCorrect.Text = "Правильно: " + stats.Correct;
                lblMissed.Text = "Ошибок: " + stats.Missed + "/" + exercise.maxErrors;
                speed.Text = "Скорость: " + Math.Round(speedDouble, 1) + "сим/c";
                if (currentLabel == 5 && isRuning && index!= list.Count)
                {
                    updateRow();
                }

            }
        }

     
    }
}
