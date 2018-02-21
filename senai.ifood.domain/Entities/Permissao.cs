using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace senai.ifood.domain.Entities
{
    public class Permissao : BaseDomain
    {
        public string Nome { get; set; }

        public ICollection<UsuarioPermissao> UsuarioPermissoes {get; set;}
    }
}