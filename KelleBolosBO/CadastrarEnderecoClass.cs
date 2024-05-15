using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using MySqlX.XDevAPI;
using System.Security.Policy;

namespace KelleBolosBO
{
    public class CadastrarEnderecoClass
    {
        private string cep { get; set; }

        private bool ExisteCep;

        public async Task<string> Validar(string Cep, string Bairro,string Rua, string Numero, string Complemento, string usuario) 
        {
            Cep.Replace("-", "");

            await VerificarCep(Cep);

            if (StringNulo(Cep)||
                StringNulo(Bairro)||
                StringNulo(Rua)||
                StringNulo(Numero)) 
            {
                return "Campos vazios!";
            }
            if (!ContemApenasNumeros(Cep))
            {
                return "Cep contem letras!";
            }
            else if (!ContemApenasNumeros(Numero))
            {
                return "Numero contem letras!";
            }
            else if (Cep.Length != 8)
            {
                return "Cep com tamanho invalido!";
            }
            else if (!ExisteCep)
            {
                return "Cep Invalido!";
            }
            else
            {
                
                BancoDeDadosClass banco = new BancoDeDadosClass();
                bool temp = banco.CadastrarEndereço(usuario,Cep,Bairro,Rua,Numero,Complemento);

                if (temp)
                {
                    return "Cadastro Realizado!";
                }
                else 
                {
                    return "Erro!";
                
                }      
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

        public bool StringNulo(string t)
        {
            if (t == null || t == "" || t == " ")
            {
                return true;
            }
            else { return false; }
        }

        public void formatarCep(string Cep) 
        {
            Cep.Replace("-", "");

            char[] chars = Cep.ToCharArray();
            string cepformatado = "";

            foreach (char letra in chars)
            {
                cepformatado += letra;

                if (cepformatado.Length == 5) 
                {
                    cepformatado += "-";
                }
            }

            cep = cepformatado;
        }

        public async Task VerificarCep(string Cep) 
        {
            formatarCep(Cep);

            string link = $"https://viacep.com.br/ws/{cep}/json/";

            HttpClient client = new HttpClient();

            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, link);
                HttpResponseMessage response = await client.SendAsync(request);
                 bool temp = response.IsSuccessStatusCode;

                ExisteCep = temp;
            }
            catch
            {
                ExisteCep = false;
            }
        }

    }
}
