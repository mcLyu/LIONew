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
        List<UserProfile> users;
        public EditAccounForm()
        {
            InitializeComponent();
            deleteUserbutton2.Enabled = false;
            passwordtextBox2.UseSystemPasswordChar = true;

            users = DBUtils.LoadAllUsers();
            userlistBox1.Items.AddRange(users.ToArray());

            rolecomboBox1.Items.Add(Role.ADMIN);
            rolecomboBox1.Items.Add(Role.STUDENT);
        }

        private void userlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteUserbutton2.Enabled = true;
            if (userlistBox1.SelectedIndex != -1)
            {
            UserProfile selectedUser = (UserProfile)userlistBox1.SelectedItem;
            logintextBox2.Text = selectedUser.login;
            passwordtextBox2.Text = selectedUser.password;
            rolecomboBox1.Text = selectedUser.role.ToString();
            }

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
            if ((logintextBox2.Text=="") || passwordtextBox2.Text == "" || rolecomboBox1.Text=="")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            string login = logintextBox2.Text;
            string password = passwordtextBox2.Text;
            string roleString = rolecomboBox1.Text;

           for(int i = 0;i<users.Count;i++)
            {
                if (users[i].login.Equals(login))
                {
                    MessageBox.Show("Данное имя уже занято");
                    return;
                }
            }
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
            users = DBUtils.LoadAllUsers();
            userlistBox1.Items.Clear();
            userlistBox1.Items.AddRange(users.ToArray());
        }

        private void deleteUserbutton2_Click(object sender, EventArgs e)
        {        

            UserProfile currentUser  = (UserProfile)userlistBox1.SelectedItem;
            if (currentUser == null)
            {
                MessageBox.Show("Выберите пользователя!");
                return;
            }
            if(currentUser.login.Equals(Session.user.login)){
                 MessageBox.Show("Пользователь не может удалить самого себя.", "Запрещенное удаление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }else{
            
                DialogResult dialogResult = MessageBox.Show("Вы уверены,что хотите удалить этого пользователя? ", "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
            DBUtils.RemoveUser(currentUser);
            userlistBox1.Items.Clear();
                    userlistBox1.Text = "";
                    users = DBUtils.LoadAllUsers();
            userlistBox1.Items.AddRange(users.ToArray());
            }
            
            deleteUserbutton2.Enabled = false;
        }

        private void approveButton3_Click(object sender, EventArgs e)
        {
            if ((logintextBox2.Text == "") || passwordtextBox2.Text == "" || rolecomboBox1.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            UserProfile selectedUser = (UserProfile)userlistBox1.SelectedItem;
            if (selectedUser == null) 
            {
                MessageBox.Show("Выберите пользователя!");
                return;
            }
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
            userlistBox1.Items.Clear();
            users = DBUtils.LoadAllUsers();
            userlistBox1.Items.AddRange(users.ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Поиск..")) return;
            userlistBox1.Items.Clear();
            foreach(UserProfile user in users)
            {
                if (user.login.Contains(textBox1.Text))
                {
                    userlistBox1.Items.Add(user);
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Поиск..";
        }


    }

}
