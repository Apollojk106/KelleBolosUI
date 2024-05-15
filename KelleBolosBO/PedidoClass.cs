using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KelleBolosBO
{
    public class PedidoClass
    {
        public void ArmazenarPedido(string Item,string Quantidade) 
        {
            string pedido = Item + '|' + $"{Quantidade}";

            ArquivosTXTClass Arquivo = new ArquivosTXTClass();
            Arquivo.Pedido(pedido);
        }

        public string RetornarInfoParaPedido() 
        {
            ArquivosTXTClass Arquivo = new ArquivosTXTClass();
            string Usuario = Arquivo.ler("Usuario");
            if (Usuario == "") 
            {
                return "Nenhun Arquivo encontrado | Paia";    
            }

            BancoDeDadosClass banco = new BancoDeDadosClass();
            string Nome = banco.LerInfo(Usuario, "Nome");
            string Telefone = banco.LerInfo(Usuario, "Telefone");

            string informações = Nome + '|' + Telefone;
            return informações;
        
        }

        public bool RealizarPedidoEntregar(
            string Nome, 
            string Telefone, 
            string Item, 
            string quantidade, 
            string usuario, 
            string cep, 
            string rua, 
            string bairro, 
            string numero, 
            string complemento,
            string situacao) 
        {
            

            return false;
        }

        public bool RealizarPedidoBuscar(
            string Nome, 
            string Telefone, 
            string Item, 
            string quantidade, 
            string usuario) 
        {
            if (ContemApenasNumeros(Telefone))
            {
                return false;
            }
            else 
            {
                


            }
            
            return false;


        }

        public bool VerificarCep(string cep) 
        {
            try
            {
                string link = $"https://viacep.com.br/ws/{cep}/json/";

                using (WebClient web = new WebClient())
                {
                    string response = web.DownloadString(link);

                    if (!response.Contains("erro"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception) 
            {
                return false;
            }           
        }

        public bool ContemApenasNumeros(string texto)
        {
            foreach (char caractere in texto)
            {
                if (!char.IsDigit(caractere))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
