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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void ExerciseButton_Click(object sender, EventArgs e)
        {
            //Session.CurrentExercise = new Exercise();
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetExercisePickerForm()); 
        }

        private void statistic_Click(object sender, EventArgs e)
        {
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetStatisticForm()); 
        }

        private void CreateExercsieButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetCreateExercsieForm()); 
        }

        private void EditAccountButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetEditAccounForm()); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа 'Клавиатурный тренажер' предназначена для обучения пользователей 'слепому' методу печати на клавиатуре. Доступны упражнения, включающие различные зоны клавиатуры, ограничивающие пользователя во времени и количестве ошибок. Ведется пользовательская статистика, доступная для просмотра. В режиме администратора позволяется создавать упражнения.","О программе");
        }

        private void оСоздателяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчиками программы 'Клавиатурный тренажер' являются студенты группы 6413 университета СНИУ: \n-Любайкин И.В.\n-Иванов А.Г.\n-Отрешко А.А.\n", "О создателях");
        }
    }
}
