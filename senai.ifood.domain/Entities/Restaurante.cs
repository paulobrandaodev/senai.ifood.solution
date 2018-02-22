using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class Restaurante : BaseDomain
    {
       [Required]
       [StringLength(100)]
       public string Nome { get; set; }
       [StringLength(100)]
       public string Responsaval { get; set; }
       [StringLength(300)]
       public string Site { get; set; }
       [StringLength(20)]
       public string Telefone { get; set; }
       [StringLength(100)]
       public string Email { get; set; }

       [ForeignKey("EspecialidadeId")] 
       public Especialidade Especialidade { get; set; }
       public int EspecialidadeId { get; set; }

       [ForeignKey("UsuarioId")] 
       public Usuario Usuario { get; set; }
       public int UsuarioId { get; set; }

       public ICollection<Produto> ProdutosRestaurante { get; set; }

    }
}