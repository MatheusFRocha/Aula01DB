﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Aula01DB.Model
{
    public partial class Curso
    {
        public Curso()
        {
            Turma = new HashSet<Turma>();
        }

        public int CodigoCurso { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Turma> Turma { get; set; }
    }
}