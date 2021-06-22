using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula01DB.Model;
using Aula01DB.View.Control;

namespace Aula01DB.View
{
    public partial class FrmCurso : Form
    {

        private CCurso Control;
        private Curso oCurso;



        public FrmCurso()
        {
            InitializeComponent();
            Control = new CCurso();
        }

        private void CarregarGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Control.TodosCursos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void FrmCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Control.Dispose();
        }

        private bool VerificaControles()
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Preenchar o conteúdo do campo Nome", ProductName, MessageBoxButtons.OK);
                TxtNome.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LimpaControles()
        {
            TxtCodigoCurso.Text = "";
            TxtNome.Text = "";
        }



        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (VerificaControles())
            {

                if (TxtCodigoCurso.Text.Trim() == "")
                {
                    Curso oCurso = new Curso();
                    oCurso.Nome = TxtNome.Text;
                    Control.incluir(oCurso);
                    CarregarGrid();
                    LimpaControles();
                    MessageBox.Show("Registro Incluído com sucesso!", ProductName, MessageBoxButtons.OK);
                }
                else
                {
                    oCurso.Nome = TxtNome.Text;
                    Control.Alterar(oCurso);
                    CarregarGrid();
                    LimpaControles();
                    MessageBox.Show("Registro Alterado com sucesso!", ProductName, MessageBoxButtons.OK);


                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null) // registro de database
            {
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    oCurso = (Curso)GrdItens.Rows[e.RowIndex].DataBoundItem;
                    TxtCodigoCurso.Text = oCurso.CodigoCurso.ToString();
                    TxtNome.Text = oCurso.Nome;
                    TxtNome.Focus();
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Deseja excluir ?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                    {
                        oCurso = (Curso)GrdItens.Rows[e.RowIndex].DataBoundItem;
                        Control.Excluir(oCurso);
                        CarregarGrid();
                    }




                }

            }
        }
    }
}