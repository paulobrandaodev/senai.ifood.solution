using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class Produto : BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(500)]
        public string Descricao { get; set; }
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        [ForeignKey("RestauranteId")]
        public Restaurante Restaurante { get; set; }
        public int RestauranteId { get; set; }
    }
}