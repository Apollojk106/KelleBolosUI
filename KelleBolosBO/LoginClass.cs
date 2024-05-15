using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelleBolosBO
{
    public class LoginClass
    {
        public string Usuario { get; set; }

        public string Senha { get; set; }

        public LoginClass(string usuario, string senha) 
        {
            AtriburSenha(senha);
            AtriburUsuario(usuario);
        }

        public void AtriburUsuario(string t) 
        {
            Usuario = t.Trim();
        }

        public void AtriburSenha(string t)
        {
            Senha = t.Trim();
        }

        BancoDeDadosClass BancoDeDadosClass = new BancoDeDadosClass();

        public string Logar() 
        {
            if (StringNulo(Usuario))
            {
                return "Campo usuario vazio!";
            }
            else if (StringNulo(Senha))
            {
                return "Campo senha vazio!";
            }
            else if (!BancoDeDadosClass.VerificarUsuario(Usuario)) 
            {
                return "Usuario Inexistente!";
            }
            else
            {
                if (BancoDeDadosClass.LogarUsuario(Usuario, Senha))
                {
                    return "Logado com sucesso!";
                }
                else 
                {
                    return "Usuario ou Senha Incorretos!";
                }
            }
        }

        public bool StringNulo(string t)
        {
            if (t == null || t == "" || t == " ")
            {
                return true;
            }
            else { return false; }
        }


    }
}
