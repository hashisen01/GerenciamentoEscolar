
namespace GerenciamentoEscolar.Pages
{
    partial class FormUpdateRegister
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.panel_shearch = new System.Windows.Forms.Panel();
            this.cpf_student = new System.Windows.Forms.TextBox();
            this.chk_shearch_name = new System.Windows.Forms.CheckBox();
            this.panel_name_date = new System.Windows.Forms.Panel();
            this.lbl_student_name = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lbl_birth_date = new System.Windows.Forms.Label();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.btn_shearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.noResult = new System.Windows.Forms.PictureBox();
            this.notFound = new System.Windows.Forms.Label();
            this.chkShearchByStatus = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.rdInactive = new System.Windows.Forms.RadioButton();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.panel_shearch.SuspendLayout();
            this.panel_name_date.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noResult)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(372, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(438, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Atualizar matrícula do estudante";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_cpf.Font = new System.Drawing.Font("Ebrima", 12F);
            this.lbl_cpf.ForeColor = System.Drawing.Color.Black;
            this.lbl_cpf.Location = new System.Drawing.Point(3, 4);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(134, 21);
            this.lbl_cpf.TabIndex = 5;
            this.lbl_cpf.Text = "CPF do estudante:";
            // 
            // panel_shearch
            // 
            this.panel_shearch.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_shearch.Controls.Add(this.lbl_cpf);
            this.panel_shearch.Controls.Add(this.cpf_student);
            this.panel_shearch.Controls.Add(this.chk_shearch_name);
            this.panel_shearch.Controls.Add(this.panel_name_date);
            this.panel_shearch.Location = new System.Drawing.Point(101, 109);
            this.panel_shearch.Name = "panel_shearch";
            this.panel_shearch.Size = new System.Drawing.Size(566, 139);
            this.panel_shearch.TabIndex = 0;
            // 
            // cpf_student
            // 
            this.cpf_student.Location = new System.Drawing.Point(7, 28);
            this.cpf_student.MaxLength = 14;
            this.cpf_student.Name = "cpf_student";
            this.cpf_student.Size = new System.Drawing.Size(137, 29);
            this.cpf_student.TabIndex = 89;
            this.cpf_student.Tag = "0";
            this.cpf_student.Text = "Digite o cpf...";
            this.cpf_student.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_cpf_KeyPress);
            this.cpf_student.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cpf_student_KeyUp);
            // 
            // chk_shearch_name
            // 
            this.chk_shearch_name.AutoSize = true;
            this.chk_shearch_name.BackColor = System.Drawing.Color.Gainsboro;
            this.chk_shearch_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_shearch_name.Font = new System.Drawing.Font("Ebrima", 12F);
            this.chk_shearch_name.ForeColor = System.Drawing.Color.Black;
            this.chk_shearch_name.Location = new System.Drawing.Point(285, 37);
            this.chk_shearch_name.Name = "chk_shearch_name";
            this.chk_shearch_name.Size = new System.Drawing.Size(260, 25);
            this.chk_shearch_name.TabIndex = 3;
            this.chk_shearch_name.Text = "Pesquisa por nome do estudante ";
            this.chk_shearch_name.UseVisualStyleBackColor = false;
            this.chk_shearch_name.CheckedChanged += new System.EventHandler(this.chk_shearch_name_CheckedChanged);
            // 
            // panel_name_date
            // 
            this.panel_name_date.Controls.Add(this.lbl_student_name);
            this.panel_name_date.Controls.Add(this.name);
            this.panel_name_date.Controls.Add(this.lbl_birth_date);
            this.panel_name_date.Controls.Add(this.birth_date);
            this.panel_name_date.Location = new System.Drawing.Point(0, 79);
            this.panel_name_date.Name = "panel_name_date";
            this.panel_name_date.Size = new System.Drawing.Size(566, 60);
            this.panel_name_date.TabIndex = 95;
            this.panel_name_date.Visible = false;
            // 
            // lbl_student_name
            // 
            this.lbl_student_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_student_name.AutoSize = true;
            this.lbl_student_name.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_student_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_student_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_student_name.Name = "lbl_student_name";
            this.lbl_student_name.Size = new System.Drawing.Size(150, 21);
            this.lbl_student_name.TabIndex = 8;
            this.lbl_student_name.Text = "Nome do estudante:";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(7, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(328, 29);
            this.name.TabIndex = 7;
            // 
            // lbl_birth_date
            // 
            this.lbl_birth_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_birth_date.AutoSize = true;
            this.lbl_birth_date.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_birth_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_birth_date.Location = new System.Drawing.Point(406, 0);
            this.lbl_birth_date.Name = "lbl_birth_date";
            this.lbl_birth_date.Size = new System.Drawing.Size(150, 21);
            this.lbl_birth_date.TabIndex = 9;
            this.lbl_birth_date.Text = "Data de nascimento:";
            // 
            // birth_date
            // 
            this.birth_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birth_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birth_date.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Location = new System.Drawing.Point(410, 28);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(130, 29);
            this.birth_date.TabIndex = 10;
            // 
            // btn_shearch
            // 
            this.btn_shearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btn_shearch.FlatAppearance.BorderSize = 0;
            this.btn_shearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(255)))), ((int)(((byte)(75)))));
            this.btn_shearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(255)))), ((int)(((byte)(40)))));
            this.btn_shearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shearch.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shearch.ForeColor = System.Drawing.Color.White;
            this.btn_shearch.Location = new System.Drawing.Point(883, 191);
            this.btn_shearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_shearch.Name = "btn_shearch";
            this.btn_shearch.Size = new System.Drawing.Size(178, 57);
            this.btn_shearch.TabIndex = 41;
            this.btn_shearch.Text = "Buscar";
            this.btn_shearch.UseVisualStyleBackColor = false;
            this.btn_shearch.Click += new System.EventHandler(this.btn_shearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowPanel);
            this.panel1.Location = new System.Drawing.Point(106, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 381);
            this.panel1.TabIndex = 43;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(960, 381);
            this.flowPanel.TabIndex = 0;
            // 
            // noResult
            // 
            this.noResult.Image = global::GerenciamentoEscolar.Properties.Resources.no_results;
            this.noResult.Location = new System.Drawing.Point(522, 391);
            this.noResult.Name = "noResult";
            this.noResult.Size = new System.Drawing.Size(130, 130);
            this.noResult.TabIndex = 0;
            this.noResult.TabStop = false;
            this.noResult.Visible = false;
            // 
            // notFound
            // 
            this.notFound.AutoSize = true;
            this.notFound.Font = new System.Drawing.Font("Ebrima", 18F);
            this.notFound.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.notFound.Location = new System.Drawing.Point(397, 545);
            this.notFound.Name = "notFound";
            this.notFound.Size = new System.Drawing.Size(387, 32);
            this.notFound.TabIndex = 93;
            this.notFound.Text = "Nenhum resultado para essa busca";
            this.notFound.Visible = false;
            // 
            // chkShearchByStatus
            // 
            this.chkShearchByStatus.AutoSize = true;
            this.chkShearchByStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.chkShearchByStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShearchByStatus.ForeColor = System.Drawing.Color.Black;
            this.chkShearchByStatus.Location = new System.Drawing.Point(679, 15);
            this.chkShearchByStatus.Name = "chkShearchByStatus";
            this.chkShearchByStatus.Size = new System.Drawing.Size(176, 25);
            this.chkShearchByStatus.TabIndex = 0;
            this.chkShearchByStatus.Text = "Pesquisar por status?";
            this.chkShearchByStatus.UseVisualStyleBackColor = false;
            this.chkShearchByStatus.CheckedChanged += new System.EventHandler(this.chkShearchByStatus_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.chkShearchByStatus);
            this.panel2.Controls.Add(this.groupStatus);
            this.panel2.Location = new System.Drawing.Point(43, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 197);
            this.panel2.TabIndex = 95;
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.rdInactive);
            this.groupStatus.Controls.Add(this.rdActive);
            this.groupStatus.Controls.Add(this.rdAll);
            this.groupStatus.Location = new System.Drawing.Point(670, 15);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(348, 70);
            this.groupStatus.TabIndex = 1;
            this.groupStatus.TabStop = false;
            // 
            // rdInactive
            // 
            this.rdInactive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdInactive.AutoSize = true;
            this.rdInactive.BackColor = System.Drawing.Color.Gainsboro;
            this.rdInactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdInactive.ForeColor = System.Drawing.Color.Black;
            this.rdInactive.Location = new System.Drawing.Point(258, 39);
            this.rdInactive.Name = "rdInactive";
            this.rdInactive.Size = new System.Drawing.Size(82, 25);
            this.rdInactive.TabIndex = 98;
            this.rdInactive.TabStop = true;
            this.rdInactive.Text = "Inativos";
            this.rdInactive.UseVisualStyleBackColor = false;
            this.rdInactive.Visible = false;
            // 
            // rdActive
            // 
            this.rdActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdActive.AutoSize = true;
            this.rdActive.BackColor = System.Drawing.Color.Gainsboro;
            this.rdActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdActive.ForeColor = System.Drawing.Color.Black;
            this.rdActive.Location = new System.Drawing.Point(133, 39);
            this.rdActive.Name = "rdActive";
            this.rdActive.Size = new System.Drawing.Size(71, 25);
            this.rdActive.TabIndex = 97;
            this.rdActive.TabStop = true;
            this.rdActive.Text = "Ativos";
            this.rdActive.UseVisualStyleBackColor = false;
            this.rdActive.Visible = false;
            // 
            // rdAll
            // 
            this.rdAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdAll.AutoSize = true;
            this.rdAll.BackColor = System.Drawing.Color.Gainsboro;
            this.rdAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdAll.ForeColor = System.Drawing.Color.Black;
            this.rdAll.Location = new System.Drawing.Point(8, 39);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(70, 25);
            this.rdAll.TabIndex = 96;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Todos";
            this.rdAll.UseVisualStyleBackColor = false;
            this.rdAll.Visible = false;
            // 
            // FormUpdateRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 749);
            this.Controls.Add(this.notFound);
            this.Controls.Add(this.noResult);
            this.Controls.Add(this.btn_shearch);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_shearch);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUpdateRegister";
            this.Text = "FormUpdateRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUpdateRegister_Load);
            this.panel_shearch.ResumeLayout(false);
            this.panel_shearch.PerformLayout();
            this.panel_name_date.ResumeLayout(false);
            this.panel_name_date.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noResult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Panel panel_shearch;
        private System.Windows.Forms.Button btn_shearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cpf_student;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.PictureBox noResult;
        private System.Windows.Forms.Label notFound;
        private System.Windows.Forms.CheckBox chkShearchByStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.RadioButton rdInactive;
        private System.Windows.Forms.RadioButton rdActive;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.CheckBox chk_shearch_name;
        private System.Windows.Forms.Panel panel_name_date;
        private System.Windows.Forms.Label lbl_student_name;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label lbl_birth_date;
        private System.Windows.Forms.DateTimePicker birth_date;
    }
}