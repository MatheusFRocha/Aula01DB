using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01DB.Model;
using System.Linq;
using System.Runtime.InteropServices;

namespace Aula01DB.Model.Repositories
{
    public class RepositoryAluno : IDisposable
    {
        private bool disposedValue;

        private FaculdadeContext odb;
        private bool recebeucontexto = false;

        public RepositoryAluno(FaculdadeContext _odb)
        {
            odb = _odb;
            recebeucontexto = true;
        }



        public RepositoryAluno()
        {
            odb = new FaculdadeContext();
        }

        public DateTime DataHora()
        {
            return (from p in odb.VwPegahora select p).FirstOrDefault().Datahora;
        }


        public void IncluirAluno(Aluno oAluno)
        {
            odb.Aluno.Add(oAluno);
            odb.SaveChanges();
        }

        public Aluno Selecionar(string Matricula)
        {
            return (from p in odb.Aluno where p.Matricula == Matricula select p).FirstOrDefault();
        }
        public List<Aluno> SelecionarTodos()
        {
            return (from p in odb.Aluno select p).ToList();
        }

        public List<Aluno> SelecionarParteNome(string ParteNome)
        {
            return (from p in odb.Aluno where p.Nome.Contains(ParteNome) select p).ToList();
        }
        public List<Aluno> SelecionarInciadoPor(string InicioNome)
        {
            return (from p in odb.Aluno where p.Nome.StartsWith(InicioNome) select p).ToList();
        }




        public void Excluir(Aluno oAluno, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oAluno);
            }



            odb.Entry(oAluno).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            odb.SaveChanges();
        

        odb.Aluno.Add(oAluno);
            odb.SaveChanges();
        }





        public void AlterarAluno(Aluno oAluno, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oAluno);
            }



            odb.Entry(oAluno).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    if(!recebeucontexto) odb.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RepositoryAluno()
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
