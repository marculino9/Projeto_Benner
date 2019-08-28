using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Software : EntityBase
    {
        [Required(ErrorMessage ="Nome do software � obrigat�rio")] //Nome do Software
        public string NomeSoftware { get; set; }
        [Required(ErrorMessage ="Vers�o do software � orbigat�ria")] //Versao do Software
        public string Versao { get; set; }
    }
}
