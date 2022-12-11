using Gerenciamento_Escolar.str;
using GerenciamentoEscolar.Modals;
using GerenciamentoEscolar.utils;
using Microsoft.Win32;
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
        List<StudentData> studentDataUpdate = new List<StudentData>();
        private string student_id = null;
        private string parent_id = null;
        private string contact_id = null;
        private string address_id = null;
        private string [] message = { "Sucesso", "A matrícula foi realizada com sucesso!", "Dados alterados com sucesso!", "ERRO!", "Não foi possível reslizar a matrícula.\nReinicie o sistema e tente novamente!\nSe o erro percistir entre em contato com o desenvolvedor!" };
        private string[] txtBtnRegister = { "Realizar matrícula", "Atualizar matrícula" };
        public FormRegister(List<StudentData> studentData)
        {
            InitializeComponent();
            this.studentDataUpdate = studentData;
        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            LoadComponents();
        }

        private void LoadComponents()
        {
            contentFormat = new ContentFormat();
            genericMethods = new GenericMethods();
            contentFormat.DateFormat(birth_date);
            btn_registerStudent.Text = txtBtnRegister[0];
            if (studentDataUpdate != null)
            {
                FillFormContent();
            }
        }

        private void FillFormContent()
        {
            btn_registerStudent.Text = txtBtnRegister[1];
            student_id = studentDataUpdate[0].StudentId;
            address_id = studentDataUpdate[0].AddressId;
            contact_id = studentDataUpdate[0].ContactId;
            parent_id = studentDataUpdate[0].ParentsId;
            nameStudent.Text = studentDataUpdate[0].Name;
            cpf_student.Text = studentDataUpdate[0].Cpf;
            birth_date.Value = studentDataUpdate[0].Birth.Date;
            nis.Text = studentDataUpdate[0].Nis;
            studentCode.Text = studentDataUpdate[0].StudentCod;
            father_name.Text = studentDataUpdate[0].FatherName;
            mother_name.Text = studentDataUpdate[0].MotherName;
            numberContact1.Text = studentDataUpdate[0].Telephone1;
            numberContact2.Text = studentDataUpdate[0].Telephone2;
            email.Text = studentDataUpdate[0].Email;
            if (string.IsNullOrEmpty(studentDataUpdate[0].Email))
            {
                chk_not_email.Checked = true;
            }
            foreach  (RadioButton radio in group_sift.Controls)
            {
                if (radio.Text == studentDataUpdate[0].Shift) 
                    radio.Checked = true;
            }
            serie_year.Text = studentDataUpdate[0].Serie;
            if (!string.IsNullOrEmpty(studentDataUpdate[0].ProjectName))
            {
                project_name.Text = studentDataUpdate[0].ProjectName;
                inProject.Checked = true;
            }
            zip_code.Text = studentDataUpdate[0].ZipCode;
            street.Text = studentDataUpdate[0].Street;
            district.Text = studentDataUpdate[0].District;
            city.Text = studentDataUpdate[0].City;
            number_residence.Text = studentDataUpdate[0].Number;
            complement.Text = studentDataUpdate[0].Complement;
            note.Text = studentDataUpdate[0].Note;
        }

        private void btn_registerStudent_Click(object sender, EventArgs e)
        {
            registerStudent();
        }

        private void registerStudent()
        {
            if (string.IsNullOrEmpty(student_id) || string.IsNullOrEmpty(parent_id) || string.IsNullOrEmpty(contact_id) || string.IsNullOrEmpty(address_id))
            {
                student_id = Guid.NewGuid().ToString("N");
                parent_id = Guid.NewGuid().ToString("N");
                contact_id = Guid.NewGuid().ToString("N");
                address_id = Guid.NewGuid().ToString("N");
            }

            DateTime birth = new DateTime();
            birth = birth_date.Value;
            string shift = GetShift();

            var studentData = new StudentData();

            studentData.ParentsId = parent_id;
            studentData.FatherName = father_name.Text;
            studentData.MotherName = mother_name.Text;

            studentData.ContactId = contact_id;
            studentData.Telephone1 = contentFormat.RemoveContentFormat(numberContact1.Text);
            studentData.Telephone2 = contentFormat.RemoveContentFormat(numberContact2.Text);
            studentData.Email = email.Text;

            studentData.AddressId = address_id;
            studentData.ZipCode = contentFormat.RemoveContentFormat(zip_code.Text);
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
            studentData.Cpf = contentFormat.RemoveContentFormat(cpf_student.Text);
            Console.WriteLine(studentData.Cpf);
            studentData.Birth = birth;
            studentData.Nis = contentFormat.RemoveContentFormat(nis.Text);
            studentData.StudentCod = studentCode.Text;
            studentData.Shift = GetShift();
            studentData.Serie = serie_year.Text;
            studentData.ProjectName = project_name.Text;
            studentData.Note = note.Text;

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
                    bool update = false;
                    if (studentDataUpdate == null)
                    {
                        register[0] = db.RegisterAddressStudent(studentData);
                        register[1] = db.RegisterContactStudent(studentData);
                        register[2] = db.RegisterParentsStudent(studentData);
                        register[3] = db.RegisterStudent(studentData);
                        update = false;
                    }
                    else
                    {
                        register = db.UpdateAllDataStudent(studentData);
                        CloseFormRegister();
                        update = true;
                    }
                    returnMessage(register, update);
                }
            }
        }

        private void returnMessage(bool [] result, bool update)
        {
            foreach (bool success in result)
            {
                if (!success)
                {
                    MessageBox.Show(message[4], message[3], MessageBoxButtons.OK);
                    return;
                } 
                if (success && update)
                {
                    MessageBox.Show(message[2], message[0], MessageBoxButtons.OK);
                    return;
                }
                if (success && !update)
                {
                    MessageBox.Show(message[1], message[0], MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void CloseFormRegister()
        {
            Management_System management_System = (Management_System)Application.OpenForms["Management_System"];
            FormUpdateRegister formUpdateRegister = (FormUpdateRegister)Application.OpenForms["FormUpdateRegister"];
            FormRegister formRegister = (FormRegister)Application.OpenForms["FormRegister"];
            formUpdateRegister.ExternalUpdateList();
            foreach (Form form in management_System.panel_form.Controls)
            {
                if (form == formRegister)
                {
                    management_System.panel_form.Controls.Remove(formRegister);
                    formRegister.Dispose();
                    formRegister.Close();
                }
            }
            studentDataUpdate = null;
        }

        private string GetShift()
        {
            string shift = null;
            if (rd_morning.Checked)
                shift = rd_morning.Text;

            else if (rd_afternoon.Checked)
                shift = rd_afternoon.Text;

            else if (rdNocturnal.Checked)
                shift = rdNocturnal.Text;

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
            if (zipCode.Text.Length >= 8)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseFormRegister();
        }
    }
}
