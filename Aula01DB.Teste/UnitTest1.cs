using NUnit.Framework;
using Aula01DB.Model;
using Aula01DB.Model.Repositories;
using System.Linq;
using System.IO;

namespace Aula01DB.Teste
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IncluiAlunorepository()
        {

            RepositoryAluno repository = new RepositoryAluno();
            Aluno oAluno = new Aluno();
            oAluno.Matricula = "202021";
            oAluno.Nome = "Teste de Alteração";
            repository.IncluirAluno(oAluno);
            oAluno.Nome = "Gabriel Teste"; 
            repository.AlterarAluno(oAluno);

            repository.Dispose();



            //FaculdadeContext odb = new FaculdadeContext();
            //Aluno oAluno = new Aluno();
            //oAluno.Matricula = "19157039";
            //oAluno.Nome = "Gustavo Serra Monteiro";
            //odb.Aluno.Add(oAluno);
            //odb.SaveChanges();

            //odb.Dispose(); //Libera o contexto da mémoria
            //Assert.Pass();
        }
        //[Test]
        //public void AlterarAluno()
        //{
        //    FaculdadeContext odb = new FaculdadeContext();
        //    Aluno oAluno = (from p in odb.Aluno where p.Matricula == "19157039" select p).FirstOrDefault();
        //    oAluno.Nome = "Teste de Gustavo";
        //    odb.SaveChanges();
        //    odb.Dispose();
        //    Assert.Pass();
        //}

        //[Test]
        //public void ExcluirAluno()
        //{
        //    FaculdadeContext odb = new FaculdadeContext();
        //    Aluno oAluno = (from p in odb.Aluno where p.Matricula == "19157039" select p).FirstOrDefault();

        //    odb.Aluno.Remove(oAluno);
        //    odb.SaveChanges();
        //    odb.Dispose();
        //    Assert.Pass();

        //}
      
        }
    }
