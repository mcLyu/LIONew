using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MasterLIO.Forms
{
    public partial class StatisticForm : Form
    {
        private static Statistic statistic = DBUtils.GetUserStatistic(Session.user.userId);
        List<UserProfile> users = DBUtils.LoadAllUsers();
        private List<ExerciseResultInfo> resultsInfo;
        private List<ExerciseResultInfo> allUserStatistic;

        private void updateChart(List<ExerciseResultInfo> resultsInfo)
        {
            statisticChart1.Series["Time"].Points.Clear();

            resultsInfo.Sort((x, y) =>
                    x.dateOfPassing.CompareTo(y.dateOfPassing));

            foreach (ExerciseResultInfo result in resultsInfo)
            {
                statisticChart1.Series["Time"].Points.AddXY(result.dateOfPassing, result.assesment);
            }

            DateTime minDate = dateTimePicker1.Value.AddDays(-3);
            DateTime maxDate = dateTimePicker1.Value.AddDays(3);
            statisticChart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            statisticChart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();


        }

        public StatisticForm()
        {
            InitializeComponent();
            statisticChart1.Series["Time"].IsVisibleInLegend = false;
            statisticChart1.Series["Time"].BorderWidth = 3;

            var d = new DateTime(2013, 04, 01);
            statisticChart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            statisticChart1.ChartAreas[0].AxisX.Interval = 1;
            statisticChart1.ChartAreas[0].AxisX.IntervalOffset = 1;

            statisticChart1.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            statisticChart1.ChartAreas[0].AxisX.LabelStyle.Enabled = true;

            if (Session.user.role == Role.ADMIN)
            {
                comboBox1.Visible = true;
                label7.Visible = true;
                comboBox1.Items.AddRange(users.ToArray());
            }
            dateTimePicker1.Text = "";

        }

        private void statisticSearchButton1_Click(object sender, EventArgs e)
        {
            resultsInfo = statistic.getResultsByDate(dateTimePicker1.Value);
            allUserStatistic = statistic.getResultsInfo();

            updateChart(allUserStatistic);


            if (resultsInfo != null)
            {
                exerciseNumbercomboBox1.Items.Clear();
                exerciseNumbercomboBox1.Text = "";
                foreach (ExerciseResultInfo result in resultsInfo)
                {
                    String level = result.level.ToString();
                    String exerciseNum = result.exerciseId.ToString().Substring(1);// MAGIC!
                    exerciseNumbercomboBox1.Items.Add("№" + exerciseNum + ", ур-нь " + level);
                }
            }
            else
            {
                exerciseNumbercomboBox1.Items.Clear();
                exerciseNumbercomboBox1.Text = "";
            }
        }

        private void exerciseNumbercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            exerciseNumbercomboBox1.Text = "";
            int exerciseNum = Convert.ToInt32(convertToExersiceId(exerciseNumbercomboBox1.SelectedItem.ToString()));
            ExerciseResultInfo currentResultInfo = getResultInfoByNum(exerciseNum);
            errorCounttextBox3.Text = currentResultInfo.errorsCount.ToString();
            exerciseSpeedtextBox4.Text = currentResultInfo.speed.ToString();
            assessmentTextBox5.Text = currentResultInfo.assesment.ToString();
        }

        private ExerciseResultInfo getResultInfoByNum(int exerciseNum)
        {
            ExerciseResultInfo exercise = null;
            foreach (ExerciseResultInfo result in resultsInfo)
            {
                if (result.exerciseId == exerciseNum)
                    exercise = result;
            }
            return exercise;
        }

        private int convertToExersiceId(string stringName)
        {
            string exerciseId = "";

            string pattern = @"\b(\d)\b";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(stringName);

            while (match.Success)
            {
                exerciseId += match.Groups[1].Value;

                match = match.NextMatch();
            }

            exerciseId = exerciseId.Substring(exerciseId.Length - 1) + exerciseId.Substring(0, exerciseId.Length - 1);

            return Convert.ToInt32(exerciseId);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserProfile currentUser = null;
            foreach (UserProfile user in users)
            {
                if (user.login.Equals(comboBox1.SelectedItem.ToString()))
                    currentUser = user;
            }
            statistic = DBUtils.GetUserStatistic(currentUser.userId);
        }


        private void statisticChart1_MouseClick(object sender, MouseEventArgs e)
        {
            var x = statisticChart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            var y = statisticChart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
            DateTime test = DateTime.FromOADate(x);
            dateTimePicker1.Value = test;

            allUserStatistic = statistic.getResultsInfo();

            updateChart(allUserStatistic);
        }

      
    }
}
