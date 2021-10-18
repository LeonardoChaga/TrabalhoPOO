using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabalhoRicardo
{

    class Estoque
    {
        public Estoque(int id, string nomeEstoque, string endereco)
        {
            Id = id;
            Endereco = endereco;
            NomeEstoque = nomeEstoque;
            _produtos = new Dictionary<int, int>();
        }

        public int Id { get; set; }
        public string Endereco { get; set; }
        public string NomeEstoque { get; set; }

        private Dictionary<int, int> _produtos;
        public bool estaDisponivel(Produto produtos)
        {
            int qtd = _produtos[produtos.Id];

            if (qtd > 0)
                return true;
            else
                return false;
        }

        public int qtdDisponivel(Produto produtos)
        {
            int qtdDisponivel = _produtos[produtos.Id];

            if (qtdDisponivel > 0)
                return qtdDisponivel;
            else
                return 0;
        }

        public void CadastrarProduto(Produto produtos, int qtdInicial)
        {
            _produtos.Add(produtos.Id, qtdInicial);
        }
        public void baixaProduto(Produto produtos)
        {
            _produtos[produtos.Id] -- ;
        }
    }
}
