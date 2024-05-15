using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.CodeDom.Compiler;

namespace KelleBolosBO
{
    public class CadastroDeUsuarioClass
    {
        public string Nome { get; set; }

        public string Usuario { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }

        BancoDeDadosClass BancoDeDadosClass  = new BancoDeDadosClass();

        public CadastroDeUsuarioClass(string nome, string usuario, string email, string telefone, string senha, string confirmarsenha) 
        {
            AtribuirNome(nome.Trim()); 
            AtribuirUsuario(usuario.Trim());
            AtribuirEmail(email.Trim());
            Senha = senha.Trim();
            AtribuirTelefone(telefone.Trim());
            AtribuirConfirmarSenha(confirmarsenha.Trim());
        }

        public string Cadastrar() 
        {
            if (StringNulo(Nome) ||
                StringNulo(Usuario) ||
                StringNulo(Email) ||
                StringNulo(Telefone) ||
                StringNulo(Senha) ||
                StringNulo(ConfirmarSenha))
            {
                return "Campos Vazios!!";
            }
            else if (Senha != ConfirmarSenha)
            {
                return "Campos de senhas Diferentes";
            }
            else if (!ContemApenasNumeros(Telefone))
            {
                return "Contem Letras no Telefone";
            }
            else if (BancoDeDadosClass.VerificarUsuario(Usuario))
            {
                return "Usuario ja existente!!";
            }
            else if (Telefone.Length != 11) 
            {
                return "Telefone tamanho invalido!!";
            }
            else
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(Email);

                    return BancoDeDadosClass.CadastrarUsuario(Nome, Email, Telefone, Usuario, Senha);

                }
                catch
                {
                    return "Email Invalido!";
                }
            }
        }


        public void AtribuirConfirmarSenha(string t) 
        {
            ConfirmarSenha = t;
        }

        public void AtribuirNome(string t) 
        {
            Nome = t;
        }
        public void AtribuirTelefone(string t) 
        {
            Telefone = t;
        }

        public void AtribuirEmail(string t) 
        {
            Email = t;
        }

        public void AtribuirUsuario(string t) 
        {
            Usuario = t;
        }

        public bool StringNulo(string t)
        {
            if (t == null || t == "" || t == " ") 
            {
                return true;
            }
            else { return false; }
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
