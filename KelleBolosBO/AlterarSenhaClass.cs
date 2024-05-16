using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelleBolosBO
{
    internal class AlterarSenhaClass
    {
        
        private string senhaAntiga { get; set; }

        private string senhaNova { get; set; }

        private string senhaConfirmar { get; set; }

        private string Usuario { get; set; }

        public AlterarSenhaClass(string usuario, string antigasenha, string senhanova, string senhaconfirmar)
        {
            senhaAntiga = senhaAntiga;
            senhaNova = senhanova;
            senhaConfirmar = senhaconfirmar;
            Usuario = usuario;
        }

        public string AlterarSenha() 
        {
            BancoDeDadosClass Bd = new BancoDeDadosClass();
            string senhaAnterior = Bd.LerInfo(Usuario,"Senha");

            if (senhaNova != senhaConfirmar)
            {
                return "Senhas diferentes!";
            }
            else if (senhaNova == senhaAnterior)
            {
                return "Senha Igual a antiga!";
            }
            else 
            {
                if (Bd.AlterarSenha(Usuario)) {
                    return "Senha Alterada!";
                }

                return "mal sucedido";
            }   
        }
    }
}
