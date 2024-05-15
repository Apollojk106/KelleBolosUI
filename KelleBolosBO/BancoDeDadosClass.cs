using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;


namespace KelleBolosBO
{
    public class BancoDeDadosClass
    {
        public BancoDeDadosClass() 
        {
        
        }

        const string conexao = "server=localhost;uid=root;pwd=jk106;database=keebolos";

        public bool VerificarUsuario(string Usuario) 
        {
            try
            {
                using (var conexaoConnection = new MySqlConnection(conexao))
                {

                    conexaoConnection.Open();

                    string query = $"SELECT * FROM usuario WHERE Usuario = '{Usuario}'";

                    using (var command = new MySqlCommand(query, conexaoConnection))
                    {
                        command.Parameters.AddWithValue("Usuario", Usuario);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }

            
        }

        /*
        public string CadastrarPedidoBuscar(string Nome, string Telefone, string Item, string Quantidade) 
        {
            try 
            {
                
            }
            catch 
            {
            
            }
        
        }
        */
        public string CadastrarUsuario(string Nome, string Email, string Telefone, string Usuario, string Senha) 
        {
            try
            {
                using (var Conecao = new MySqlConnection(conexao)) 
                {
                    Conecao.Open();

                    string SaltKey = GerarSalt();

                    string SenhaHash = GerarSenhaComHash(Senha, SaltKey);

                    string query = $"insert into usuario(Nome, Usuario, Telefone, Email, Senha, SaltKey) value('{Nome}','{Usuario}','{Telefone}','{Email}','{SenhaHash}','{SaltKey}');";

                    using (var cmd = new MySqlCommand(query, Conecao)) 
                    {
                        cmd.Parameters.AddWithValue("Nome", Nome);
                        cmd.Parameters.AddWithValue("Usuario", Usuario);
                        cmd.Parameters.AddWithValue("Telefone", Telefone);
                        cmd.Parameters.AddWithValue("Email", Email);
                        cmd.Parameters.AddWithValue("Senha", SenhaHash);
                        cmd.Parameters.AddWithValue("SaltKey", SaltKey);

                        cmd.ExecuteNonQuery();
                    }

                    Conecao.Close();
                    return "Cadastro Realizado!";
                }
                    
            }
            catch (Exception ex) 
            {
                return ex.ToString();
            }
        
        }

        public bool LogarUsuario(string Usuario, string Senha) 
        {
            try
            {
                using (var Conecao = new MySqlConnection(conexao)) 
                {
                    Conecao.Open();

                    string SaltKey = LerSaltKey(Usuario);

                    if (SaltKey == "Nenhum Salt.") { return false; }

                    string SenhaHash = GerarSenhaComHash(Senha, SaltKey);

                    string query = $"select * from usuario where Usuario = '{Usuario}' and Senha = '{SenhaHash}';";

                    using (var cmd = new MySqlCommand(query, Conecao)) 
                    {
                        cmd.Parameters.AddWithValue("Usuario", Usuario);
                        cmd.Parameters.AddWithValue("Senha", SenhaHash);

                        using (var reader = cmd.ExecuteReader()) 
                        {
                            if (reader.HasRows)
                            {
                                return true;
                            }
                            else 
                            {
                                return false;
                            }                                               
                        }
                    }
                }
            }
            catch 
            {
                return false;           
            }
        
        }

        public string LerSaltKey(string Usuario) 
        {
            string query = $"SELECT SaltKey FROM Usuario WHERE usuario = '{Usuario}'";

            try
            {
                using (MySqlConnection Conexao = new MySqlConnection(conexao))
                {
                    
                    Conexao.Open();
                    string salt = "Nenhum Salt.";

                    
                    using (MySqlCommand comando = new MySqlCommand(query, Conexao))
                    {
                        
                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            
                            if (leitor.HasRows)
                            {
                                
                                while (leitor.Read())
                                {                                   
                                    salt = leitor.GetString(0);                                   
                                }

                                return salt;
                            }
                            else
                            {
                                return "Nenhum Salt.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                return $"{ex}";
            }
        }

        public string GerarSalt() 
        {
            Random random = new Random();       

            byte[] bytes1 = new byte[8];

            random.NextBytes(bytes1);
              
            string SaltKey = BitConverter.ToString(bytes1).Replace("-", "").ToLower();

            return SaltKey;
        }

        public string GerarSenhaComHash(string Senha, string SaltKey) 
        {

            string senhasalt = Senha + "." + SaltKey;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senhasalt);

                byte[] hashBytes = sha256.ComputeHash(bytes);

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public bool CadastrarEndereço(string usuario, string cep, string bairro, string rua, string numero, string complemento) 
        {
            string query = $"insert into endereço(Usuario, CEP, Bairro,Rua, Numero,Complemento) values('{usuario}','{cep}','{bairro}','{rua}','{numero}','{complemento}');";

            try
            {
                if (VerificarCadastroExistente(usuario)) 
                {
                    ApagarCadastroExistente(usuario);
                }

                using (MySqlConnection Conexao = new MySqlConnection(conexao)) 
                {

                    Conexao.Open();

                    using (MySqlCommand CMD = new MySqlCommand(query, Conexao)) 
                    {

                        CMD.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch 
            {
                return false;
            }
        }

        public string LerInfo(string Usuario, string Info)
        {
            string query = $"SELECT {Info} FROM Usuario WHERE usuario = '{Usuario}'";

            try
            {
                using (MySqlConnection Conexao = new MySqlConnection(conexao))
                {

                    Conexao.Open();
                    string leitura = $"Nenhum {Info}.";


                    using (MySqlCommand comando = new MySqlCommand(query, Conexao))
                    {

                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {

                            if (leitor.HasRows)
                            {

                                while (leitor.Read())
                                {
                                    leitura = leitor.GetString(0);
                                }

                                return leitura;
                            }
                            else
                            {
                                return $"Nenhum {Info}.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

        private bool VerificarCadastroExistente(string Usuario) 
        {
            try
            {
                using (MySqlConnection Conexao = new MySqlConnection(conexao)) 
                {
                    Conexao.Open();

                    string query = $"select * from endereço where Usuario = '{Usuario}';";

                    using (MySqlCommand cmd = new MySqlCommand(query, Conexao)) 
                    {

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch 
            {
                return false;
            }
        }

        private void ApagarCadastroExistente(string Usuario) 
        {
            try
            {
                using (MySqlConnection Conexao = new MySqlConnection(conexao))
                {
                    Conexao.Open();

                    string query = $"delete from endereço where Usuario = '{Usuario}';";

                    using (MySqlCommand cmd = new MySqlCommand(query, Conexao))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch 
            {
                Console.WriteLine("Paia");
            }

        }
    }
}
