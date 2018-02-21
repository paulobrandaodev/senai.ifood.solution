using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace senai.ifood.domain.Entities
{
    public class Especialidade : BaseDomain
    {
        [Required]
        public string Nome { get; set; }

        public ICollection<Restaurante> Restaurantes {get; set;}
    }
}