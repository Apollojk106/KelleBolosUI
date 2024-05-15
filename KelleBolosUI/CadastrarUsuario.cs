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
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroDeUsuarioClass cadastroDeUsuarioClass = new CadastroDeUsuarioClass(
                txtNome.Text,
                txtUsuario.Text,
                txtEmail.Text,
                txtTelefone.Text,
                txtSenha.Text,
                txtConfirmarSenha.Text);

            string temporaria = cadastroDeUsuarioClass.Cadastrar();

            MessageBox.Show(temporaria);

            if (temporaria == "Cadastro Realizado!") 
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }       
        }
    }
}
