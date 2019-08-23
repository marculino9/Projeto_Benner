using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models.Enum
{
    public enum Status
    {
        [Display(Name = "Aguardando aprovação do gestor")]
        AguardandoAprovacaodoGestor = 0,
        [Display(Name = "Aguardando liberação")]
        AguardandoLiberacao = 1,
        [Display(Name = "Negado")]
        Negado = 2,
        [Display(Name = "Aprovado")]
        Aprovado = 3
    }
}