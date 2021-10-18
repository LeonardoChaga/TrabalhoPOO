using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoRicardo
{
    class Item
    {
        public Item(string id, Venda idVenda)
        {
            Id = id;
            IdVenda = idVenda;
        }
        public Venda IdVenda { get; set; }
        public string Id { get; set; }
    }
}
