using KelleBolosBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelleBolosUI
{
    public partial class CadastrarEndereço : Form
    {
        public CadastrarEndereço()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Close();
        }

        private void CadastrarEndereço_Load(object sender, EventArgs e)
        {
            ArquivosTXTClass arquivosTXT = new ArquivosTXTClass();
            txtUsuario.Text = arquivosTXT.ler("Usuario");


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private async void btnCadastrarEndereco_Click(object sender, EventArgs e)
        {
            ArquivosTXTClass arquivosTXT = new ArquivosTXTClass();
            string usuario = arquivosTXT.ler("Usuario");

            CadastrarEnderecoClass cadastrar = new CadastrarEnderecoClass();
            Task<string> temp = cadastrar.Validar(txtCEP.Text, txtBairro.Text, txtRua.Text, txtNumero.Text, txtComplemento.Text, usuario);
            string resultado = await temp;

            MessageBox.Show(resultado);
        }
    }
}
