using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo.CadastrarModeloVeiculo.AcessoDados.Entity.Context;
using Volvo.CadastrarModeloVeiculo.Dominio;
using Volvo.CadastrarModeloVeiculo.Repositorio.Entity;

namespace Volvo.CadastrarModeloVeiculo.comum
{
    public class ModeloVeiculoRepositorio : RepositorioGenericoEntity<ModeloVeiculo, int>
    {
        public ModeloVeiculoRepositorio(VolvoDbContext contexto)
            : base(contexto)
        {

        }

        public override List<ModeloVeiculo> Selecionar()
        {
            return _contexto.Set<ModeloVeiculo>().ToList();
        }

        public override ModeloVeiculo SelecionarPorId(int id)
        {
            return _contexto.Set<ModeloVeiculo>().SingleOrDefault(a => a.Id == id);
        }
    }
}
