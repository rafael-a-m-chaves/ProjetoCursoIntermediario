using System;
using startApp.telas;

namespace startApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while( opcao != 5)
            {
                Console.WriteLine("O que deseja Fazer? ");
                Console.WriteLine("1 - Cadastrar Cliente || 2 - Listar Clientes Cadastrados || 3 - Cadastrar Funcionarios || 4 - Listar Funcionarios || 5 - sair");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch
                {
                    opcao = 0;
                }
                

                switch (opcao)
                {
                    case 1:
                        ManterCliente manterCliente = new ManterCliente();
                        manterCliente.CadastrarCliente();
                        break;
                    case 2:
                        ManterCliente listarCliente = new ManterCliente();
                        listarCliente.ListarClientes();
                        break;
                    case 3:
                        ManterFuncionario cadastrarFuncionario = new ManterFuncionario();
                        cadastrarFuncionario.CadastrarFuncionario();
                        break;
                    case 4:
                        ManterFuncionario listarFuncionario = new ManterFuncionario();
                        listarFuncionario.ListarFuncionarios();
                        break;
                    default:
                        Console.WriteLine("Não foi possivel achar a opção selecionada");
                        break;
                }

            }
        }
        

    }
}
