using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02.Models
{
    public class SolicitacaoLicenca : EntityBase
    {
        [Required] //Referencia de Software
        public virtual Software Software { get; set; }
        [Required] //Id de Software
        public int SoftwareId { get; set; }
        [Required] //Data de inicial para usar a licenca
        public DateTime DataInicio { get; set; }
        [Required] //Data Final para usar a licenca
        public DateTime DataTermino { get; set; }
        [Required] //Fazer Numero
        public int Protocolo { get; set; }
        [Required] //Usuario
        public virtual Usuario Usuario { get; set; }
        [Required] // Id do Usuario
        public int UsuarioId { get; set; }
        //Motivo de uso
        public string MotivoDeUso { get; set; }
        [Required] 
        public virtual Status Status { get; set; }
        [Required]//Id do status
        public int StatusId { get; set; }
    }
}
