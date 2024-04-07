namespace KelleBolosUI
{
    partial class Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarEndereco = new System.Windows.Forms.Button();
            this.btnMudarSenha = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPedir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarEndereco
            // 
            this.btnCadastrarEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnCadastrarEndereco.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEndereco.Location = new System.Drawing.Point(678, 320);
            this.btnCadastrarEndereco.Name = "btnCadastrarEndereco";
            this.btnCadastrarEndereco.Size = new System.Drawing.Size(129, 42);
            this.btnCadastrarEndereco.TabIndex = 7;
            this.btnCadastrarEndereco.TabStop = false;
            this.btnCadastrarEndereco.Text = "Cadastrar Endereço";
            this.btnCadastrarEndereco.UseVisualStyleBackColor = false;
            this.btnCadastrarEndereco.Click += new System.EventHandler(this.btnCadastrarEndereco_Click);
            // 
            // btnMudarSenha
            // 
            this.btnMudarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnMudarSenha.FlatAppearance.BorderSize = 0;
            this.btnMudarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMudarSenha.Location = new System.Drawing.Point(678, 377);
            this.btnMudarSenha.Name = "btnMudarSenha";
            this.btnMudarSenha.Size = new System.Drawing.Size(129, 42);
            this.btnMudarSenha.TabIndex = 8;
            this.btnMudarSenha.TabStop = false;
            this.btnMudarSenha.Text = "Mudar Senha";
            this.btnMudarSenha.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(678, 434);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 42);
            this.btnSair.TabIndex = 9;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(87)))), ((int)(((byte)(77)))));
            this.btnPedir.FlatAppearance.BorderSize = 0;
            this.btnPedir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedir.Location = new System.Drawing.Point(144, 377);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(129, 42);
            this.btnPedir.TabIndex = 10;
            this.btnPedir.TabStop = false;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(113)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(141, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ultimo Pedido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KelleBolosUI.Properties.Resources._26;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(953, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Location = new System.Drawing.Point(434, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 62);
            this.btnHome.TabIndex = 33;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedido.ForeColor = System.Drawing.Color.Transparent;
            this.btnPedido.Location = new System.Drawing.Point(790, 0);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(75, 62);
            this.btnPedido.TabIndex = 34;
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KelleBolosUI.Properties.Resources._27;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 531);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPedir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMudarSenha);
            this.Controls.Add(this.btnCadastrarEndereco);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrarEndereco;
        private System.Windows.Forms.Button btnMudarSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPedido;
    }
}