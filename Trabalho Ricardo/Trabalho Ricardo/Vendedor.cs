using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoRicardo
{
    class Vendedor
    {
        public Vendedor(int matricula, string nome, string cpf, string telefone, string endereco, float salario)
        {
            Matricula = matricula;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
            Salario = salario;
        }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public float Salario { get; set; }

        public override string ToString()
        {
            return "Matrícula: " + Matricula + "\nNome: " + Nome + "\nCpf: " + Cpf + "\nTelefone: " + Telefone + "\nEndereço: " + Endereco;
        }



    }
}