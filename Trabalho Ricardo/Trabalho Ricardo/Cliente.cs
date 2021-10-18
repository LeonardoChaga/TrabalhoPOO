using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace TrabalhoRicardo
{
    [Serializable]

    class Cliente
    {
        public Cliente(int id, string nome, string endereco, string telefone, string cpf)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cpf = cpf;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

    }
}
