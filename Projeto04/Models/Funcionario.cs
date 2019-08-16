using Projeto02.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Funcionario : EntityBase
    {
        [Required] //Nome do funcionario
        public string Nome { get; set; }
        [Required] //Equipe
        public virtual Equipe Equipe { get; set; }
        [Required]
        public int EquipeId { get; set; }
        [Required] //Cargo
        public virtual Cargo Cargo { get; set; }
        [Required]
        public int CargoId { get; set; }
        [Required] //Nome do computador do funcionario
        public string Maquina { get; set; }
        [Required]
        public int CodigoVerificacao { get; set; } //AQUI
        [Required]
        public virtual IList<Usuario> Usuarios { get; set; } 

        public TipoPerfil TipoPerfil { get; set; }
    }
}