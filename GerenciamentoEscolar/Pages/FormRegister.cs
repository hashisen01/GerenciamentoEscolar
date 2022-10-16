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
    public partial class FormRegister : Form
    {
        RegisterStudent registerStudent;
        GenericMethods genericMethods;
        public FormRegister()
        {
            InitializeComponent();
            LoadingComponents();
        }

        private void LoadingComponents()
        {
            birth_date.Format = DateTimePickerFormat.Custom;
            birth_date.CustomFormat = "dd/MM/yyyy";
            registerStudent = new RegisterStudent();
            genericMethods = new GenericMethods();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void btn_registerStudent_Click(object sender, EventArgs e)
        {
            string inp_email = input_email.Text;
            string aluno_id = Guid.NewGuid().ToString("N");
            string endereco_id = Guid.NewGuid().ToString("N");
            string shift = GetShift();
            string project = null;
            string projectName = null;
            string cpf = cpf_student.Text.Replace(".", "").Replace("-", "");

            if (ViewProjects()) project = project_name.Text;
            if (project_name.Visible) projectName = project_name.Text;
            if (!input_email.Enabled) inp_email = "Não tem email";

            string[] formData = { txt_nameStudent.Text, cpf, birth_date.Text, nis_pis.Text, census_register.Text, father_name.Text, mother_name.Text, telephone1.Text, telephone2.Text, inp_email, shift, serie_year.Text, project, projectName };
            string[] adressData = { zip_code.Text, district.Text, street.Text, city.Text, number_location.Text, complement.Text };

            List<string> invalidInputList = new List<string>();
            List<string> invalidInputAdressList = new List<string>();

            string inputInvalid = null;

            invalidInputList = registerStudent.StudentDataSave(formData);
            invalidInputAdressList = registerStudent.StudenAdressSave(adressData);

            foreach (string input in invalidInputList)
            {
                inputInvalid += $"   \u2022 {input}\r\n";
            }

            foreach (string input in invalidInputAdressList)
            {
                inputInvalid += $"   \u2022 {input}\r\n";
            }

            MessageBox.Show($"Campo(s) obrigatório(s): \r\n\r\n{inputInvalid}\r\nPreencha o(s) campo(s) citado(s) acima e tente novamente.");
        }

        private string GetShift()
        {
            string shift = null;
            if (rd_morning.Checked)
            {
                shift = rd_morning.Text;
            }
            else if (rd_afternoon.Checked)
            {
                shift = rd_afternoon.Text;
            }
            return shift;
        }

        private void chk_not_email_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_not_email.Checked)
            {
                input_email.Enabled = false;
            }
            else
            {
                input_email.Enabled = true;
            }
            input_email.Clear();
        }

        private void serie_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewProjects();
        }

        private bool ViewProjects()
        {
            if (serie_year.Text == "Projeto")
            {
                lbl_project.Visible = true;
                project.Visible = true;
                return true;
            }
            else
            {
                lbl_project.Visible = false;
                project.Visible = false;
                lbl_nome_projeto.Visible = false;
                project_name.Visible = false;
                return false;
            }
        }

        private void project_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (project.Text == "Outros")
            {
                lbl_nome_projeto.Visible = true;
                project_name.Visible = true;
            }
            else
            {
                lbl_nome_projeto.Visible = false;
                project_name.Visible = false;
            }
        }

        private void GetAdress(object sender, KeyEventArgs e)
        {
            if (zip_code.Text.Length > 8 && genericMethods.GetAddress(zip_code.Text) != null)
            {
                string[] adress = genericMethods.GetAddress(zip_code.Text);
                int cont = 0;
                foreach (var index in adress)
                {
                    if (cont == 1)
                    {
                        string[] valor = index.Split(":".ToCharArray());
                        if (valor[0] == "  erro")
                        {
                            street.Clear();
                            complement.Clear();
                            district.Clear();
                            city.Clear();
                            zip_code.Focus();
                            return;
                        }
                    }

                    //Logradouro (Rua)
                    if (cont == 2)
                    {
                        string[] value = index.Split(":".ToCharArray());
                        street.Text = value[1];
                    }

                    //Complemento
                    if (cont == 3)
                    {
                        string[] value = index.Split(":".ToCharArray());
                        complement.Text = value[1];
                    }

                    //Bairro
                    if (cont == 4)
                    {
                        string[] value = index.Split(":".ToCharArray());
                        district.Text = value[1];
                    }

                    //Localidade (Cidade)
                    if (cont == 5)
                    {
                        string[] value = index.Split(":".ToCharArray());
                        city.Text = value[1];
                    }

                    cont++;
                }
            }
            else
            {
                street.Clear();
                complement.Clear();
                district.Clear();
                city.Clear();
            }
        }
    }
}
