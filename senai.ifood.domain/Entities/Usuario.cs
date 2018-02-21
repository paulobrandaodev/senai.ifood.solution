using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace senai.ifood.domain.Entities
{
    public class Usuario : BaseDomain
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public ICollection<UsuarioPermissao> UsuarioPermissoes {get; set;}
        public ICollection<Restaurante> Restaurantes { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}