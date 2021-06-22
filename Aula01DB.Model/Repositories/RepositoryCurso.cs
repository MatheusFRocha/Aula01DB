using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01DB.Model;

using System.Runtime.InteropServices;

namespace Aula01DB.Model.Repositories 

{ 

    public class RepositoryCurso : IDisposable
    {
        private bool disposedValue;

        private FaculdadeContext odb;


        public FaculdadeContext Mycontext
        { 
         get
            {return odb;}

          }

        public RepositoryCurso()
        {
            odb = new FaculdadeContext();
        }

        public DateTime DataHora()
        {
            return (from p in odb.VwPegahora select p).FirstOrDefault().Datahora;
        }

        public void IncluirCurso(Curso oCurso)
        {
            odb.Curso.Add(oCurso);
            odb.SaveChanges();
        }

        public Curso Selecionar(int CodigoCurso)
        {
            return (from p in odb.Curso where p.CodigoCurso == CodigoCurso select p).FirstOrDefault();
        }

        public List<Curso> SelecionarTodos()
        {
            return (from p in odb.Curso select p).ToList();
        }

        public List<Curso> SelecionarParteNome(string ParteNome)
        {
            return (from p in odb.Curso where p.Nome.Contains(ParteNome) select p).ToList();
        }
        public List<Curso> SelecionarInciadoPor(string InicioNome)
        {
            return (from p in odb.Curso where p.Nome.StartsWith(InicioNome) select p).ToList();
        }




        public void Excluir(Curso oCurso, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oCurso);
            }



            odb.Entry(oCurso).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
             odb.SaveChanges();
        

        odb.Curso.Add(oCurso);
            odb.SaveChanges();
        }





        public void AlterarCurso(Curso oCurso, bool attach = false)
        {
            if (attach)
            {
                odb.Attach(oCurso);
            }



            odb.Entry(oCurso).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    odb.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RepositoryCurso()
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
