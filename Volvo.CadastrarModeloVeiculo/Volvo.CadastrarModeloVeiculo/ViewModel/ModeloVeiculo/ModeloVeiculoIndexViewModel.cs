using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Volvo.CadastrarModeloVeiculo.ViewModel.ModeloVeiculo
{
    public class ModeloVeiculoIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Ano Fabricação")]
        public string AnoFabricacao { get; set; }

        [Display(Name = "Ano Modelo")]
        public string AnoModelo { get; set; }
    }
}