using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class Permissao : BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public ICollection<UsuarioPermissao> UsuarioPermissoes {get; set;}
    }
}