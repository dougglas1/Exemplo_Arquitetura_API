using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        
        // Categoria
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
