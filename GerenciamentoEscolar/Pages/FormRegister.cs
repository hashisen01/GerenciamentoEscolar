using Gerenciamento_Escolar.str;
using GerenciamentoEscolar.Modals;
using GerenciamentoEscolar.utils;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace GerenciamentoEscolar.Pages
{
    public partial class FormRegister : Form
    {
        GenericMethods genericMethods;
        ContentFormat contentFormat;
        public FormRegister()
        {
            InitializeComponent();
            LoadingComponents();
        }

        private void LoadingComponents()
        {
            birth_date.Format = DateTimePickerFormat.Custom;
            birth_date.CustomFormat = "dd/MM/yyyy";
            genericMethods = new GenericMethods();
            contentFormat = new ContentFormat();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void btn_registerStudent_Click(object sender, EventArgs e)
        {
            string student_id = Guid.NewGuid().ToString("N");
            string parent_id = Guid.NewGuid().ToString("N");
            string contact_id = Guid.NewGuid().ToString("N");
            string address_id = Guid.NewGuid().ToString("N");

            DateTime birth = new DateTime();
            birth = birth_date.Value;
            string shift = GetShift();

            var studentData = new StudentData();

            studentData.ParentsId = parent_id;
            studentData.FatherName = father_name.Text;
            studentData.MotherName = mother_name.Text;

            studentData.ContactId = contact_id;
            studentData.Telephone1 = RemoveMask(numberContact1.Text);
            studentData.Telephone2 = RemoveMask(numberContact2.Text);
            studentData.Email = email.Text;

            studentData.AddressId = address_id;
            studentData.ZipCode = RemoveMask(zip_code.Text);
            studentData.Street = street.Text;
            studentData.District = district.Text;
            studentData.City = city.Text;
            studentData.Number = number_residence.Text;
            if (complement.Text.Length == 0) 
                studentData.Complement = "Sem complemento";
            else 
                studentData.Complement = complement.Text;

            studentData.StudentId = student_id;
            studentData.Name = nameStudent.Text;
            studentData.Cpf = RemoveMask(cpf_student.Text);
            Console.WriteLine(studentData.Cpf);
            studentData.Birth = birth;
            studentData.Nis = RemoveMask(nis.Text);
            studentData.StudentCod = census_register.Text;
            studentData.Shift = GetShift();
            studentData.Serie = serie_year.Text;
            studentData.ProjectName = project_name.Text;
            
            studentData.AddressId = address_id;
            studentData.ContactId = contact_id;
            studentData.ParentsId = parent_id;
            studentData.Active = 1;

            studentData.InProject = inProject;
            studentData.DontHaveEmail = chk_not_email;

            

            if (studentData != null)
            {
                var validator = new ValidateData();
                var results = validator.Validate(studentData);
                string invalidInput = null;

                if (!results.IsValid)
                {
                    foreach (var error in results.Errors)
                    {
                        invalidInput += $"   \u2022 {error}\r\n";
                    }

                    MessageBox.Show($"Campo(s) obrigatório(s): \r\n\r\n{invalidInput}\r\nPreencha o(s) campo(s) citado(s) acima e tente novamente.");
                }
                else
                {
                    DbConnections db = new DbConnections();
                    bool[] register = new bool[4];
                    bool success = true;
                    register[0] = db.RegisterAddressStudent(studentData);
                    register[1] = db.RegisterContactStudent(studentData);
                    register[2] = db.RegisterParentsStudent(studentData);
                    register[3] = db.RegisterStudent(studentData);
                    foreach (bool result in register)
                    {
                        if (!result)
                        {
                            success = false;
                            break;
                        }
                    }
                    if (!success)
                        MessageBox.Show("Algo deu errado!");
                    else
                        MessageBox.Show("Aluno matriculado");
                }
            }
        }

        public string RemoveMask(string txt)
        {
            return txt.Replace("(", "").Replace(")", "").Replace(".", "").Replace(" ", "").Replace("-", "");
        }

        private string GetShift()
        {
            string shift = null;
            if (rd_morning.Checked)
                shift = rd_morning.Text;

            else if (rd_afternoon.Checked)
                shift = rd_afternoon.Text;

            return shift;
        }

        private void chk_not_email_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_not_email.Checked)
                email.Enabled = false;

            else
                email.Enabled = true;

            email.Text = "";
        }

        private void serie_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewProjects();
        }

        private bool ViewProjects()
        {
            if (serie_year.Text == "Projeto")
            {
                inProject.Enabled = false;
                inProject.Checked = true;
                lbl_nome_projeto.Visible = true;
                project_name.Visible = true;
                return true;
            }
            else
            {
                inProject.Enabled = true;
                inProject.Checked = false;
                lbl_nome_projeto.Visible = false;
                project_name.Visible = false;
                return false;
            }
        }

        private void CaretPosition(TextBox textBox, int position)
        {
            Console.WriteLine(textBox.Text.Length + " | " + position);
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                textBox.Select(position, 0);
            });
        }

        private bool KeyPressed( KeyPressEventArgs e)
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

        private void cpf_student_KeyUp(object sender, KeyEventArgs e)
        {
            CpfField(cpf_student, e);
        }

        private void cpf_student_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e);
        }

        private void zip_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e);
        }

        private void zip_code_KeyUp(object sender, KeyEventArgs e)
        {
            ZipCodeField(zip_code, e);
        }

        private void nis_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e);
        }

        private void nis_KeyUp(object sender, KeyEventArgs e)
        {
            NisField(nis, e);
        }

        private void census_register_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e);
        }

        private void inProject_CheckedChanged(object sender, EventArgs e)
        {
            if (!inProject.Checked)
            {
                lbl_nome_projeto.Visible = false;
                project_name.Visible = false;
            } else
            {
                lbl_nome_projeto.Visible = true;
                project_name.Visible = true;
            }
        }
        
        private void numberContact1_KeyUp(object sender, KeyEventArgs e)
        {
            ContactField(numberContact1, e);
        }

        private void numberContact2_KeyUp(object sender, KeyEventArgs e)
        {
            ContactField(numberContact2, e);
        }

        private void numberContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e);
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

        public void NisField(TextBox filedNis, KeyEventArgs e)
        {
            if (filedNis.Text.Length >= 11)
            {
                int position = filedNis.SelectionStart;
                if ((e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down))
                {
                    filedNis.Text = contentFormat.GetContentIsNumber(filedNis.Text);
                    filedNis.Text = contentFormat.ContentFormatNis(filedNis.Text);

                    CaretPosition(filedNis, contentFormat.GetCaretPositionNis(filedNis.Text.Length, position));
                }
            }
        }

        public void ContactField(TextBox contact, KeyEventArgs e)
        {
            if (contact.Text.Length >= 11)
            {
                int position = contact.SelectionStart;
                if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                {
                    contact.Text = contentFormat.GetContentIsNumber(contact.Text);
                    contact.Text = contentFormat.ContentFormatTelephone(contact.Text);
                    CaretPosition(contact, contentFormat.GetCaretPositionTelephone(contact.Text.Length, position));
                }
            }
        }

        public void ZipCodeField(TextBox zipCode, KeyEventArgs e)
        {
            if (zipCode.Text.Length == 8)
            {
                int position = zipCode.SelectionStart;
                if ((e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down))
                {
                    zipCode.Text = contentFormat.GetContentIsNumber(zipCode.Text);
                    zipCode.Text = contentFormat.ContentFormatZipCode(zipCode.Text);

                    CaretPosition(zipCode, contentFormat.GetCaretPositionZipCode(zipCode.Text.Length, position));
                }
                GetAdress();
            }
        }

        public void ClearAddressField()
        {
            street.Clear();
            complement.Clear();
            district.Clear();
            city.Clear();
        }

        private void GetAdress()
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
                            ClearAddressField();
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
                ClearAddressField();
            }
        }
    }
}
