using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo.CadastrarModeloVeiculo.Comum.Entity;
using Volvo.CadastrarModeloVeiculo.Dominio;

namespace Volvo.CadastrarModeloVeiculo.AcessoDados.Entity.TypeConfiguration
{
    class ModeloVeiculoTypeConfiguration : VolvoCadastrarModeloVeiculoEntityAbstractConfig<ModeloVeiculo>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ID");

            Property(p => p.Modelo)
                .IsRequired()
                .HasColumnName("MODELO")
                .HasMaxLength(15);

            Property(p => p.AnoFabricacao)
                .IsRequired()
                .HasColumnName("ANOFABRICACAO")
                .HasMaxLength(7);

            Property(p => p.AnoModelo)
                .IsOptional()
                .HasColumnName("ANOMODELO")
                .HasMaxLength(7);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            //throw new NotImplementedException();
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("MODELOVEICULO");
        }
    }
}
