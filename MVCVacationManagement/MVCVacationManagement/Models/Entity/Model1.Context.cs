﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCVacationManagement.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMvcVacationManagementEntities3 : DbContext
    {
        public DbMvcVacationManagementEntities3()
            : base("name=DbMvcVacationManagementEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
        public virtual DbSet<TBLHOTEL> TBLHOTEL { get; set; }
        public virtual DbSet<TBLHOTELREZERVASYON> TBLHOTELREZERVASYON { get; set; }
        public virtual DbSet<TBLHOTELYETKILISI> TBLHOTELYETKILISI { get; set; }
        public virtual DbSet<TBLMUSTERI> TBLMUSTERI { get; set; }
        public virtual DbSet<TBLTUR> TBLTUR { get; set; }
        public virtual DbSet<TBLTURREZERVASYON> TBLTURREZERVASYON { get; set; }
        public virtual DbSet<TBLTURYETKILISI> TBLTURYETKILISI { get; set; }
    }
}
