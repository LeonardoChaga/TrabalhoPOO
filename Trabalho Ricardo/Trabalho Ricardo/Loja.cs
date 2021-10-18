using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoRicardo
{
    class Loja
    {
        public Loja(string id, string nomeFilial, int idEstoque)
        {
            Id = id;
            NomeFilial = nomeFilial;
            IdEstoque = idEstoque;
        }
        public string Id { get; set; }
        public string NomeFilial { get; set; }
        public int IdEstoque { get; set; }
    }
}
