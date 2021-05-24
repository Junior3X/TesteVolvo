using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Volvo.CadastrarModeloVeiculo.Anotations;

namespace Volvo.CadastrarModeloVeiculo.ViewModel.ModeloVeiculo
{
    public class ModeloVeiculoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "O modelo é obrigatório")]
        [MaxLength(15, ErrorMessage = "O nome do modelo poderá ter no máximo 15 caracteres")]
        [ValidarModelo(ErrorMessage = "Somente os modelos FM e FH podem ser cadastrados")]
        public string Modelo { get; set; }

        [Display(Name = "Ano Fabricação")]
        [MaxLength(4, ErrorMessage = "O ano de fabricação poderá ter no máximo 4 caracteres")]
        [ValidarAnoAtual(ErrorMessage = "Este campo só aceita o ano atual")]
        public string AnoFabricacao { get; set; }

        [Display(Name = "Ano Modelo")]
        [Required(ErrorMessage = "O ano do modelo é obrigatório")]
        [MaxLength(4, ErrorMessage = "O ano do modelo poderá ter no máximo 4 caracteres")]
        [ValidarAno(ErrorMessage = "Só é possivel cadastrar o ano atual ou anterior")]
        public string AnoModelo { get; set; }
    }
}