
namespace GerenciamentoEscolar.Pages
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_rua = new System.Windows.Forms.Label();
            this.btn_registerStudent = new System.Windows.Forms.Button();
            this.group_turno = new System.Windows.Forms.GroupBox();
            this.rd_afternoon = new System.Windows.Forms.RadioButton();
            this.rd_morning = new System.Windows.Forms.RadioButton();
            this.cpf_student = new System.Windows.Forms.MaskedTextBox();
            this.telephone2 = new System.Windows.Forms.MaskedTextBox();
            this.telephone1 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefone2 = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.chk_not_email = new System.Windows.Forms.CheckBox();
            this.serie_year = new System.Windows.Forms.ComboBox();
            this.nis_pis = new System.Windows.Forms.MaskedTextBox();
            this.census_register = new System.Windows.Forms.MaskedTextBox();
            this.group_endereco = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zip_code = new System.Windows.Forms.MaskedTextBox();
            this.complement = new System.Windows.Forms.TextBox();
            this.number_location = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.district = new System.Windows.Forms.TextBox();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.lbl_project = new System.Windows.Forms.Label();
            this.lbl_telefone1 = new System.Windows.Forms.Label();
            this.lbl_nome_projeto = new System.Windows.Forms.Label();
            this.lbl_nome_mae = new System.Windows.Forms.Label();
            this.lbl_nome_pai = new System.Windows.Forms.Label();
            this.lbl_nis_pis = new System.Windows.Forms.Label();
            this.lbl_cad_censo = new System.Windows.Forms.Label();
            this.project_name = new System.Windows.Forms.TextBox();
            this.lbl_nome_aluno = new System.Windows.Forms.Label();
            this.mother_name = new System.Windows.Forms.TextBox();
            this.father_name = new System.Windows.Forms.TextBox();
            this.txt_nameStudent = new System.Windows.Forms.TextBox();
            this.lbl_serie_ano = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cpf_aluno = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.project = new System.Windows.Forms.ComboBox();
            this.group_turno.SuspendLayout();
            this.group_endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(332, 34);
            this.lbl_rua.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(40, 21);
            this.lbl_rua.TabIndex = 2;
            this.lbl_rua.Text = "Rua:";
            // 
            // btn_registerStudent
            // 
            this.btn_registerStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_registerStudent.FlatAppearance.BorderSize = 0;
            this.btn_registerStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_registerStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btn_registerStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registerStudent.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registerStudent.ForeColor = System.Drawing.Color.White;
            this.btn_registerStudent.Location = new System.Drawing.Point(886, 606);
            this.btn_registerStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_registerStudent.Name = "btn_registerStudent";
            this.btn_registerStudent.Size = new System.Drawing.Size(225, 68);
            this.btn_registerStudent.TabIndex = 40;
            this.btn_registerStudent.Text = "Realizar matrícula";
            this.btn_registerStudent.UseVisualStyleBackColor = false;
            this.btn_registerStudent.Click += new System.EventHandler(this.btn_registerStudent_Click);
            // 
            // group_turno
            // 
            this.group_turno.Controls.Add(this.rd_afternoon);
            this.group_turno.Controls.Add(this.rd_morning);
            this.group_turno.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_turno.Location = new System.Drawing.Point(57, 566);
            this.group_turno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_turno.Name = "group_turno";
            this.group_turno.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_turno.Size = new System.Drawing.Size(140, 108);
            this.group_turno.TabIndex = 12;
            this.group_turno.TabStop = false;
            this.group_turno.Text = "Turno";
            // 
            // rd_afternoon
            // 
            this.rd_afternoon.AutoSize = true;
            this.rd_afternoon.Location = new System.Drawing.Point(7, 63);
            this.rd_afternoon.Name = "rd_afternoon";
            this.rd_afternoon.Size = new System.Drawing.Size(103, 25);
            this.rd_afternoon.TabIndex = 1;
            this.rd_afternoon.TabStop = true;
            this.rd_afternoon.Text = "Vespertino";
            this.rd_afternoon.UseVisualStyleBackColor = true;
            // 
            // rd_morning
            // 
            this.rd_morning.AutoSize = true;
            this.rd_morning.Location = new System.Drawing.Point(7, 32);
            this.rd_morning.Name = "rd_morning";
            this.rd_morning.Size = new System.Drawing.Size(91, 25);
            this.rd_morning.TabIndex = 0;
            this.rd_morning.TabStop = true;
            this.rd_morning.Text = "Matutino";
            this.rd_morning.UseVisualStyleBackColor = true;
            // 
            // cpf_student
            // 
            this.cpf_student.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf_student.Location = new System.Drawing.Point(501, 61);
            this.cpf_student.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpf_student.Mask = "000,000,000-00";
            this.cpf_student.Name = "cpf_student";
            this.cpf_student.Size = new System.Drawing.Size(130, 29);
            this.cpf_student.TabIndex = 37;
            this.cpf_student.Text = "65475465465";
            // 
            // telephone2
            // 
            this.telephone2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone2.Location = new System.Drawing.Point(267, 400);
            this.telephone2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telephone2.Mask = "(00) 0 0000-0000";
            this.telephone2.Name = "telephone2";
            this.telephone2.Size = new System.Drawing.Size(130, 29);
            this.telephone2.TabIndex = 36;
            // 
            // telephone1
            // 
            this.telephone1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone1.Location = new System.Drawing.Point(57, 400);
            this.telephone1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telephone1.Mask = "(00) 0 0000-0000";
            this.telephone1.Name = "telephone1";
            this.telephone1.Size = new System.Drawing.Size(130, 29);
            this.telephone1.TabIndex = 35;
            // 
            // lbl_telefone2
            // 
            this.lbl_telefone2.AutoSize = true;
            this.lbl_telefone2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone2.Location = new System.Drawing.Point(262, 372);
            this.lbl_telefone2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_telefone2.Name = "lbl_telefone2";
            this.lbl_telefone2.Size = new System.Drawing.Size(81, 21);
            this.lbl_telefone2.TabIndex = 29;
            this.lbl_telefone2.Text = "Contato 2:";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(18, 34);
            this.lbl_cep.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(40, 21);
            this.lbl_cep.TabIndex = 2;
            this.lbl_cep.Text = "CEP:";
            // 
            // chk_not_email
            // 
            this.chk_not_email.AutoSize = true;
            this.chk_not_email.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_not_email.Location = new System.Drawing.Point(57, 524);
            this.chk_not_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_not_email.Name = "chk_not_email";
            this.chk_not_email.Size = new System.Drawing.Size(138, 25);
            this.chk_not_email.TabIndex = 41;
            this.chk_not_email.Text = "Não tem email?";
            this.chk_not_email.UseVisualStyleBackColor = true;
            this.chk_not_email.CheckedChanged += new System.EventHandler(this.chk_not_email_CheckedChanged);
            // 
            // serie_year
            // 
            this.serie_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serie_year.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie_year.FormattingEnabled = true;
            this.serie_year.Items.AddRange(new object[] {
            "Creche",
            "Maternal",
            "Infantil I",
            "Infantil II",
            "Projeto",
            "1º ano",
            "2º ano",
            "3º ano",
            "4º ano",
            "5º ano",
            "6º ano",
            "7º ano",
            "8º ano",
            "9º ano"});
            this.serie_year.Location = new System.Drawing.Point(267, 576);
            this.serie_year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serie_year.Name = "serie_year";
            this.serie_year.Size = new System.Drawing.Size(130, 29);
            this.serie_year.TabIndex = 38;
            this.serie_year.SelectedIndexChanged += new System.EventHandler(this.serie_year_SelectedIndexChanged);
            // 
            // nis_pis
            // 
            this.nis_pis.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nis_pis.Location = new System.Drawing.Point(968, 61);
            this.nis_pis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nis_pis.Mask = "00,000000,00-00";
            this.nis_pis.Name = "nis_pis";
            this.nis_pis.Size = new System.Drawing.Size(130, 29);
            this.nis_pis.TabIndex = 34;
            // 
            // census_register
            // 
            this.census_register.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.census_register.Location = new System.Drawing.Point(57, 143);
            this.census_register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.census_register.Mask = "00000000000000";
            this.census_register.Name = "census_register";
            this.census_register.Size = new System.Drawing.Size(140, 29);
            this.census_register.TabIndex = 33;
            // 
            // group_endereco
            // 
            this.group_endereco.Controls.Add(this.label1);
            this.group_endereco.Controls.Add(this.zip_code);
            this.group_endereco.Controls.Add(this.complement);
            this.group_endereco.Controls.Add(this.number_location);
            this.group_endereco.Controls.Add(this.city);
            this.group_endereco.Controls.Add(this.lbl_cidade);
            this.group_endereco.Controls.Add(this.district);
            this.group_endereco.Controls.Add(this.lbl_complemento);
            this.group_endereco.Controls.Add(this.lbl_bairro);
            this.group_endereco.Controls.Add(this.street);
            this.group_endereco.Controls.Add(this.lbl_rua);
            this.group_endereco.Controls.Add(this.lbl_cep);
            this.group_endereco.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_endereco.Location = new System.Drawing.Point(501, 100);
            this.group_endereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_endereco.Name = "group_endereco";
            this.group_endereco.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_endereco.Size = new System.Drawing.Size(610, 341);
            this.group_endereco.TabIndex = 32;
            this.group_endereco.TabStop = false;
            this.group_endereco.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número:";
            // 
            // zip_code
            // 
            this.zip_code.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip_code.Location = new System.Drawing.Point(22, 60);
            this.zip_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zip_code.Mask = "00000-000";
            this.zip_code.Name = "zip_code";
            this.zip_code.Size = new System.Drawing.Size(89, 29);
            this.zip_code.TabIndex = 7;
            this.zip_code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetAdress);
            // 
            // complement
            // 
            this.complement.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complement.Location = new System.Drawing.Point(336, 138);
            this.complement.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.complement.Multiline = true;
            this.complement.Name = "complement";
            this.complement.Size = new System.Drawing.Size(250, 136);
            this.complement.TabIndex = 6;
            // 
            // number_location
            // 
            this.number_location.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_location.Location = new System.Drawing.Point(24, 291);
            this.number_location.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.number_location.Name = "number_location";
            this.number_location.Size = new System.Drawing.Size(248, 29);
            this.number_location.TabIndex = 6;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(24, 216);
            this.city.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(248, 29);
            this.city.TabIndex = 6;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(20, 186);
            this.lbl_cidade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(61, 21);
            this.lbl_cidade.TabIndex = 2;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // district
            // 
            this.district.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.district.Location = new System.Drawing.Point(22, 138);
            this.district.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(250, 29);
            this.district.TabIndex = 6;
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_complemento.Location = new System.Drawing.Point(332, 108);
            this.lbl_complemento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(112, 21);
            this.lbl_complemento.TabIndex = 2;
            this.lbl_complemento.Text = "Complemento:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(18, 108);
            this.lbl_bairro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(55, 21);
            this.lbl_bairro.TabIndex = 2;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(336, 60);
            this.street.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(250, 29);
            this.street.TabIndex = 6;
            // 
            // birth_date
            // 
            this.birth_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birth_date.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Location = new System.Drawing.Point(735, 61);
            this.birth_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(130, 29);
            this.birth_date.TabIndex = 31;
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nascimento.Location = new System.Drawing.Point(731, 31);
            this.lbl_nascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(96, 21);
            this.lbl_nascimento.TabIndex = 28;
            this.lbl_nascimento.Text = "Nascimento:";
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_project.Location = new System.Drawing.Point(501, 458);
            this.lbl_project.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(63, 21);
            this.lbl_project.TabIndex = 27;
            this.lbl_project.Text = "Projeto:";
            this.lbl_project.Visible = false;
            // 
            // lbl_telefone1
            // 
            this.lbl_telefone1.AutoSize = true;
            this.lbl_telefone1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone1.Location = new System.Drawing.Point(53, 372);
            this.lbl_telefone1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_telefone1.Name = "lbl_telefone1";
            this.lbl_telefone1.Size = new System.Drawing.Size(81, 21);
            this.lbl_telefone1.TabIndex = 26;
            this.lbl_telefone1.Text = "Contato 1:";
            // 
            // lbl_nome_projeto
            // 
            this.lbl_nome_projeto.AutoSize = true;
            this.lbl_nome_projeto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_projeto.Location = new System.Drawing.Point(501, 545);
            this.lbl_nome_projeto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nome_projeto.Name = "lbl_nome_projeto";
            this.lbl_nome_projeto.Size = new System.Drawing.Size(132, 21);
            this.lbl_nome_projeto.TabIndex = 25;
            this.lbl_nome_projeto.Text = "Nome do projeto:";
            this.lbl_nome_projeto.Visible = false;
            // 
            // lbl_nome_mae
            // 
            this.lbl_nome_mae.AutoSize = true;
            this.lbl_nome_mae.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_mae.Location = new System.Drawing.Point(53, 285);
            this.lbl_nome_mae.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nome_mae.Name = "lbl_nome_mae";
            this.lbl_nome_mae.Size = new System.Drawing.Size(111, 21);
            this.lbl_nome_mae.TabIndex = 24;
            this.lbl_nome_mae.Text = "Nome da mãe:";
            // 
            // lbl_nome_pai
            // 
            this.lbl_nome_pai.AutoSize = true;
            this.lbl_nome_pai.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_pai.Location = new System.Drawing.Point(53, 198);
            this.lbl_nome_pai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nome_pai.Name = "lbl_nome_pai";
            this.lbl_nome_pai.Size = new System.Drawing.Size(103, 21);
            this.lbl_nome_pai.TabIndex = 23;
            this.lbl_nome_pai.Text = "Nome do pai:";
            // 
            // lbl_nis_pis
            // 
            this.lbl_nis_pis.AutoSize = true;
            this.lbl_nis_pis.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nis_pis.Location = new System.Drawing.Point(964, 31);
            this.lbl_nis_pis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nis_pis.Name = "lbl_nis_pis";
            this.lbl_nis_pis.Size = new System.Drawing.Size(63, 21);
            this.lbl_nis_pis.TabIndex = 22;
            this.lbl_nis_pis.Text = "NIS/PIS";
            // 
            // lbl_cad_censo
            // 
            this.lbl_cad_censo.AutoSize = true;
            this.lbl_cad_censo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cad_censo.Location = new System.Drawing.Point(53, 115);
            this.lbl_cad_censo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_cad_censo.Name = "lbl_cad_censo";
            this.lbl_cad_censo.Size = new System.Drawing.Size(141, 21);
            this.lbl_cad_censo.TabIndex = 21;
            this.lbl_cad_censo.Text = "Cadastro do censo:";
            // 
            // project_name
            // 
            this.project_name.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_name.Location = new System.Drawing.Point(501, 576);
            this.project_name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.project_name.Name = "project_name";
            this.project_name.Size = new System.Drawing.Size(240, 29);
            this.project_name.TabIndex = 17;
            this.project_name.Visible = false;
            // 
            // lbl_nome_aluno
            // 
            this.lbl_nome_aluno.AutoSize = true;
            this.lbl_nome_aluno.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_aluno.Location = new System.Drawing.Point(53, 31);
            this.lbl_nome_aluno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nome_aluno.Name = "lbl_nome_aluno";
            this.lbl_nome_aluno.Size = new System.Drawing.Size(121, 21);
            this.lbl_nome_aluno.TabIndex = 20;
            this.lbl_nome_aluno.Text = "Nome do aluno:";
            // 
            // mother_name
            // 
            this.mother_name.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mother_name.Location = new System.Drawing.Point(57, 314);
            this.mother_name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.mother_name.Name = "mother_name";
            this.mother_name.Size = new System.Drawing.Size(340, 29);
            this.mother_name.TabIndex = 16;
            this.mother_name.Text = "Neurizan Rodrigues Costa";
            // 
            // father_name
            // 
            this.father_name.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.father_name.Location = new System.Drawing.Point(57, 228);
            this.father_name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.father_name.Name = "father_name";
            this.father_name.Size = new System.Drawing.Size(340, 29);
            this.father_name.TabIndex = 15;
            this.father_name.Text = "Francisco Francisne Alves Ferreira";
            // 
            // txt_nameStudent
            // 
            this.txt_nameStudent.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameStudent.Location = new System.Drawing.Point(57, 61);
            this.txt_nameStudent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_nameStudent.Name = "txt_nameStudent";
            this.txt_nameStudent.Size = new System.Drawing.Size(340, 29);
            this.txt_nameStudent.TabIndex = 14;
            this.txt_nameStudent.Text = "Matheus Costa";
            // 
            // lbl_serie_ano
            // 
            this.lbl_serie_ano.AutoSize = true;
            this.lbl_serie_ano.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serie_ano.Location = new System.Drawing.Point(263, 545);
            this.lbl_serie_ano.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_serie_ano.Name = "lbl_serie_ano";
            this.lbl_serie_ano.Size = new System.Drawing.Size(79, 21);
            this.lbl_serie_ano.TabIndex = 19;
            this.lbl_serie_ano.Text = "Série/Ano";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(53, 458);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 21);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_cpf_aluno
            // 
            this.lbl_cpf_aluno.AutoSize = true;
            this.lbl_cpf_aluno.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf_aluno.Location = new System.Drawing.Point(497, 31);
            this.lbl_cpf_aluno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_cpf_aluno.Name = "lbl_cpf_aluno";
            this.lbl_cpf_aluno.Size = new System.Drawing.Size(105, 21);
            this.lbl_cpf_aluno.TabIndex = 30;
            this.lbl_cpf_aluno.Text = "CPF do aluno:";
            // 
            // input_email
            // 
            this.input_email.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_email.Location = new System.Drawing.Point(57, 488);
            this.input_email.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(340, 29);
            this.input_email.TabIndex = 13;
            this.input_email.Text = "teste@teste.com";
            // 
            // project
            // 
            this.project.DropDownHeight = 200;
            this.project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.project.DropDownWidth = 150;
            this.project.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project.FormattingEnabled = true;
            this.project.IntegralHeight = false;
            this.project.Items.AddRange(new object[] {
            "Taekwondo",
            "Marcenaria",
            "Melhor idade",
            "Bombeiro mirim",
            "Vida e movimento",
            "SCFV",
            "Outros"});
            this.project.Location = new System.Drawing.Point(501, 484);
            this.project.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(150, 29);
            this.project.TabIndex = 38;
            this.project.Visible = false;
            this.project.SelectedIndexChanged += new System.EventHandler(this.project_SelectedIndexChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1171, 749);
            this.Controls.Add(this.btn_registerStudent);
            this.Controls.Add(this.group_turno);
            this.Controls.Add(this.cpf_student);
            this.Controls.Add(this.telephone2);
            this.Controls.Add(this.telephone1);
            this.Controls.Add(this.lbl_telefone2);
            this.Controls.Add(this.chk_not_email);
            this.Controls.Add(this.project);
            this.Controls.Add(this.serie_year);
            this.Controls.Add(this.nis_pis);
            this.Controls.Add(this.census_register);
            this.Controls.Add(this.group_endereco);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.lbl_telefone1);
            this.Controls.Add(this.lbl_nome_projeto);
            this.Controls.Add(this.lbl_nome_mae);
            this.Controls.Add(this.lbl_nome_pai);
            this.Controls.Add(this.lbl_nis_pis);
            this.Controls.Add(this.lbl_cad_censo);
            this.Controls.Add(this.project_name);
            this.Controls.Add(this.lbl_nome_aluno);
            this.Controls.Add(this.mother_name);
            this.Controls.Add(this.father_name);
            this.Controls.Add(this.txt_nameStudent);
            this.Controls.Add(this.lbl_serie_ano);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_cpf_aluno);
            this.Controls.Add(this.input_email);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRegister";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.group_turno.ResumeLayout(false);
            this.group_turno.PerformLayout();
            this.group_endereco.ResumeLayout(false);
            this.group_endereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.Button btn_registerStudent;
        private System.Windows.Forms.GroupBox group_turno;
        private System.Windows.Forms.MaskedTextBox cpf_student;
        private System.Windows.Forms.MaskedTextBox telephone2;
        private System.Windows.Forms.MaskedTextBox telephone1;
        private System.Windows.Forms.Label lbl_telefone2;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.CheckBox chk_not_email;
        private System.Windows.Forms.ComboBox serie_year;
        private System.Windows.Forms.MaskedTextBox nis_pis;
        private System.Windows.Forms.MaskedTextBox census_register;
        private System.Windows.Forms.GroupBox group_endereco;
        private System.Windows.Forms.MaskedTextBox zip_code;
        private System.Windows.Forms.TextBox complement;
        private System.Windows.Forms.TextBox number_location;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.Label lbl_complemento;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.DateTimePicker birth_date;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Label lbl_telefone1;
        private System.Windows.Forms.Label lbl_nome_projeto;
        private System.Windows.Forms.Label lbl_nome_mae;
        private System.Windows.Forms.Label lbl_nome_pai;
        private System.Windows.Forms.Label lbl_nis_pis;
        private System.Windows.Forms.Label lbl_cad_censo;
        private System.Windows.Forms.TextBox project_name;
        private System.Windows.Forms.Label lbl_nome_aluno;
        private System.Windows.Forms.TextBox mother_name;
        private System.Windows.Forms.TextBox father_name;
        private System.Windows.Forms.TextBox txt_nameStudent;
        private System.Windows.Forms.Label lbl_serie_ano;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_cpf_aluno;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox project;
        private System.Windows.Forms.RadioButton rd_afternoon;
        private System.Windows.Forms.RadioButton rd_morning;
    }
}