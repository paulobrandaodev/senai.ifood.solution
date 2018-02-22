using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class Usuario : BaseDomain
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(250,MinimumLength=6)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public ICollection<UsuarioPermissao> UsuarioPermissoes {get; set;}
        public ICollection<Restaurante> Restaurantes { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}