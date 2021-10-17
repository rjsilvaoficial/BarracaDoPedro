
using System.ComponentModel.DataAnnotations;

namespace BarracaDoPedro.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Descricao { get; set; }
        [StringLength(200)]
        public string Imagem { get; set; }
        public bool Estoque { get; set; }
        public decimal Valor { get; set; }
    }
}
