using Gerenciamento_Escolar.str;
using GerenciamentoEscolar.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEscolar.Pages
{
    public partial class FormUpdateRegister : Form
    {
        private DbConnections dbConnections;
        public FormUpdateRegister()
        {
            InitializeComponent();
            dbConnections = new DbConnections();
        }

        private void chk_shearch_name_CheckedChanged(object sender, EventArgs e)
        {
            if (panel_data_shearch.Visible)
            {
                panel_data_shearch.Visible = false;
                lbl_cpf.Visible = true;
                cpf_student.Visible = true;
            }
            else
            {
                panel_data_shearch.Visible = true;
                cpf_student.Visible = false;
                lbl_cpf.Visible = false;
            }
        }

        private void btn_shearch_Click(object sender, EventArgs e)
        {
            var studentData = new StudentData();

            studentData = dbConnections.ShearchStudent(cpf_student.Text);

            //dataGridView1.Rows[1].Cells[1].Value = studentData.Name;
        }

        private void ContentFormat(TextBox input, KeyEventArgs keyE)
        {
            if (input.Name == "cpf_student" || input.Name == "nis_pis")
            {
                if (input.Text.Length == 11 && input.Name == "cpf_student")
                {
                    long cpf = Convert.ToInt64(input.Text);
                    input.MaxLength = 14;
                    string content = String.Format(@"{0:000\.000\.000\-00}", cpf);
                    input.Text = content;
                    CursorPosition(input);
                }
                else if (input.Text.Length == 11 && input.Name == "nis_pis")
                {
                    long cpf = Convert.ToInt64(input.Text);
                    input.MaxLength = 14;
                    string content = String.Format(@"{0:000\.00000\.00\-0}", cpf);
                    input.Text = content;
                    CursorPosition(input);

                }
                else if (keyE.KeyCode == Keys.Back)
                {
                    input.MaxLength = 11;
                    input.Text = input.Text.Replace(".", "").Replace("-", "");
                    CursorPosition(input);
                }
            }
            else if (input.Name == "zip_code")
            {
                if (input.Text.Length == 8 && input.Text.IndexOf('-') == -1)
                {
                    long zipCode = Convert.ToInt64(input.Text);
                    input.MaxLength = 9;
                    string content = String.Format(@"{0:00000\-000}", zipCode);
                    input.Text = content;
                    CursorPosition(input);
                }
                else if (keyE.KeyCode == Keys.Back)
                {
                    input.MaxLength = 8;
                    input.Text = input.Text.Replace(".", "").Replace("-", "");
                    CursorPosition(input);
                }
            }
        }
        private void CursorPosition(TextBox textBox)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                textBox.Select(textBox.Text.Length, 0);
            });
        }

        private bool KeyPressed(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void input_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e);
        }

        private void cpf_student_KeyUp(object sender, KeyEventArgs e)
        {
            ContentFormat(cpf_student, e);
        }
    }
}
