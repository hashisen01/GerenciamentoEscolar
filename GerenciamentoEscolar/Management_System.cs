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
        public Management_System()
        {
            InitializeComponent();
        }

        private void Management_System_Load(object sender, EventArgs e)
        {
            btn_home_Click(sender, e);
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
                    sub_menu_register.Visible = false;
                    FormHome form_home = new FormHome();
                    form_home.TopLevel = false;
                    panel_form.Controls.Clear();
                    panel_form.Controls.Add(form_home);
                    form_home.Show();
                    break;

                case "btn_finances":
                    ActivatedButton(button);
                    sub_menu_register.Visible = false;
                    break;

                case "btn_register":
                    ActivatedButton(button);
                    if (sub_menu_register.Visible)
                        sub_menu_register.Visible = false;
                    else
                    {
                        sub_menu_register.Visible = true;
                    }
                    break;

                case "btn_updateRegister":
                    ActivatedButton(button);
                    break;

                case "btn_registerStudent":
                    ActivatedButton(button);
                    FormRegister form_register = new FormRegister();
                    form_register.TopLevel = false;
                    panel_form.Controls.Clear();
                    panel_form.Controls.Add(form_register);
                    form_register.Show();
                    break;

                case "btn_activity":
                    ActivatedButton(button);
                    break;

                case "btn_historic":
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
                    ctrl.BackColor = Color.FromArgb(0, 0, 192);
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

            if (btn_active.Name == "btn_register" || btn_active.Name == "btn_updateStudent" || btn_active.Name == "btn_registerStudent")
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
    }
}
