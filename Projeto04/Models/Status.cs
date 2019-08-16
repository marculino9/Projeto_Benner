using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Status : EntityBase
    {
        [Required]
        public string NomeStatus { get; set; }
    }
}