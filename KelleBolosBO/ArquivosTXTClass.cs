using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelleBolosBO
{
    public class ArquivosTXTClass
    {
        public string Caminho() 
        {
            string diretorioExecutavel = AppDomain.CurrentDomain.BaseDirectory;

            string caminhoSolucao = Path.GetFullPath(Path.Combine(diretorioExecutavel, @"..\..\"));

            return caminhoSolucao;

        }


        public void Criar(string NomeDoArquivo, string Conteudo)
        {
            string caminho = Caminho();

            string[] linhas = Conteudo.Split('|');

            string caminhoArquivo = caminho + $"{NomeDoArquivo}.txt";
            if (File.Exists(caminhoArquivo))
            {
                File.Delete(caminhoArquivo);
                Console.WriteLine("Arquivo criado");
            }



            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                foreach (string linha in linhas)
                {
                    writer.WriteLine(linha);
                }

            }
        }

        public void Pedido(string conteudo)
        {
            string caminho = Caminho();

            string caminhoArquivo = caminho + "Pedido.txt";

            if (File.Exists(caminhoArquivo))
            {
                File.Delete(caminhoArquivo);
            }

            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                writer.WriteLine(conteudo);
            }
        }

        public string lerVariasLinhas(string NomeDoArquivo)
        {
            string caminho = Caminho();

            string caminhoArquivo = caminho + $"{NomeDoArquivo}.txt";

            if (File.Exists(caminhoArquivo))
            {
                string leitura = "";

                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {

                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        leitura += linha + "|";
                    }
                }

                return leitura;
            }
            else
            {
                Console.WriteLine("O arquivo não existe.");
                return "erro";
            }
        }

        public string ler(string NomeDoArquivo)
        {
            string caminho = Caminho();

            string caminhoArquivo = caminho + $"{NomeDoArquivo}.txt";

            if (File.Exists(caminhoArquivo))
            {
                string leitura = "";

                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {

                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        leitura += linha;
                    }
                }

                return leitura;
            }
            else
            {
                Console.WriteLine("O arquivo não existe.");
                return "";
            }
        }
    }
}
