using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KelleBolosBO;

namespace KelleBolosUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            LoginClass loginClass = new LoginClass(txtUsuario.Text, txtSenha.Text);

            string tempo = loginClass.Logar();

            MessageBox.Show(tempo);

            if (tempo == "Logado com sucesso!") 
            {
                ArquivosTXTClass arquivo = new ArquivosTXTClass();
                arquivo.Criar("Usuario",txtUsuario.Text);

                SplashLogado splashLogado = new SplashLogado();
                splashLogado.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cadastrarUsuario = new CadastrarUsuario();
            cadastrarUsuario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EsqueceuSenha esqueceuSenha = new EsqueceuSenha();
            esqueceuSenha.Show();
            this.Hide();
        }
    }
}
