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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSelecionar3_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Close();
        }

        private void btnSelecionar2_Click(object sender, EventArgs e)
        {                 
            PedidoClass pedidoclass = new PedidoClass();
            pedidoclass.ArmazenarPedido($"{cbBolos.Text}",$"{BolosQuatidade.Value}");

            Pedido pedido = new Pedido();
            pedido.Show();
            this.Close();
        }

        private void btnSelecionar1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
            this.Close();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }
    }
}
