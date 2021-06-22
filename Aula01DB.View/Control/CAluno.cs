using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01DB.Model;
using Aula01DB.Model.Repositories;

namespace Aula01DB.View.Control
{
    public class CAluno : IDisposable
    {
        private bool disposedValue;
        private RepositoryAluno Repository;

        public CAluno()
        {
            Repository = new RepositoryAluno();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Repository.Dispose();
                }


                disposedValue = true;
            }
        }
        public Aluno SelecionarAluno(string Matricula)
        {
            return Repository.Selecionar(Matricula);
        }
     

        public void Dispose()
        {
           
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
