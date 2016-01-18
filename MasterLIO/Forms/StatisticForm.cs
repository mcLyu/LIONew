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

        public StatisticForm()
        {
            InitializeComponent();
            if (Session.user.role == Role.ADMIN)
            {
                comboBox1.Visible = true;
                label7.Visible = true;
                comboBox1.Items.AddRange(users.ToArray());
            }
            statisticChart1.Series["Series1"].Enabled = false;
            dateTimePicker1.Text = "";

        }

        private void statisticSearchButton1_Click(object sender, EventArgs e)
        {
            resultsInfo = statistic.getResultsByDate(dateTimePicker1.Value);
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

            exerciseId = exerciseId.Substring(exerciseId.Length - 1) + exerciseId.Substring(0,exerciseId.Length-1);

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

    }
}
