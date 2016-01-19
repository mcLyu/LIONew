using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MasterLIO.Forms
{
    public partial class SelectAreaForm : Form
    {
        Graphics graph;
        List<Point> points;
        List<KeyboardArea> areasList;

        public SelectAreaForm(ref List<KeyboardArea> areasList)
        {
            InitializeComponent();
            this.areasList = areasList;
            points = new List<Point>();
            pictureBox1.Load("2.jpg");
            checkOldAreas();
        }

        private void checkOldAreas()
        {
            if (areasList.Contains(KeyboardArea.ONE)) checkBox1.Checked = true;
            if (areasList.Contains(KeyboardArea.TWO)) checkBox2.Checked = true;
            if (areasList.Contains(KeyboardArea.THREE)) checkBox3.Checked = true;
            if (areasList.Contains(KeyboardArea.FOUR)) checkBox4.Checked = true;
            if (areasList.Contains(KeyboardArea.FIVE)) checkBox5.Checked = true;
            if (areasList.Contains(KeyboardArea.SIX)) checkBox6.Checked = true;
            if (areasList.Contains(KeyboardArea.SEVEN)) checkBox7.Checked = true;
            if (areasList.Contains(KeyboardArea.EIGHT)) checkBox8.Checked = true;
            if (areasList.Contains(KeyboardArea.NINE)) checkBox9.Checked = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) areasList.Add(KeyboardArea.ONE);
            if (checkBox2.Checked) areasList.Add(KeyboardArea.TWO);
            if (checkBox3.Checked) areasList.Add(KeyboardArea.THREE);
            if (checkBox4.Checked) areasList.Add(KeyboardArea.FOUR);
            if (checkBox5.Checked) areasList.Add(KeyboardArea.FIVE);
            if (checkBox6.Checked) areasList.Add(KeyboardArea.SIX);
            if (checkBox7.Checked) areasList.Add(KeyboardArea.SEVEN);
            if (checkBox8.Checked) areasList.Add(KeyboardArea.EIGHT);
            if (checkBox9.Checked) areasList.Add(KeyboardArea.NINE);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
