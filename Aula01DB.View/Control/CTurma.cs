    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01DB.Model.Repositories;
using Aula01DB.Model;


namespace Aula01DB.View.Control
{
    public class CTurma : IDisposable
    {
        private bool disposedValue;

        private RepositoryCurso _RepositoryCurso;
        private RepositoryAluno _RepositoryAluno;
        private RepositoryTurma _RepositoryTurma;

        public CTurma()
        {
            _RepositoryCurso = new RepositoryCurso();

            _RepositoryAluno = new RepositoryAluno(_RepositoryCurso.Mycontext);
             _RepositoryTurma = new RepositoryTurma(_RepositoryCurso.Mycontext);
        }

        public Turma incluirTurma(Turma oTurma)
        {
            return _RepositoryTurma.IncluirTurma(oTurma);
        }

        public void RemoverTurmaAluno(TurmaAluno oTurmaAluno)
        {
            _RepositoryTurma.RemoverAlunoTurma(oTurmaAluno);
        }

        public Turma SelecionarTurma(int CodigoTurma)
        {
           return _RepositoryTurma.Selecionar(CodigoTurma);
        }

        public List<Curso> SelecionarTodosCursos()
        {
          return  _RepositoryCurso.SelecionarTodos();
        }

        public void IncluirAlunoTurma(TurmaAluno oTurmaAluno)
        {
            _RepositoryTurma.IncluirAlunoTurma(oTurmaAluno);
        }

            public List<Aluno> SelecionarTodosAlunos()
        {
            return _RepositoryAluno.SelecionarTodos();
        }

        public List<VwTurmaAluno> SelecionarAlunosTurma(int CodigoTurma)
        {
            return _RepositoryTurma.SelecionarAlunosTurma(CodigoTurma);
        }



        public DateTime DataHora()
        {
            return _RepositoryCurso.DataHora();
        }





        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _RepositoryCurso.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true; 
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~CTurma()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
