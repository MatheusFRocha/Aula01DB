using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula01DB.View.Control;
using Aula01DB.Model;

namespace Aula01DB.View
{
    public partial class FrmTurma : Form
    {
        private CTurma Control = new CTurma();
        public FrmTurma()
        {
            InitializeComponent();
        }


        public void CarregaGrid()
        {
            GridItens.AutoGenerateColumns = false;
            if (TxtCodigoTurma.Text.Trim() == "")
            {
                GridItens.DataSource = null;
            }
            else
            {
                GridItens.DataSource = Control.SelecionarAlunosTurma(int.Parse(TxtCodigoTurma.Text));
            }

        }


        private void carregacombos()
        {
            CboCurso.ValueMember = "CodigoCurso";
            CboCurso.DisplayMember = "Nome";
            CboCurso.DataSource = Control.SelecionarTodosCursos();

            // for (int i = 1999; i <= DateTime.Now.Year; i++)
            // {
            //     CboAno.Items.Add(i.ToString());
            // }
            // CboAno.SelectedIndex = CboAno.Items.Count - 1;

            for (int i = 1999; i <= Control.DataHora().Year; i++)
            {
                CboAno.Items.Add(i.ToString());
            }
            CboAno.SelectedIndex = CboAno.Items.Count - 1;


            CboAluno.ValueMember = "Matricula";
            CboAluno.DisplayMember = "Nome";
            CboAluno.DataSource = Control.SelecionarTodosAlunos();


        }


        private void FrmTurma_Load(object sender, EventArgs e)
        {
            carregacombos();
        }

        private void CboAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboAluno.SelectedValue != null)
            {
                //Aluno oAluno = (Aluno)CboAluno.SelectedItem;
                //TxtMatricula.Text = oAluno.Matricula;

                TxtMatricula.Text = CboAluno.SelectedValue.ToString();
            }
            else
            {

            }
        }

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {
            if (TxtMatricula.Text == "")
            {
                CboAluno.SelectedIndex = -1;
            }
            else
            {
                CboAluno.SelectedValue = TxtMatricula.Text;
            }
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (TxtCodigoTurma.Text.Trim() == "")
                {
                    Turma oTurma = new Turma();
                    oTurma.CodigoCurso = (int)CboCurso.SelectedValue;
                    oTurma.Semestre = int.Parse(CboSemestre.Text);
                    oTurma.Ano = int.Parse(CboAno.Text);

                    TurmaAluno oTurmaAluno = new TurmaAluno();
                    oTurmaAluno.MatriculaAluno = TxtMatricula.Text;
                    oTurmaAluno.DataEntrada = DateTime.Now;

                    oTurma.TurmaAluno.Add(oTurmaAluno);

                    oTurma = Control.incluirTurma(oTurma);
                    TxtCodigoTurma.Text = oTurma.CodigoTurma.ToString();

                }
                CarregaGrid();
            }
        }

        private void TxtCodigoTurma_Leave(object sender, EventArgs e)
        {
            if (TxtCodigoTurma.Text.Trim() == "")
            {
                TxtCodigoTurma.Enabled = true;
            }
            else
            {
                Turma oTurma = Control.SelecionarTurma(int.Parse(TxtCodigoTurma.Text));
                if (oTurma == null)
                {

                }
                else
                {
                    CboCurso.SelectedValue = oTurma.CodigoCurso;
                    CboSemestre.Text = oTurma.Semestre.ToString();
                    CboAno.Text = oTurma.Ano.ToString();

                    try
                    {
                        TurmaAluno oTurmaAluno = new TurmaAluno();
                        oTurmaAluno.MatriculaAluno = TxtMatricula.Text;
                        oTurmaAluno.CodigoTurma = (int.Parse(TxtCodigoTurma.Text));
                        oTurmaAluno.DataEntrada = DateTime.Now;
                        Control.IncluirAlunoTurma(oTurmaAluno);
                        TxtMatricula.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(MyGlobal.MontaMensagemErro(ex), ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            CarregaGrid();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtCodigoTurma.Text = "";
            TxtCodigoTurma.Focus();
            CboSemestre.SelectedIndex = -1;
            CboAno.SelectedIndex = -1;
            CboCurso.SelectedIndex = -1;
            TxtMatricula.Text = "";
            CarregaGrid();
        }

        private void GridItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GridItens.Columns[e.RowIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Se excluir, será impossível recuperar. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        VwTurmaAluno ovwTurmaAluno = (VwTurmaAluno)GridItens.Rows[e.RowIndex].DataBoundItem;

                        TurmaAluno oTurmaAluno = new TurmaAluno();
                        oTurmaAluno.CodigoTurma = ovwTurmaAluno.CodigoTurma;
                        oTurmaAluno.MatriculaAluno = ovwTurmaAluno.MatriculaAluno;
                        Control.RemoverTurmaAluno(oTurmaAluno);
                        CarregaGrid();
                    }
                }
            }
        }
    }
}

