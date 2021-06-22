
namespace Aula01DB.View
{
    partial class FrmTurma
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
            this.LblCodigoTurma = new System.Windows.Forms.Label();
            this.TxtCodigoTurma = new System.Windows.Forms.TextBox();
            this.LblCurso = new System.Windows.Forms.Label();
            this.CboCurso = new System.Windows.Forms.ComboBox();
            this.LblSemestre = new System.Windows.Forms.Label();
            this.CboSemestre = new System.Windows.Forms.ComboBox();
            this.LblAno = new System.Windows.Forms.Label();
            this.CboAno = new System.Windows.Forms.ComboBox();
            this.GridItens = new System.Windows.Forms.DataGridView();
            this.MatriculaAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblAluno = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.CboAluno = new System.Windows.Forms.ComboBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigoTurma
            // 
            this.LblCodigoTurma.AutoSize = true;
            this.LblCodigoTurma.Location = new System.Drawing.Point(12, 9);
            this.LblCodigoTurma.Name = "LblCodigoTurma";
            this.LblCodigoTurma.Size = new System.Drawing.Size(99, 15);
            this.LblCodigoTurma.TabIndex = 0;
            this.LblCodigoTurma.Text = "Código da Turma";
            // 
            // TxtCodigoTurma
            // 
            this.TxtCodigoTurma.Location = new System.Drawing.Point(117, 6);
            this.TxtCodigoTurma.MaxLength = 6;
            this.TxtCodigoTurma.Name = "TxtCodigoTurma";
            this.TxtCodigoTurma.Size = new System.Drawing.Size(112, 23);
            this.TxtCodigoTurma.TabIndex = 1;
            this.TxtCodigoTurma.Leave += new System.EventHandler(this.TxtCodigoTurma_Leave);
            // 
            // LblCurso
            // 
            this.LblCurso.AutoSize = true;
            this.LblCurso.Location = new System.Drawing.Point(73, 46);
            this.LblCurso.Name = "LblCurso";
            this.LblCurso.Size = new System.Drawing.Size(38, 15);
            this.LblCurso.TabIndex = 2;
            this.LblCurso.Text = "Curso";
            // 
            // CboCurso
            // 
            this.CboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCurso.FormattingEnabled = true;
            this.CboCurso.Location = new System.Drawing.Point(117, 38);
            this.CboCurso.Name = "CboCurso";
            this.CboCurso.Size = new System.Drawing.Size(504, 23);
            this.CboCurso.TabIndex = 3;
            // 
            // LblSemestre
            // 
            this.LblSemestre.AutoSize = true;
            this.LblSemestre.Location = new System.Drawing.Point(56, 73);
            this.LblSemestre.Name = "LblSemestre";
            this.LblSemestre.Size = new System.Drawing.Size(55, 15);
            this.LblSemestre.TabIndex = 4;
            this.LblSemestre.Text = "Semestre";
            // 
            // CboSemestre
            // 
            this.CboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSemestre.FormattingEnabled = true;
            this.CboSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CboSemestre.Location = new System.Drawing.Point(117, 70);
            this.CboSemestre.Name = "CboSemestre";
            this.CboSemestre.Size = new System.Drawing.Size(112, 23);
            this.CboSemestre.TabIndex = 5;
            // 
            // LblAno
            // 
            this.LblAno.AutoSize = true;
            this.LblAno.Location = new System.Drawing.Point(246, 73);
            this.LblAno.Name = "LblAno";
            this.LblAno.Size = new System.Drawing.Size(29, 15);
            this.LblAno.TabIndex = 6;
            this.LblAno.Text = "Ano";
            // 
            // CboAno
            // 
            this.CboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAno.FormattingEnabled = true;
            this.CboAno.Location = new System.Drawing.Point(281, 73);
            this.CboAno.Name = "CboAno";
            this.CboAno.Size = new System.Drawing.Size(112, 23);
            this.CboAno.TabIndex = 7;
            // 
            // GridItens
            // 
            this.GridItens.AllowUserToAddRows = false;
            this.GridItens.AllowUserToDeleteRows = false;
            this.GridItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatriculaAluno,
            this.Nome,
            this.DataEntrada,
            this.BtnExcluir});
            this.GridItens.Location = new System.Drawing.Point(0, 199);
            this.GridItens.Name = "GridItens";
            this.GridItens.RowTemplate.Height = 25;
            this.GridItens.Size = new System.Drawing.Size(800, 249);
            this.GridItens.TabIndex = 8;
            this.GridItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItens_CellClick);
            // 
            // MatriculaAluno
            // 
            this.MatriculaAluno.DataPropertyName = "MatriculaAluno";
            this.MatriculaAluno.HeaderText = "Matricula";
            this.MatriculaAluno.Name = "MatriculaAluno";
            this.MatriculaAluno.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = " Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // DataEntrada
            // 
            this.DataEntrada.DataPropertyName = "DataEntrada";
            this.DataEntrada.HeaderText = "Data de Entrada";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.ReadOnly = true;
            this.DataEntrada.Width = 150;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            // 
            // LblAluno
            // 
            this.LblAluno.AutoSize = true;
            this.LblAluno.Location = new System.Drawing.Point(73, 118);
            this.LblAluno.Name = "LblAluno";
            this.LblAluno.Size = new System.Drawing.Size(39, 15);
            this.LblAluno.TabIndex = 9;
            this.LblAluno.Text = "Aluno";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(118, 115);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(112, 23);
            this.TxtMatricula.TabIndex = 10;
            this.TxtMatricula.TextChanged += new System.EventHandler(this.TxtMatricula_TextChanged);
            // 
            // CboAluno
            // 
            this.CboAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAluno.FormattingEnabled = true;
            this.CboAluno.Location = new System.Drawing.Point(246, 115);
            this.CboAluno.Name = "CboAluno";
            this.CboAluno.Size = new System.Drawing.Size(525, 23);
            this.CboAluno.TabIndex = 11;
            this.CboAluno.SelectedIndexChanged += new System.EventHandler(this.CboAluno_SelectedIndexChanged);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(170, 159);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(105, 34);
            this.BtnSalvar.TabIndex = 12;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(290, 159);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(103, 34);
            this.BtnLimpar.TabIndex = 13;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // FrmTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.CboAluno);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.LblAluno);
            this.Controls.Add(this.GridItens);
            this.Controls.Add(this.CboAno);
            this.Controls.Add(this.LblAno);
            this.Controls.Add(this.CboSemestre);
            this.Controls.Add(this.LblSemestre);
            this.Controls.Add(this.CboCurso);
            this.Controls.Add(this.LblCurso);
            this.Controls.Add(this.TxtCodigoTurma);
            this.Controls.Add(this.LblCodigoTurma);
            this.Name = "FrmTurma";
            this.Text = "Cadastro de Turmas";
            this.Load += new System.EventHandler(this.FrmTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigoTurma;
        private System.Windows.Forms.TextBox TxtCodigoTurma;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.ComboBox CboCurso;
        private System.Windows.Forms.Label LblSemestre;
        private System.Windows.Forms.ComboBox CboSemestre;
        private System.Windows.Forms.Label LblAno;
        private System.Windows.Forms.ComboBox CboAno;
        private System.Windows.Forms.DataGridView GridItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatriculaAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.Label LblAluno;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.ComboBox CboAluno;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
    }
}