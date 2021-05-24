using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo.CadastrarModeloVeiculo.Dominio;
using Volvo.CadastrarModeloVeiculo.AcessoDados.Entity.TypeConfiguration;

namespace Volvo.CadastrarModeloVeiculo.AcessoDados.Entity.Context
{
    public class VolvoDbContext : DbContext
    {
        public DbSet<ModeloVeiculo> Albuns { get; set; }

        public VolvoDbContext():base("VolvoDbContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<VolvoDbContext, Vovlo.CadastrarModeloVeiculo.AcessoDados.Entity.Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ModeloVeiculoTypeConfiguration());
        }

    }
}
