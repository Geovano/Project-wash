using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WashApplication.Models;

namespace WashApplication.Context
{
    public class AcessoContext : DbContext
    {
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Servico> servico { get; set; }
        public DbSet<Cupons> cupons { get; set; }
        public DbSet<Lavagem> lavagem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
        }
    }
}