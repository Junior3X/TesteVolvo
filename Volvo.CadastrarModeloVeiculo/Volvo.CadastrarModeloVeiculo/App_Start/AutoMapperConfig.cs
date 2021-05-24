using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volvo.CadastrarModeloVeiculo.AutoMapper;

namespace Volvo.CadastrarModeloVeiculo.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configurar() 
        {
            Mapper.AddProfile<DominioParaViewModelProfile>();
            Mapper.AddProfile<ViewModelParaDominioProfile>();
        }
    }
}