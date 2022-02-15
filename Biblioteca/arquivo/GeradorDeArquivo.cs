using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Biblioteca.arquivo
{
    public class GeradorDeArquivo
    {
        public static void GravarArquivo(string arquivo, string texto)
        {
            string caminho = "C:\\" + arquivo + ".txt";

            if (File.Exists(caminho))
            {
                using (StreamWriter wr = File.AppendText(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
        }

        public static string LerArquivo(string arquivo)
        {
            string texto;
            string caminho = "C:\\" + arquivo + ".txt";
            if (File.Exists(caminho))
            {
                texto = File.ReadAllText(caminho);
            }
            else
            {
                texto = "Arquivo não encontrado";
            }
            return texto;
        }
    }
}
