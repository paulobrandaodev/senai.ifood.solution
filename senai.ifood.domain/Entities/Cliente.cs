using System;
using System.ComponentModel.DataAnnotations;
namespace senai.ifood.domain.Entities
{
    public class Cliente : BaseDomain
    {
        [Required]
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }

        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}