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
    
    public partial class ACAD_USUARIOS_PROVAS_QUESTOES
    {
        public long CD_PROVA { get; set; }
        public long CD_USUARIO { get; set; }
        public long CD_MATRICULA { get; set; }
        public long CD_QUESTAO { get; set; }
        public System.DateTime DT_INICIO { get; set; }
        public string TX_PERGUNTA { get; set; }
        public string TX_RESPOSTA { get; set; }
        public bool FL_ACERTO { get; set; }
        public string TX_OBS_CORRECAO { get; set; }
        public string TX_GABARITO { get; set; }
    
        public virtual ACAD_MATRICULAS ACAD_MATRICULAS { get; set; }
        public virtual ACAD_QUESTOES ACAD_QUESTOES { get; set; }
        public virtual ACAD_USUARIOS ACAD_USUARIOS { get; set; }
    }
}
