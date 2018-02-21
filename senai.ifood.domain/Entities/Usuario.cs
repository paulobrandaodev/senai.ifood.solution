using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace senai.ifood.domain.Entities
{
    public class Usuario : BaseDomain
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }

        public ICollection<UsuarioPermissao> UsuarioPermissoes {get; set;}
        public ICollection<Restaurante> Restaurantes { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}