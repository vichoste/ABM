//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABM.Datos.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_COMPRA
    {
        public int com_id { get; set; }
        public int com_cantidad { get; set; }
        public int com_valor { get; set; }
        public Nullable<int> car_id { get; set; }
        public int lcom_id { get; set; }
        public Nullable<System.DateTime> com_fecha_compra { get; set; }
    
        public virtual TBL_CARRO_COMPRA TBL_CARRO_COMPRA { get; set; }
        public virtual TBL_LISTA_COMPRA TBL_LISTA_COMPRA { get; set; }
    }
}
