using Biblioteca.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startApp.conversor
{
    class ClienteTexto
    {
        public static string ConverterParaTexto (Cliente cliente)
        {
            string texto = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9};", 
                cliente.Nome,
                cliente.DataNascimento,
                cliente.Telefone,
                cliente.Bairro,
                cliente.Cidade,
                cliente.Estado,
                cliente.Endereco,
                cliente.Cep,
                cliente.Cpf,
                cliente.Rg);


            return texto;
        }

        public static void ConverterTextoCliente(string texto)
        {
            var listaClientes = texto.Split(';');
            
            foreach (var item in listaClientes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
