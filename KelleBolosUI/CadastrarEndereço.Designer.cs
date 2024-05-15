namespace KelleBolosUI
{
    partial class CadastrarEndereço
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarEndereco = new System.Windows.Forms.Button();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(111, 437);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 42);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrarEndereco
            // 
            this.btnCadastrarEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnCadastrarEndereco.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEndereco.Location = new System.Drawing.Point(246, 437);
            this.btnCadastrarEndereco.Name = "btnCadastrarEndereco";
            this.btnCadastrarEndereco.Size = new System.Drawing.Size(129, 42);
            this.btnCadastrarEndereco.TabIndex = 5;
            this.btnCadastrarEndereco.TabStop = false;
            this.btnCadastrarEndereco.Text = "Cadastrar";
            this.btnCadastrarEndereco.UseVisualStyleBackColor = false;
            this.btnCadastrarEndereco.Click += new System.EventHandler(this.btnCadastrarEndereco_Click);
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplemento.Location = new System.Drawing.Point(543, 404);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(258, 65);
            this.txtComplemento.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.label5.Location = new System.Drawing.Point(540, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Complemento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.label4.Location = new System.Drawing.Point(540, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(540, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Bairro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(540, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Rua:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.label1.Location = new System.Drawing.Point(540, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "CEP:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Location = new System.Drawing.Point(604, 325);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(197, 15);
            this.txtNumero.TabIndex = 22;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Location = new System.Drawing.Point(592, 262);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(209, 15);
            this.txtBairro.TabIndex = 21;
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRua.Location = new System.Drawing.Point(585, 203);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(216, 15);
            this.txtRua.TabIndex = 20;
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCEP.Location = new System.Drawing.Point(583, 141);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(218, 15);
            this.txtCEP.TabIndex = 19;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPerfil.ForeColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Location = new System.Drawing.Point(46, 12);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 62);
            this.btnPerfil.TabIndex = 29;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Location = new System.Drawing.Point(439, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 62);
            this.btnHome.TabIndex = 30;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedido.ForeColor = System.Drawing.Color.Transparent;
            this.btnPedido.Location = new System.Drawing.Point(789, 12);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(75, 62);
            this.btnPedido.TabIndex = 31;
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(540, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.Location = new System.Drawing.Point(603, 112);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(16, 16);
            this.txtUsuario.TabIndex = 33;
            this.txtUsuario.Text = "...";
            // 
            // CadastrarEndereço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KelleBolosUI.Properties.Resources._91;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 531);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnCadastrarEndereco);
            this.Controls.Add(this.btnVoltar);
            this.DoubleBuffered = true;
            this.Name = "CadastrarEndereço";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarEndereço";
            this.Load += new System.EventHandler(this.CadastrarEndereço_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrarEndereco;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtUsuario;
    }
}