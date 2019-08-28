using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Cargo : EntityBase
    {
        [Required(ErrorMessage ="O nome do cargo é obrigatório")] //Nome dos Cargos
        public string NomeCargo { get; set; }

        public virtual IList<Funcionario> Funcionarios { get; set; }
    }
}