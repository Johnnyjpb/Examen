﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactBook.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BookContactDatabaseEntities : DbContext
    {
        public BookContactDatabaseEntities()
            : base("name=BookContactDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CONTACTS> CONTACTS { get; set; }
        public virtual DbSet<MARITALSTATUS> MARITALSTATUS { get; set; }
        public virtual DbSet<SEXUALITY> SEXUALITY { get; set; }
        public virtual DbSet<TYPECONTACT> TYPECONTACT { get; set; }
    
        public virtual ObjectResult<getContacts_Result> getContacts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getContacts_Result>("getContacts");
        }
    }
}
