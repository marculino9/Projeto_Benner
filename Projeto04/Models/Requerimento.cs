using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Requerimento : EntityBase
    {
        [Required]
        public string NomeRequerimento { get; set; }

    }
}