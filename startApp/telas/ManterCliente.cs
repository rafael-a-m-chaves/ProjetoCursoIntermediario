using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.model;
using startApp.conversor;
using Biblioteca.arquivo;

namespace startApp.telas
{
    class ManterCliente
    {
        public void CadastrarCliente()
        {
            Console.Clear();
            Console.WriteLine("CADASTRAR CLIENTE");
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite o nome: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Digite a DataNascimento: ");
            cliente.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite o Telefone: ");
            cliente.Telefone = Console.ReadLine();
            Console.WriteLine("Digite o Bairro: ");
            cliente.Bairro =  Console.ReadLine();
            Console.WriteLine("Digite o Cidade: ");
            cliente.Cidade = Console.ReadLine();
            Console.WriteLine("Digite o Estado: ");
            cliente.Estado = Console.ReadLine();
            Console.WriteLine("Digite o Endereco: ");
            cliente.Endereco = Console.ReadLine();
            Console.WriteLine("Digite o Cep: ");
            cliente.Cep = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Cpf: ");
            cliente.Cpf = Console.ReadLine();
            Console.WriteLine("Digite o Rg: ");
            cliente.Rg = Console.ReadLine();

            GeradorDeArquivo.GravarArquivo("cliente",ClienteTexto.ConverterParaTexto(cliente));

            Console.WriteLine("Cadastro gerado com sucesso");
        }

        public void ListarClientes()
        {
            GeradorDeArquivo.LerArquivo("cliente");
        }
    }
}
