//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Entities.Relacional
{
    using Domain.Core;
    using System;
    using System.Collections.Generic;
    
    public partial class Banner : BaseEntity
    {
        public int Id { get; set; }
        public int IdAcademia { get; set; }
        public string Caption { get; set; }
        public string Caption2 { get; set; }
        public System.DateTime DataInicio { get; set; }
        public Nullable<System.DateTime> DataFinal { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }
    
        public virtual Academia Academia { get; set; }
    }
}