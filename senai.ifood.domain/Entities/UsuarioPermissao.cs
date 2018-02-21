using System;
using System.ComponentModel.DataAnnotations;
namespace senai.ifood.domain.Entities
{
    public class UsuarioPermissao
    {
        public Usuario Usuario { get; set; }
        public int UsuarioID { get; set; }

        public Permissao Permissao { get; set; }
        public int PermissaoId { get; set; }
    }
}