using BarracaDoPedro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarracaDoPedro.Repository
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
    }
}
