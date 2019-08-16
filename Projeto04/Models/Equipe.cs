using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Equipe : EntityBase
    {
        [Required] //Nome das Equipes
        public string NomeEquipe { get; set; }
        //equipe tem funcionario (gestor)       
        public virtual Gestor Gestor { get; set; }
        public int? GestorId { get; set; }
        [Required]
        public virtual IList<Funcionario> Funcionarios { get; set; }
    }
}