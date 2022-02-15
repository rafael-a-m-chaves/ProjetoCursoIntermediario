using System;

namespace Biblioteca
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Endereco { get; set; }
        public int Cep { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }


    }
}
