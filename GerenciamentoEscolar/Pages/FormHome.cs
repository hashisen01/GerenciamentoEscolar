using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GerenciamentoEscolar.Pages
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_registerStudent_Click(object sender, EventArgs e)
        {
            menu_buttons.Visible = false;
            FormRegister form_register = new FormRegister(null);
            form_register.TopLevel = false;
            panel_form.Controls.Clear();
            panel_form.Controls.Add(form_register);
            form_register.Show();
        }

        private void btn_finances_Click(object sender, EventArgs e)
        {
            
        }
    }
}
