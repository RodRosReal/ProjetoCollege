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
    
    public partial class ACAD_QUESTOES
    {
        public ACAD_QUESTOES()
        {
            this.ACAD_USUARIOS_PROVAS_QUESTOES = new HashSet<ACAD_USUARIOS_PROVAS_QUESTOES>();
        }
    
        public long CD_QUESTAO { get; set; }
        public long CD_MODULO { get; set; }
        public string TX_PERGUNTA { get; set; }
        public string TX_GABARITO { get; set; }
    
        public virtual ACAD_MODULOS ACAD_MODULOS { get; set; }
        public virtual ICollection<ACAD_USUARIOS_PROVAS_QUESTOES> ACAD_USUARIOS_PROVAS_QUESTOES { get; set; }
    }
}
