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
    
    public partial class ACAD_MODULOS
    {
        public ACAD_MODULOS()
        {
            this.ACAD_BLOCOS = new HashSet<ACAD_BLOCOS>();
            this.ACAD_QUESTOES = new HashSet<ACAD_QUESTOES>();
            this.ACAD_RECURSOS = new HashSet<ACAD_RECURSOS>();
        }
    
        public long CD_MODULO { get; set; }
        public long CD_CURSO { get; set; }
        public string NM_MODULO { get; set; }
        public string NM_PAGE { get; set; }
        public int NR_ORDEM { get; set; }
    
        public virtual ICollection<ACAD_BLOCOS> ACAD_BLOCOS { get; set; }
        public virtual ACAD_CURSOS ACAD_CURSOS { get; set; }
        public virtual ICollection<ACAD_QUESTOES> ACAD_QUESTOES { get; set; }
        public virtual ICollection<ACAD_RECURSOS> ACAD_RECURSOS { get; set; }
    }
}