using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoRicardo
{
    class EntregaPropria : ISetorEntrega
    {
        public void DespacharProdutos(Venda venda)
        {
            Console.WriteLine("Produto Despachado.");
        }
    }
}
