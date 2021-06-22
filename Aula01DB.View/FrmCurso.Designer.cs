
namespace Aula01DB.View
{
    partial class FrmCurso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCodigoCurso = new System.Windows.Forms.Label();
            this.TxtCodigoCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.GrdItens = new System.Windows.Forms.DataGridView();
            this.CodigoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigoCurso
            // 
            this.LblCodigoCurso.AutoSize = true;
            this.LblCodigoCurso.Location = new System.Drawing.Point(12, 9);
            this.LblCodigoCurso.Name = "LblCodigoCurso";
            this.LblCodigoCurso.Size = new System.Drawing.Size(46, 15);
            this.LblCodigoCurso.TabIndex = 0;
            this.LblCodigoCurso.Text = "Código";
            this.LblCodigoCurso.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtCodigoCurso
            // 
            this.TxtCodigoCurso.Enabled = false;
            this.TxtCodigoCurso.Location = new System.Drawing.Point(74, 6);
            this.TxtCodigoCurso.MaxLength = 6;
            this.TxtCodigoCurso.Name = "TxtCodigoCurso";
            this.TxtCodigoCurso.Size = new System.Drawing.Size(65, 23);
            this.TxtCodigoCurso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(74, 42);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(663, 23);
            this.TxtNome.TabIndex = 3;
            // 
            // GrdItens
            // 
            this.GrdItens.AllowUserToAddRows = false;
            this.GrdItens.AllowUserToDeleteRows = false;
            this.GrdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCurso,
            this.Nome,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdItens.Location = new System.Drawing.Point(2, 104);
            this.GrdItens.Name = "GrdItens";
            this.GrdItens.RowTemplate.Height = 25;
            this.GrdItens.Size = new System.Drawing.Size(793, 346);
            this.GrdItens.TabIndex = 4;
            this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
            // 
            // CodigoCurso
            // 
            this.CodigoCurso.DataPropertyName = "CodigoCurso";
            this.CodigoCurso.HeaderText = "C-Curso";
            this.CodigoCurso.Name = "CodigoCurso";
            this.CodigoCurso.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 350;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(74, 71);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(134, 27);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.GrdItens);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigoCurso);
            this.Controls.Add(this.LblCodigoCurso);
            this.Name = "FrmCurso";
            this.Text = "Cadastrar Curso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCurso_FormClosed);
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigoCurso;
        private System.Windows.Forms.TextBox TxtCodigoCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.Button BtnSalvar;
    }
}

