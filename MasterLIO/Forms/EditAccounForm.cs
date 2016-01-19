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
    public partial class EditAccounForm : Form
    {
        public EditAccounForm()
        {
            InitializeComponent();
            passwordtextBox2.UseSystemPasswordChar = true;

            List<UserProfile> users = DBUtils.LoadAllUsers();
            userlistBox1.Items.AddRange(users.ToArray());

            rolecomboBox1.Items.Add(Role.ADMIN);
            rolecomboBox1.Items.Add(Role.STUDENT);
        }

        private void userlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserProfile selectedUser = (UserProfile)userlistBox1.SelectedItem;
            logintextBox2.Text = selectedUser.login;
            passwordtextBox2.Text = selectedUser.password;
            rolecomboBox1.Text = selectedUser.role.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
                passwordtextBox2.UseSystemPasswordChar = false;
            else
                passwordtextBox2.UseSystemPasswordChar = true;
        }

        private void createUserButton1_Click(object sender, EventArgs e)
        {
            string login = logintextBox2.Text;
            string password = passwordtextBox2.Text;
            string roleString = rolecomboBox1.Text;
            Role role = Role.STUDENT;

            if (roleString.Equals("STUDENT"))
            {
                role = Role.STUDENT;
            }

            if (roleString.Equals("ADMIN"))
            {
                role = Role.ADMIN;
            }

            UserProfile newUser = DBUtils.RegisterUser(login, password, role);
            List<UserProfile> users = DBUtils.LoadAllUsers();
            userlistBox1.Items.Clear();
            userlistBox1.Items.AddRange(users.ToArray());
        }

        private void deleteUserbutton2_Click(object sender, EventArgs e)
        {        
            UserProfile currentUser  = (UserProfile)userlistBox1.SelectedItem;

            if(currentUser.login.Equals(Session.user.login)){
                 MessageBox.Show("Пользователь не может удалить самого себя.", "Запрещенное удаление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }else{
            
            DBUtils.RemoveUser(currentUser);
            userlistBox1.Items.Clear();
            List<UserProfile> users = DBUtils.LoadAllUsers();
            userlistBox1.Items.AddRange(users.ToArray());
            }
            

        }

        private void approveButton3_Click(object sender, EventArgs e)
        {
            UserProfile selectedUser = (UserProfile)userlistBox1.SelectedItem;
            string login = logintextBox2.Text;
            string password = passwordtextBox2.Text;
            string roleString = rolecomboBox1.Text;

            Role role = Role.STUDENT;

            if (roleString.Equals("STUDENT"))
            {
                role = Role.STUDENT;
            }

            if (roleString.Equals("ADMIN"))
            {
                role = Role.ADMIN;
            }

            DBUtils.RemoveUser(selectedUser);
            DBUtils.RegisterUser(login, password, role);

        }


    }

}
