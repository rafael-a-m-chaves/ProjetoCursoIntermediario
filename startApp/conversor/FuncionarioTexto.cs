using Biblioteca.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startApp.conversor
{
    class FuncionarioTexto
    {
        public static string ConverterParaTexto(Funcionario funcionario)
        {
            string texto = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12};",
                funcionario.Nome,
                funcionario.DataNascimento,
                funcionario.Telefone,
                funcionario.Bairro,
                funcionario.Cidade,
                funcionario.Estado,
                funcionario.Endereco,
                funcionario.Cep,
                funcionario.Cpf,
                funcionario.Rg,
                funcionario.Cargo,
                funcionario.Salario,
                funcionario.DataContratado);


            return texto;
        }

        public static void ConverterTextoFuncionario(string texto)
        {
            var listaFuncionario = texto.Split(';');

            foreach (var item in listaFuncionario)
            {
                Console.WriteLine(item);
            }
        }
    }
}
