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
        Dictionary<String, ExerciseResultInfo> showResults = new Dictionary<string, ExerciseResultInfo>();

        private void updateChart(List<ExerciseResultInfo> resultsInfo)
        {
            statisticChart1.Series["Time"].Points.Clear();

            resultsInfo.Sort((x, y) =>
                    x.dateOfPassing.CompareTo(y.dateOfPassing));

            Dictionary<DateTime, List<int>> biddlo = new Dictionary<DateTime, List<int>>();
            foreach (ExerciseResultInfo result in resultsInfo)
            {
                if (!biddlo.ContainsKey(result.dateOfPassing))
                    biddlo.Add(result.dateOfPassing, new List<int>());

                biddlo[result.dateOfPassing].Add(result.assesment);
            }

            foreach (DateTime time in biddlo.Keys)
            {
                double sum = 0;
                for (int i = 0; i < biddlo[time].Count; i++) sum += biddlo[time][i];
                statisticChart1.Series["Time"].Points.AddXY(time, Math.Round(sum / biddlo[time].Count, 1));
            }


            DateTime minDate = dateTimePicker1.Value.AddDays(-3);
            DateTime maxDate = dateTimePicker1.Value.AddDays(3);
            statisticChart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            statisticChart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

            errorCounttextBox3.Text = "";
            exerciseSpeedtextBox4.Text = "";
            assessmentTextBox5.Text = "";
            exerciseNumbercomboBox1.Text = "";
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
            List<int> checkNums = new List<int>();
            showResults.Clear();
            if (resultsInfo.Count != 0)
            {
                exerciseNumbercomboBox1.Items.Clear();
                exerciseNumbercomboBox1.Text = "";
                int i = 0;
                foreach (ExerciseResultInfo result in resultsInfo)
                {
                    i++;
                    String currentListName = "";
                    String level = result.level.ToString();
                    String exerciseNum = result.exerciseId.ToString().Substring(1);// MAGIC!
                    int id = Convert.ToInt32(level + exerciseNum);

                    if (checkNums.Contains(id))
                    {
                        int j = 0;
                        foreach (ExerciseResultInfo eqResult in showResults.Values)
                        {
                            if (eqResult.exerciseId == id)
                            {
                                j++;
                            }
                        }
                        currentListName = "№" + exerciseNum + ", ур-нь " + level + " Попытка " + j;
                    }
                    else currentListName = "№" + exerciseNum + ", ур-нь " + level;
                    exerciseNumbercomboBox1.Items.Add(currentListName);

                    showResults.Add(currentListName, result);
                    checkNums.Add(id);


                    // exerciseNumbercomboBox1.Items[0].
                }
            }
            else
            {
                exerciseNumbercomboBox1.Items.Clear();
                exerciseNumbercomboBox1.Text = "";
                MessageBox.Show("Результатов по данному дню не найдено.");

            }

            allUserStatistic = statistic.getResultsInfo();

            updateChart(allUserStatistic);
            if (exerciseNumbercomboBox1.Items.Count > 0)
            {
                exerciseNumbercomboBox1.SelectedItem = exerciseNumbercomboBox1.Items[0];
            }
        }

        private void exerciseNumbercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExerciseResultInfo currentResultInfo = showResults[exerciseNumbercomboBox1.SelectedItem.ToString()];
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
     
        private void StatisticForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                UserProfile usr = (UserProfile)comboBox1.Items[i];
                if (Session.user.userId.Equals(usr.userId))
                {
                    comboBox1.SelectedItem = comboBox1.Items[i];
                    break;
                }
            }
        }

        private void statisticChart1_MouseClick(object sender, MouseEventArgs e)
        {
            var x = statisticChart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            var y = statisticChart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
            DateTime test = DateTime.FromOADate(x);
            test = test.AddHours(4);
            dateTimePicker1.Value = test.Date;

            allUserStatistic = statistic.getResultsInfo();

            updateChart(allUserStatistic);
        }

    }
}
