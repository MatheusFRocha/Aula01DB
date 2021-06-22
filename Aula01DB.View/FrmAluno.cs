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
    public partial class FrmAluno : Form
    {

        private CAluno Control = new CAluno();
        private bool Incluir = false;

        public FrmAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtMatricula_Leave(object sender, EventArgs e)
        {
            if(TxtMatricula.Text.Trim()!="")
            {
                Aluno oAluno = Control.SelecionarAluno(TxtMatricula.Text);
                BtnSalvar.Enabled = true;
                if (oAluno == null)
                {
                    Incluir = true;
                    
                    BtnExcluir.Enabled = false; 
                }
                else
                {
                    Incluir = false;
                    BtnExcluir.Enabled = true;
                    TxtNome.Text = oAluno.Nome;
                    TxtNome.Focus();
                }
            }
            else
            {
                BtnSalvar.Enabled = false;
                BtnExcluir.Enabled = false;
            }
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtMatricula.Text = "";
            TxtNome.Text = "";
            BtnExcluir.Enabled = false;
            BtnSalvar.Enabled = false;
            TxtMatricula.Enabled = true;
            TxtMatricula.Focus();
        }
    }
}
