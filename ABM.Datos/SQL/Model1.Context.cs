﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ABMEntities : DbContext
    {
        public ABMEntities()
            : base("name=ABMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NUB_LISTA_PRODUCTOS> NUB_LISTA_PRODUCTOS { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBL_COMPRA> TBL_COMPRA { get; set; }
        public virtual DbSet<TBL_LISTA_COMPRA> TBL_LISTA_COMPRA { get; set; }
        public virtual DbSet<TBL_ORDEN_STOCK> TBL_ORDEN_STOCK { get; set; }
        public virtual DbSet<TBL_PRODUCTO> TBL_PRODUCTO { get; set; }
        public virtual DbSet<TBL_RECEPCION> TBL_RECEPCION { get; set; }
        public virtual DbSet<TBL_ROL> TBL_ROL { get; set; }
        public virtual DbSet<TBL_STOCK> TBL_STOCK { get; set; }
        public virtual DbSet<TBL_TIPO_PRODUCTO> TBL_TIPO_PRODUCTO { get; set; }
        public virtual DbSet<TBL_TIPO_STOCK> TBL_TIPO_STOCK { get; set; }
        public virtual DbSet<TBL_USUARIO> TBL_USUARIO { get; set; }
    }
}
