using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterLIO.Forms;

namespace MasterLIO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DBUtils.LoadExercises();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void rsButton1_Click(object sender, EventArgs e)
        {
            //MONKEY CODE!!!   ↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓

            if (loginField.Text == "" || passwordField.Text == "")
            {
                this.TopMost = true; //Ставим текущую форму поверх всех окон
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            String login = loginField.Text;
            String password = passwordField.Text;
            UserProfile profile = null;
            if (login.Length > 2 && login.Length < 16 && password.Length > 3 && password.Length < 11)
            {
                profile = DBUtils.AuthorizeUser(loginField.Text, passwordField.Text);
            }
            else
            {
                MessageBox.Show("Логин должен быть 3-15 символов, пароль 4-10 символов!", "Ошибка ввода");
                return;
            }

            //такой пользователь не найден
            if (profile.password.Equals("") && profile.login.Equals(""))
            {
                DialogResult result = MessageBox.Show("Такой пользователь не найден! Зарегистрировать?",
                    "Зарегистрировать?", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    profile = DBUtils.RegisterUser(loginField.Text, passwordField.Text);
                }
                else
                {
                    this.Close();
                    Application.Exit();
                    return;
                }
            }
            //логин найден, пароль нет
            else if (profile.password.Equals(""))
            {
                this.TopMost = true;
                MessageBox.Show("Пароль неверен! Повторите ввод!");
                return;
            }

            FormsFactory.SetUser(profile);
            Session.user = profile;
            if (profile.role.Equals(Role.STUDENT))
            {
                FormUtils.OpenFormAndCloseCurrent(this, FormsFactory.GetUserMenuForm());

            }
            else
            {
                FormUtils.OpenFormAndCloseCurrent(this, FormsFactory.GetAdminMenuForm());
            }

        }
    }
}
