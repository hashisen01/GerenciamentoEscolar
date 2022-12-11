using Gerenciamento_Escolar;
using Gerenciamento_Escolar.str;
using GerenciamentoEscolar.Pages;
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

namespace GerenciamentoEscolar.Modals
{
    public partial class StudentListItem : UserControl
    {
        public StudentListItem()
        {
            InitializeComponent();
            contentFormat = new ContentFormat();
        }

        ContentFormat contentFormat;

        private Image _imageProfile;
        private Image _delete;
        private Image _statusImg;

        private string _studentCode;
        private string _studentName;
        private string _cpf;
        private string _birthDate;
        private string _fatherName;
        private string _motherName;
        private string _status;
        private bool _byAll;

        [Category("Custom props")]
        public Image ImageProfile
        {
            get { return _imageProfile; }
            set { _imageProfile = value; imgProfile.Image = value; }
        }

        [Category("Custom props")]
        public string StudentCode
        {
            get { return _studentCode; }
            set { _studentCode = value; studentCode.Text = value; }
        }

        [Category("Custom props")]
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; name.Text = value; }
        }

        [Category("Custom props")]
        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; cpf.Text = value; }
        }

        [Category("Custom props")]
        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; birthDate.Text = value; }
        }

        [Category("Custom props")]
        public string MotherName
        {
            get { return _motherName; }
            set { _motherName = value; motherName.Text = value; }
        }

        [Category("Custom props")]
        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; fatherName.Text = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; lblStatus.Text = value; }
        }

        public bool ByAll
        {
            get { return _byAll; }
            set { _byAll = value; }
        }

        [Category("Custom props")]
        public Image BtnDeleteImage
        {
            get { return _delete; }
            set { _delete = value; btn_delete.Image = value; }
        }

        [Category("Custom props")]
        public Image BtnStatusImage
        {
            get { return _statusImg; }
            set { _statusImg = value; btnActive.Image = value; }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluír o estudante da lista?", "Exclir studante?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dialogResult == DialogResult.Yes)
            {
                //do something condition
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DbConnections db = new DbConnections();

            DialogResult dialogResult = MessageBox.Show("Deseja realmente editar a matrícula desse estudante?", "Editar matrícula", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                List<StudentData> studentData = new List<StudentData>();
                studentData = db.SelectAllDataStudent(contentFormat.RemoveContentFormat(cpf.Text));
                showUpdateForm(studentData);
                updateList(true);
            }
        }

        private void showUpdateForm(List<StudentData> studentData)
        {
            Management_System management;
            FormRegister formRegisterUpdate = new FormRegister(studentData);
            formRegisterUpdate.TopLevel = false;
            management = (Management_System)Application.OpenForms["Management_System"];
            management.panel_form.Controls.Add(formRegisterUpdate);
            formRegisterUpdate.btnBack.Visible = true;
            formRegisterUpdate.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Ativo")
                disableStudent();
            else
                enableStudent();
        }

        private void disableStudent()
        {
            var response = new string[2];
            DialogResult dialogResult = MessageBox.Show($"{_studentName} será DESATIVADO(A). Deseja processiguir com esta ação?", "Desativar estudante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                DbConnections db = new DbConnections();
                response = db.UpdateByStatus(contentFormat.RemoveContentFormat(Cpf), 0);
                if (response[0] == "Sucesso!")
                {
                    lblStatus.Text = "Inativo";
                    btnActive.Image = Properties.Resources.inactive;
                }
                DialogResult dialogResponse = MessageBox.Show(response[1], response[0], MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateList(true);
            }
        }

        private void updateList(bool status)
        {
            FormUpdateRegister formUpdateRegister = (FormUpdateRegister)Application.OpenForms["FormUpdateRegister"];
            formUpdateRegister.UpdateList(status);
        }

        private void enableStudent()
        {
            var response = new string[2];
            DialogResult dialogResult = MessageBox.Show($"{Name} será ATIVADO. Deseja processiguir com esta ação?", "Ativar estudante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                DbConnections db = new DbConnections();
                response = db.UpdateByStatus(contentFormat.RemoveContentFormat(Cpf), 1);
                if (response[0] == "Sucesso!")
                {
                    lblStatus.Text = "Ativo";
                    btnActive.Image = Properties.Resources.check;
                }
                DialogResult dialogResponse = MessageBox.Show(response[1], response[0], MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateList(false);
            }
        }

        private void StudentListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
