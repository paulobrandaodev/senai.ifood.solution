using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class Cliente : BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DataNascimento { get; set; }
        [StringLength(100)]
        public string Sexo { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}