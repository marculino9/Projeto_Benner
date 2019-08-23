using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models.Enum
{
    public enum TipoPerfil
    {     
        [Display(Name="Administrador")]
        Administrador = 0,
        [Display(Name = "Gestor")]
        Gestor = 1,
        [Display(Name = "Funcionário")]
        Funcionario = 2
    }
}