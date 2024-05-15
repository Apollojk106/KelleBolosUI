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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            PedidoClass pedidoClass = new PedidoClass();
            string[] infos = pedidoClass.RetornarInfoParaPedido().Split('|');

            ArquivosTXTClass arquivosTXTClass = new ArquivosTXTClass();
            string[] PedidoInfos = arquivosTXTClass.ler("Pedido").Split('|');

            string Nome = infos[0];
            string Telefone = infos[1];
            lblItem.Text = PedidoInfos[0];
            lblQuantidade.Text = PedidoInfos[1];
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }
    }
}
