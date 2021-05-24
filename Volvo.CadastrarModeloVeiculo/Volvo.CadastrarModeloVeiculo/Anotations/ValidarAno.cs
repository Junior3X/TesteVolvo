using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Volvo.CadastrarModeloVeiculo.Anotations
{
    public class ValidarAno : ValidationAttribute
    {
        public ValidarAno()
        {

        }

        public override bool IsValid(object value)
        {
            var data = DateTime.Now.Year.ToString();
            var data2 = DateTime.Now.AddYears(-1).Year.ToString();

            if(data == value.ToString() || data2 == value.ToString())
            {
                return true;
            }

            return false;
        }
    }
}