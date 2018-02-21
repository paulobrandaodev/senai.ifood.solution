using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace senai.ifood.domain.Entities
{
    public class Restaurante : BaseDomain
    {
       public string Nome { get; set; }
       public string Responsaval { get; set; }
       public string Site { get; set; }
       public string Telefone { get; set; }
       public string Email { get; set; }

       public Especialidade Especialidade { get; set; }
       public int EspecialidadeId { get; set; }

       public Usuario Usuario { get; set; }
       public int UsuarioId { get; set; }

       public ICollection<Produto> ProdutosRestaurante { get; set; }

    }
}