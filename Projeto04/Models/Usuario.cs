using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class Usuario : EntityBase
    {
        [Required] //Login do funcionario
        public string Login { get; set; }

        [StringLength(20)]
        [DataType(DataType.Password)]
        [Required]
        public string Senha { get; set; }
        [Required]
        public virtual Funcionario Funcionario { get; set; }
        [Required]
        public int FuncionarioId { get; set; }
        [NotMapped]
        public int CodigoVerificacao { get; set; }
        [Required]
        public virtual IList<SolicitacaoLicenca> SolicitacaoLicencas { get; set; }
        public virtual IList<Licenca> Licencas { get; set; }

        [NotMapped]
        public int Adm { get; set; }

        [NotMapped]
        public int Ges { get; set; }

        [NotMapped]
        public int Func { get; set; }
    }
}