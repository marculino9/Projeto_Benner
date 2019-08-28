using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Software : EntityBase
    {
        [Required(ErrorMessage ="Nome do software é obrigatório")] //Nome do Software
        public string NomeSoftware { get; set; }
        [Required(ErrorMessage ="Versão do software é orbigatória")] //Versao do Software
        public string Versao { get; set; }
    }
}
