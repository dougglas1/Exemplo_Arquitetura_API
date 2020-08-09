using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public IList<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
