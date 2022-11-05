using GerenciamentoEscolar.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEscolar
{
    public partial class Management_System : Form
    {
        (string name, bool admin) User;
        Management_System management_System;
        public Management_System((string name, bool admin) User)
        {
            InitializeComponent();
            this.User.name = User.name;
            this.User.admin = User.admin;
        }

        private void Management_System_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = $"Olá, {User.name}";
            panel_form.Visible = false;
            ActivatedButton(btn_home);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormRenderise(btn_home);
        }

        private void btn_finances_Click(object sender, EventArgs e)
        {
            FormRenderise(btn_finances);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            FormRenderise(btn_register);
        }


        private void btn_registerStudent_Click(object sender, EventArgs e)
        {
            FormRenderise(btn_registerStudent);
        }

        private void btn_updateRegister_Click(object sender, EventArgs e)
        {
            FormRenderise(btn_updateRegister);
        }

        private void btn_activity_Click(object sender, EventArgs e)
        {
            FormRenderise(btn_activity);
        }

        private void btn_historic_Click(object sender, EventArgs e)
        {
            FormRenderise(btn_historic);
        }

        private void Management_System_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormRenderise(Button button)
        {
            switch (button.Name)
            {
                case "btn_home":
                    ActivatedButton(btn_home);
                    panel_form.Visible = false;
                    panel_form.Controls.Clear();
                    menu_buttons.Visible = true;
                    break;

                case "btn_finances":
                    ActivatedButton(button);
                    menu_buttons.Visible = false;
                    panel_form.Visible = true;
                    sub_menu_register.Visible = false;
                    break;

                case "btn_register":
                    ActivatedButton(button);
                    if (sub_menu_register.Visible)
                    {
                        sub_menu_register.Visible = false;
                    }
                    else
                    {
                        sub_menu_register.Visible = true;
                    }
                    break;

                case "btn_updateRegister":
                    ActivatedButton(button);
                    menu_buttons.Visible = false;
                    panel_form.Visible = true;
                    FormUpdateRegister form_updateRegister = new FormUpdateRegister();
                    form_updateRegister.TopLevel = false;
                    panel_form.Controls.Clear();
                    panel_form.Controls.Add(form_updateRegister);
                    form_updateRegister.Show();
                    break;

                case "btn_registerStudent":
                    ActivatedButton(button);
                    menu_buttons.Visible = false;
                    panel_form.Visible = true;
                    FormRegister form_register = new FormRegister();
                    form_register.TopLevel = false;
                    panel_form.Controls.Clear();
                    panel_form.Controls.Add(form_register);
                    form_register.Show();
                    break;

                case "btn_activity":
                    panel_form.Visible = true;
                    menu_buttons.Visible = false;
                    ActivatedButton(button);
                    break;

                case "btn_historic":
                    panel_form.Visible = true;
                    menu_buttons.Visible = false;
                    ActivatedButton(button);
                    break;

                default:
                    break;
            }
        }

        public void ActivatedButton(Button btn_active)
        {
            foreach (Control ctrl in panelNavBar.Controls)
            {
                if (btn_active.Name == "btn_register")
                    break;
                else
                {
                    ctrl.BackColor = Color.Blue;
                    ctrl.ForeColor = Color.White;
                }
            }

            foreach (Control ctrl in sub_menu_register.Controls)
            {
                if (btn_active.Name == "btn_register")
                    break;
                else
                {
                    ctrl.BackColor = Color.FromArgb(0, 100, 255);
                    ctrl.ForeColor = Color.White;
                }
            }

            if (btn_active.Name == "btn_register" || btn_active.Name == "btn_updateRegister" || btn_active.Name == "btn_registerStudent")
            {
                if (btn_active.Name == "btn_register")
                    btn_active.ForeColor = Color.White;
                else
                    btn_active.ForeColor = Color.Black;
                btn_active.BackColor = Color.FromArgb(178, 214, 255);
                btn_register.BackColor = Color.FromArgb(100, 150, 255);
            }
            else
            {
                btn_active.BackColor = Color.FromArgb(178, 214, 255);
                btn_active.ForeColor = Color.Black;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (management_System != (Management_System)Application.OpenForms["Management_System"])
            {
                management_System = (Management_System)Application.OpenForms["Management_System"];
                management_System.Hide();
                FormLogin form_login = (FormLogin)Application.OpenForms["FormLogin"];
                form_login.Show();
            }
            else
            {
                management_System = new Management_System(User);
                management_System.Hide();
                FormLogin form_login = (FormLogin)Application.OpenForms["FormLogin"];
                form_login.Show();
            }
        }

        private void registerStudent_Click(object sender, EventArgs e)
        {
            sub_menu_register.Visible = true;
            btn_registerStudent_Click(sender, e);
        }

        private void finances_Click(object sender, EventArgs e)
        {
            btn_finances_Click(sender, e);
        }

        private void historic_Click(object sender, EventArgs e)
        {
            btn_historic_Click(sender, e);
        }

        private void activity_Click(object sender, EventArgs e)
        {
            btn_activity_Click(sender, e);
        }
    }
}
