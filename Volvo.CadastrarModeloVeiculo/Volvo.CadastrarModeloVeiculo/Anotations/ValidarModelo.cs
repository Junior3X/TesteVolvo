using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Volvo.CadastrarModeloVeiculo.Anotations
{
    public class ValidarModelo : ValidationAttribute
    {
        public ValidarModelo()
        {

        }

        public override bool IsValid(object value)
        {
            if (value.ToString().ToUpper().StartsWith("FH") || value.ToString().ToUpper().StartsWith("FM"))
            {
                return true;
            }

            return false;
        }
    }
}