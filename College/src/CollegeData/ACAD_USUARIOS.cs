//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollegeData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACAD_USUARIOS
    {
        public ACAD_USUARIOS()
        {
            this.ACAD_CURSOS = new HashSet<ACAD_CURSOS>();
            this.ACAD_MATRICULAS = new HashSet<ACAD_MATRICULAS>();
            this.ACAD_USUARIOS_BLOCOS = new HashSet<ACAD_USUARIOS_BLOCOS>();
            this.ACAD_USUARIOS_EXERCICIOS = new HashSet<ACAD_USUARIOS_EXERCICIOS>();
            this.ACAD_USUARIOS_PROVAS_QUESTOES = new HashSet<ACAD_USUARIOS_PROVAS_QUESTOES>();
        }
    
        public long CD_USUARIO { get; set; }
        public long CD_ACADEMIA { get; set; }
        public string NM_USUARIO { get; set; }
        public string NM_SOBRENOME { get; set; }
        public string NM_COMPLETO { get; set; }
        public string TX_EMAIL { get; set; }
        public string TX_TELEFONE { get; set; }
        public string TX_CELULAR { get; set; }
        public string TX_CPF { get; set; }
        public string TX_SENHA { get; set; }
        public string TX_IP { get; set; }
        public System.DateTime DT_DATA { get; set; }
        public bool FL_ATIVO { get; set; }
    
        public virtual ACAD_ACADEMIAS ACAD_ACADEMIAS { get; set; }
        public virtual ICollection<ACAD_CURSOS> ACAD_CURSOS { get; set; }
        public virtual ICollection<ACAD_MATRICULAS> ACAD_MATRICULAS { get; set; }
        public virtual ICollection<ACAD_USUARIOS_BLOCOS> ACAD_USUARIOS_BLOCOS { get; set; }
        public virtual ICollection<ACAD_USUARIOS_EXERCICIOS> ACAD_USUARIOS_EXERCICIOS { get; set; }
        public virtual ICollection<ACAD_USUARIOS_PROVAS_QUESTOES> ACAD_USUARIOS_PROVAS_QUESTOES { get; set; }
    }
}