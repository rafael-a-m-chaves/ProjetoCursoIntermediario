using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.model;
using Biblioteca.arquivo;
using startApp.conversor;

namespace startApp.telas
{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {

            Console.Clear();
            Console.WriteLine("CADASTRAR FUNCIONARIO");
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite o nome: ");
            funcionario.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite a DataNascimento: ");
            funcionario.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Digite o Telefone: ");
            funcionario.Telefone = Console.ReadLine();
            
            Console.WriteLine("Digite o Bairro: ");
            funcionario.Bairro = Console.ReadLine();
            
            Console.WriteLine("Digite o Cidade: ");
            funcionario.Cidade = Console.ReadLine();
            
            Console.WriteLine("Digite o Estado: ");
            funcionario.Estado = Console.ReadLine();
            
            Console.WriteLine("Digite o Endereco: ");
            funcionario.Endereco = Console.ReadLine();
            
            Console.WriteLine("Digite o Cep: ");
            funcionario.Cep = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Cpf: ");
            funcionario.Cpf = Console.ReadLine();
            
            Console.WriteLine("Digite o Rg: ");
            funcionario.Rg = Console.ReadLine();

            Console.WriteLine("Digite o Cargo");
            funcionario.Cargo = Console.ReadLine();

            Console.WriteLine("Digite o Salario");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data de entrada do funcionario: ");
            funcionario.DataContratado = DateTime.Parse(Console.ReadLine());

            GeradorDeArquivo.GravarArquivo("funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));
            Console.WriteLine("Cadastro Realizado com sucesso");
        }

        public void ListarFuncionarios()
        {
            GeradorDeArquivo.LerArquivo("funcionario");
        }
    }
}
