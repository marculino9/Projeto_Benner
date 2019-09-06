using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Licenca : EntityBase
    {
        [Required(ErrorMessage ="A chave do software é obrigatória")] //Chave do Software
        public string Chave { get; set; }
        [Required(ErrorMessage ="Quantidade obrigatória")]
        [RegularExpression(@"0*[1-9][0-9]*", ErrorMessage ="A quantidade deve ser maior que ZERO")]//Quantidade de Software
        public int Quantidade { get; set; }
         //Software
        public virtual Software Software { get; set; }
        //[Required(ErrorMessage = "Software requerido")]
        public int SoftwareId { get; set; }
    }
}