using Gerenciamento_Escolar.str;
using GerenciamentoEscolar.Modals;
using GerenciamentoEscolar.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GerenciamentoEscolar.Pages
{
    public partial class FormUpdateRegister : Form
    {
        private DbConnections dbConnections;
        ContentFormat contentFormat;
        bool byAll = false, byInactive = false, byActive = false, byCpf = true, byName = false;
        public FormUpdateRegister()
        {
            InitializeComponent();
            dbConnections = new DbConnections();
        }
        private void FormUpdateRegister_Load(object sender, EventArgs e)
        {
            LoadComponents();
        }

        private void LoadComponents()
        {
            contentFormat = new ContentFormat();
            contentFormat.DateFormat(birth_date);
            groupStatus.Visible = false;
            cpf_student.GotFocus += RemoveText;
            cpf_student.LostFocus += AddText;
        }

        private void chk_shearch_name_CheckedChanged(object sender, EventArgs e)
        {
            if (panel_name_date.Visible)
            {
                nameDateIsVisible(false);
                lbl_cpf.Visible = true;
                cpf_student.Visible = true;
            }
            else
            {
                nameDateIsVisible(true);
                cpf_student.Visible = false;
                lbl_cpf.Visible = false;
            }
        }

        private void chkShearchByStatus_CheckedChanged(object sender, EventArgs e)
        {
            makeVisibleLastSearch();
            if (chkShearchByStatus.Checked)
            {
                groupStatus.Visible = true;
                panel_shearch.Visible = false;
                statusesAreVisible(true);
            }
            else
            {
                groupStatus.Visible = false;
                panel_shearch.Visible = true;
                statusesAreVisible(false);
            }
            radioAllChecked();
            radioActiveChecked();
            radioInactiveChecked();
        }

        private void btn_shearch_Click(object sender, EventArgs e)
        {
            flowPanel.Controls.Clear();
            if (!chkShearchByStatus.Checked && !chk_shearch_name.Checked)
            {
                byAll = true;
                byCpf = true;
                byName = false;
                radiosStatusChecked(false);
                birth_date.Value = DateTime.Now;
                name.Clear();
                SearchStudentByCPF();
            }
            else if (!chkShearchByStatus.Checked && chk_shearch_name.Checked)
            {
                byAll = true;
                byName = true;
                byCpf = false;
                cpf_student.Text = "Digite o cpf...";
                radiosStatusChecked(false);
                SearchByNameAndBirth();
            }
            else if (rdAll.Checked)
            {
                byAll = true;
                byActive = false;
                byInactive = false;
                byCpf = false;
                clearInputs();
                ShearchAllStudents();
                Console.WriteLine($"{byAll}, {byActive}, {byInactive}" + " 1");
            }
            else if (rdActive.Checked || rdInactive.Checked)
            {
                byAll = false;
                byCpf = false;
                byName = false;
                clearInputs();
                if (rdActive.Checked)
                {
                    ShearchByStatus(true);
                    byActive = true;
                    byInactive = false;
                }
                else
                {
                    ShearchByStatus(false);
                    byActive = false;
                    byInactive = true;
                }
            }
            else
            {
                noResult.Visible = true;
                notFound.Visible = true;
            }
            Console.WriteLine($"{byAll}, {byActive}, {byInactive}" + " 2");
        }

        public void ExternalUpdateList()
        {
            btn_shearch.PerformClick();
        }

        public void UpdateList(bool status)
        {
            if (!byAll && (byActive || byInactive))
                ShearchByStatus(status);
        }

        private void input_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e);
        }

        private void cpf_student_KeyUp(object sender, KeyEventArgs e)
        {
            CpfField(cpf_student, e);
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (cpf_student.Text == "Digite o cpf...")
            {
                cpf_student.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cpf_student.Text))
            {
                cpf_student.Text = "Digite o cpf...";
            }
        }

        private void clearInputs()
        {
            birth_date.Value = DateTime.Now;
            name.Clear();
            cpf_student.Text = "Digite o cpf...";
        }

        private void makeVisibleLastSearch()
        {
            if (byCpf)
            {
                lbl_cpf.Visible = true;
                cpf_student.Visible = true;
                chk_shearch_name.Checked = false;
                panel_name_date.Visible = false;
                return;
            }
            if (byName)
            {
                cpf_student.Visible = false;
                chk_shearch_name.Checked = true;
                panel_name_date.Visible = true;
                return;
            }
        }

        private void radioAllChecked()
        {
            if (byAll)
            {
                rdAll.Checked = true;
            }
            else
            {
                rdAll.Checked = false;
            }
        }
        private void radioActiveChecked()
        {
            if (byActive)
            {
                rdActive.Checked = true;
            }
            else
            {
                rdActive.Checked = false;
            }
        }

        private void radioInactiveChecked()
        {
            if (byInactive)
            {
                rdInactive.Checked = true;
            }
            else
            {
                rdInactive.Checked = false;
            }
        }

        private void statusesAreVisible(bool visible)
        {
            foreach (RadioButton ctrl in groupStatus.Controls)
                ctrl.Visible = visible;
        }

        private void nameDateIsVisible(bool visible)
        {
            chk_shearch_name.Checked = visible;
            panel_name_date.Visible = visible;
        }

        private void CaretPosition(TextBox textBox, int position)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                textBox.Select(position, 0);
            });
        }

        private void radiosStatusChecked(bool active)
        {
            byAll = active;
            byActive = active;
            byInactive = active;
            if (!active)
                foreach (RadioButton radio in groupStatus.Controls)
                {
                    radio.Checked = false;
                }
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

        private void CpfField(TextBox fieldCpf, KeyEventArgs e)
        {
            if (fieldCpf.Text.Length >= 11)
            {
                int position = fieldCpf.SelectionStart;
                if ((e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down))
                {
                    fieldCpf.Text = contentFormat.GetContentIsNumber(fieldCpf.Text);
                    fieldCpf.Text = contentFormat.ContentFormatCpf(fieldCpf.Text);

                    CaretPosition(fieldCpf, contentFormat.GetCaretPositionCpf(fieldCpf.Text.Length, position));
                }
            }
        }

        private void PopulateItems(List<StudentData> studentData)
        {
            flowPanel.Controls.Clear();
            for (int i = 0; i < studentData.Count(); i++)
            {
                StudentListItem listItem = new StudentListItem();
                listItem.ImageProfile = Properties.Resources.user;
                listItem.StudentCode = studentData[i].StudentCod;
                listItem.StudentName = studentData[i].Name;
                listItem.Cpf = contentFormat.ContentFormatCpf(studentData[i].Cpf);
                listItem.BirthDate = studentData[i].Birth.ToShortDateString();
                listItem.ByAll = byAll;
                if (studentData[i].Active == 0)
                {
                    listItem.BtnStatusImage = Properties.Resources.inactive;
                    listItem.Status = "Inativo";
                }
                else
                {
                    listItem.BtnStatusImage = Properties.Resources.check;
                    listItem.Status = "Ativo";
                }
                listItem.MotherName = studentData[i].MotherName;
                listItem.FatherName = studentData[i].FatherName;
                flowPanel.Controls.Add(listItem);
                flowPanel.Controls.RemoveByKey("");
            }
        }

        private void SearchByNameAndBirth()
        {
            noResult.Visible = false;
            notFound.Visible = false;

            List<StudentData> studentData = new List<StudentData>();
            DateTime date = new DateTime();
            date = birth_date.Value;

            studentData = dbConnections.ShearchByNameAndBirthDate(name.Text, date);

            if (studentData == null || studentData.Count() < 1)
            {
                noResult.Visible = true;
                notFound.Visible = true;
            }
            else
            {
                PopulateItems(studentData);
            }
        }

        private void ShearchByStatus(bool active)
        {
            flowPanel.Controls.Clear();
            noResult.Visible = false;
            notFound.Visible = false;
            byte status = Convert.ToByte(active);
            List<StudentData> studentByStatusData = new List<StudentData>();

            studentByStatusData = dbConnections.ShearchByStatus(status);

            if (studentByStatusData == null || studentByStatusData.Count() < 1)
            {
                noResult.Visible = true;
                notFound.Visible = true;
            }
            else
                PopulateItems(studentByStatusData);
        }

        private void ShearchAllStudents()
        {
            noResult.Visible = false;
            notFound.Visible = false;
            List<StudentData> studentAllData = new List<StudentData>();

            studentAllData = dbConnections.ShearchAllStudent();

            if (studentAllData == null || studentAllData.Count() < 1)
            {
                noResult.Visible = true;
                notFound.Visible = true;
            }
            else
            {
                PopulateItems(studentAllData);
            }
        }

        private void SearchStudentByCPF()
        {
            noResult.Visible = false;
            notFound.Visible = false;
            List<StudentData> studentByCpfData = new List<StudentData>();

            studentByCpfData = dbConnections.ShearchByCPF(contentFormat.RemoveContentFormat(cpf_student.Text));

            if (studentByCpfData == null || studentByCpfData.Count() < 1)
            {
                noResult.Visible = true;
                notFound.Visible = true;
            }
            else
            {
                PopulateItems(studentByCpfData);
            }
        }
    }
}
