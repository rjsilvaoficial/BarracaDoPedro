
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
    }
}
