
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
            this.chk_shearch_name = new System.Windows.Forms.CheckBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.Pes = new System.Windows.Forms.GroupBox();
            this.panel_data_shearch = new System.Windows.Forms.Panel();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_birth_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_student_name = new System.Windows.Forms.Label();
            this.lbl_birth_date = new System.Windows.Forms.Label();
            this.btn_shearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpf_student = new System.Windows.Forms.TextBox();
            this.Pes.SuspendLayout();
            this.panel_data_shearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_title.Location = new System.Drawing.Point(390, 50);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(390, 32);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Atualizar matrícula do estudante";
            // 
            // chk_shearch_name
            // 
            this.chk_shearch_name.AutoSize = true;
            this.chk_shearch_name.Location = new System.Drawing.Point(22, 27);
            this.chk_shearch_name.Name = "chk_shearch_name";
            this.chk_shearch_name.Size = new System.Drawing.Size(282, 25);
            this.chk_shearch_name.TabIndex = 3;
            this.chk_shearch_name.Text = "Pesquisa por nome do estudante ";
            this.chk_shearch_name.UseVisualStyleBackColor = true;
            this.chk_shearch_name.CheckedChanged += new System.EventHandler(this.chk_shearch_name_CheckedChanged);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_cpf.Location = new System.Drawing.Point(100, 126);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(146, 21);
            this.lbl_cpf.TabIndex = 5;
            this.lbl_cpf.Text = "CPF do estudante:";
            // 
            // Pes
            // 
            this.Pes.Controls.Add(this.panel_data_shearch);
            this.Pes.Controls.Add(this.chk_shearch_name);
            this.Pes.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pes.ForeColor = System.Drawing.Color.DimGray;
            this.Pes.Location = new System.Drawing.Point(333, 126);
            this.Pes.Name = "Pes";
            this.Pes.Size = new System.Drawing.Size(614, 146);
            this.Pes.TabIndex = 7;
            this.Pes.TabStop = false;
            this.Pes.Text = "Não tem o CPF do estudante?";
            // 
            // panel_data_shearch
            // 
            this.panel_data_shearch.Controls.Add(this.input_name);
            this.panel_data_shearch.Controls.Add(this.input_birth_date);
            this.panel_data_shearch.Controls.Add(this.lbl_student_name);
            this.panel_data_shearch.Controls.Add(this.lbl_birth_date);
            this.panel_data_shearch.Location = new System.Drawing.Point(6, 53);
            this.panel_data_shearch.Name = "panel_data_shearch";
            this.panel_data_shearch.Size = new System.Drawing.Size(602, 86);
            this.panel_data_shearch.TabIndex = 0;
            this.panel_data_shearch.Visible = false;
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(8, 40);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(342, 28);
            this.input_name.TabIndex = 7;
            // 
            // input_birth_date
            // 
            this.input_birth_date.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_birth_date.Location = new System.Drawing.Point(394, 40);
            this.input_birth_date.Name = "input_birth_date";
            this.input_birth_date.Size = new System.Drawing.Size(200, 29);
            this.input_birth_date.TabIndex = 10;
            // 
            // lbl_student_name
            // 
            this.lbl_student_name.AutoSize = true;
            this.lbl_student_name.Location = new System.Drawing.Point(4, 12);
            this.lbl_student_name.Name = "lbl_student_name";
            this.lbl_student_name.Size = new System.Drawing.Size(165, 21);
            this.lbl_student_name.TabIndex = 8;
            this.lbl_student_name.Text = "Nome do estudante:";
            // 
            // lbl_birth_date
            // 
            this.lbl_birth_date.AutoSize = true;
            this.lbl_birth_date.Location = new System.Drawing.Point(390, 12);
            this.lbl_birth_date.Name = "lbl_birth_date";
            this.lbl_birth_date.Size = new System.Drawing.Size(166, 21);
            this.lbl_birth_date.TabIndex = 9;
            this.lbl_birth_date.Text = "Data de nascimento:";
            // 
            // btn_shearch
            // 
            this.btn_shearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btn_shearch.FlatAppearance.BorderSize = 0;
            this.btn_shearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_shearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(242)))));
            this.btn_shearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shearch.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shearch.ForeColor = System.Drawing.Color.White;
            this.btn_shearch.Location = new System.Drawing.Point(104, 208);
            this.btn_shearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_shearch.Name = "btn_shearch";
            this.btn_shearch.Size = new System.Drawing.Size(178, 57);
            this.btn_shearch.TabIndex = 41;
            this.btn_shearch.Text = "Buscar";
            this.btn_shearch.UseVisualStyleBackColor = false;
            this.btn_shearch.Click += new System.EventHandler(this.btn_shearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 381);
            this.dataGridView1.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(104, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 381);
            this.panel1.TabIndex = 43;
            // 
            // cpf_student
            // 
            this.cpf_student.Location = new System.Drawing.Point(104, 150);
            this.cpf_student.MaxLength = 11;
            this.cpf_student.Name = "cpf_student";
            this.cpf_student.Size = new System.Drawing.Size(137, 29);
            this.cpf_student.TabIndex = 89;
            this.cpf_student.Tag = "0";
            this.cpf_student.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_cpf_KeyPress);
            this.cpf_student.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cpf_student_KeyUp);
            // 
            // FormUpdateRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1171, 749);
            this.Controls.Add(this.cpf_student);
            this.Controls.Add(this.btn_shearch);
            this.Controls.Add(this.Pes);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUpdateRegister";
            this.Text = "FormUpdateRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Pes.ResumeLayout(false);
            this.Pes.PerformLayout();
            this.panel_data_shearch.ResumeLayout(false);
            this.panel_data_shearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.CheckBox chk_shearch_name;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.GroupBox Pes;
        private System.Windows.Forms.Panel panel_data_shearch;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.DateTimePicker input_birth_date;
        private System.Windows.Forms.Label lbl_student_name;
        private System.Windows.Forms.Label lbl_birth_date;
        private System.Windows.Forms.Button btn_shearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cpf_student;
    }
}