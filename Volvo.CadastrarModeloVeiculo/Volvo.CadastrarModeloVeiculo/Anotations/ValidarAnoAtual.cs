using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Volvo.CadastrarModeloVeiculo.Anotations
{
    public class ValidarAnoAtual : ValidationAttribute
    {
        public ValidarAnoAtual()
        {

        }

        public override bool IsValid(object value)
        {
            var data = DateTime.Now.Year.ToString();

            if (data == value.ToString())
            {
                return true;
            }

            return false;
        }
    }
}