using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoRicardo
{
    class EntregaTerceirizada : ISetorEntrega
    {
        public void DespacharProdutos(Venda venda)
        {
            Verificar();
            Enviar();
        }
        private void Verificar()
        {
            Console.WriteLine("Verificando Parceiro.");
        }
        private void Enviar()
        {
            Random rand = new Random();
            Console.WriteLine($"Produto chegara em {rand.Next(1, 20)} dias");
        }
    }
}
