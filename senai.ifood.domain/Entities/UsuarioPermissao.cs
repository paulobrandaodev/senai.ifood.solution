using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class UsuarioPermissao
    {
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("PermissaoId")]
        public Permissao Permissao { get; set; }
        public int PermissaoId { get; set; }
    }
}