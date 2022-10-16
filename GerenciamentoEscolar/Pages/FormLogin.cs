using Gerenciamento_Escolar.str;
using GerenciamentoEscolar.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEscolar.Pages
{
    public partial class FormLogin : Form
    {
        private Login login;
        private MessageException messageAlert;
        public FormLogin()
        {
            InitializeComponent();
            login = new Login();
            messageAlert = new MessageException();
        }

        private void View_Password_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '•')
            {
                txt_password.PasswordChar = char.Parse("\0");
                View_Password.Controls.Clear();
                View_Password.Image = Properties.Resources.visao;
            }
            else
            {
                txt_password.PasswordChar = '•';
                View_Password.Controls.Clear();
                View_Password.Image = Properties.Resources.ocultar;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var isEmpty = login.IsEmpty(txt_user.Text, txt_password.Text);
            var response = login.response;

            if (!isEmpty && response) OpenHome();
            else MessageBox.Show(messageAlert.InvalidLogin());
        }

        private void OpenHome()
        {
            (string name, bool type) User;
            User.name = login.username;
            User.type = login.user_admin;
            MessageBox.Show("Bem vindo(a), " + User.name + "!");
            FormLogin form_login = (FormLogin)Application.OpenForms["FormLogin"];
            form_login.Hide();
            Management_System management_system = new Management_System();
            management_system.ShowDialog();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
