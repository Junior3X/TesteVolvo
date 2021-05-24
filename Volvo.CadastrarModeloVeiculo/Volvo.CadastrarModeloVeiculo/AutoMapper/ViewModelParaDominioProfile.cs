using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volvo.CadastrarModeloVeiculo.Dominio;
using Volvo.CadastrarModeloVeiculo.ViewModel.ModeloVeiculo;

namespace Volvo.CadastrarModeloVeiculo.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ModeloVeiculoViewModel, ModeloVeiculo>();
        }
    }
}