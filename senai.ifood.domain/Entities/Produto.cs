using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace senai.ifood.domain.Entities
{
    public class Produto : BaseDomain
    {
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        public Restaurante Restaurante { get; set; }
        public int RestauranteId { get; set; }
    }
}