namespace KelleBolosUI
{
    partial class Home
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
            this.btnBolos = new System.Windows.Forms.Button();
            this.btnSazonais = new System.Windows.Forms.Button();
            this.btnDoces = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.cbBolos = new System.Windows.Forms.ComboBox();
            this.BolosQuatidade = new System.Windows.Forms.NumericUpDown();
            this.DocesQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cbDoces = new System.Windows.Forms.ComboBox();
            this.SazonaisQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cbSazonais = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BolosQuatidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocesQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SazonaisQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBolos
            // 
            this.btnBolos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnBolos.FlatAppearance.BorderSize = 0;
            this.btnBolos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBolos.Location = new System.Drawing.Point(396, 435);
            this.btnBolos.Name = "btnBolos";
            this.btnBolos.Size = new System.Drawing.Size(129, 42);
            this.btnBolos.TabIndex = 4;
            this.btnBolos.TabStop = false;
            this.btnBolos.Text = "Selecionar";
            this.btnBolos.UseVisualStyleBackColor = false;
            this.btnBolos.Click += new System.EventHandler(this.btnSelecionar2_Click);
            // 
            // btnSazonais
            // 
            this.btnSazonais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnSazonais.FlatAppearance.BorderSize = 0;
            this.btnSazonais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSazonais.Location = new System.Drawing.Point(729, 435);
            this.btnSazonais.Name = "btnSazonais";
            this.btnSazonais.Size = new System.Drawing.Size(129, 42);
            this.btnSazonais.TabIndex = 5;
            this.btnSazonais.TabStop = false;
            this.btnSazonais.Text = "Selecionar";
            this.btnSazonais.UseVisualStyleBackColor = false;
            this.btnSazonais.Click += new System.EventHandler(this.btnSelecionar3_Click);
            // 
            // btnDoces
            // 
            this.btnDoces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnDoces.FlatAppearance.BorderSize = 0;
            this.btnDoces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoces.Location = new System.Drawing.Point(72, 435);
            this.btnDoces.Name = "btnDoces";
            this.btnDoces.Size = new System.Drawing.Size(129, 42);
            this.btnDoces.TabIndex = 6;
            this.btnDoces.TabStop = false;
            this.btnDoces.Text = "Selecionar";
            this.btnDoces.UseVisualStyleBackColor = false;
            this.btnDoces.Click += new System.EventHandler(this.btnSelecionar1_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPerfil.ForeColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Location = new System.Drawing.Point(40, 12);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 62);
            this.btnPerfil.TabIndex = 32;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedido.ForeColor = System.Drawing.Color.Transparent;
            this.btnPedido.Location = new System.Drawing.Point(783, 12);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(75, 62);
            this.btnPedido.TabIndex = 34;
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // cbBolos
            // 
            this.cbBolos.AutoCompleteCustomSource.AddRange(new string[] {
            "ABACAXI COM DOCE DE LEITE",
            "MARACUJÁ",
            "DOCE DE LEITE",
            "PÊSSEGO",
            "ABACAXI COM CREME",
            "DOIS AMORES",
            "NINHO COM MORANGO",
            "BEIJINHO",
            "TRUFADO DE CHOCOLATE AO LEITE",
            "TRES LEITE",
            "DOCE DE LEITE COM AΜΕΙΧΑ",
            "FLOCOS",
            "PRESTIGIO",
            "TRUFADO DE CHOCOLATE BRANCO",
            "BRIGADEIRO GOURMET AO LEITE",
            "FLORESTA NEGRA",
            "LAKA",
            "GALAK",
            "CHICABON",
            "SONHO DE VALSA",
            "DOCE DE LEITE",
            "COM AMEIΧΑ",
            "BRIGADEIRO GOURMET AO BRANCO"});
            this.cbBolos.FormattingEnabled = true;
            this.cbBolos.Items.AddRange(new object[] {
            "ABACAXI COM DOCE DE LEITE",
            "MARACUJÁ",
            "DOCE DE LEITE",
            "PÊSSEGO",
            "ABACAXI COM CREME",
            "DOIS AMORES",
            "NINHO COM MORANGO",
            "BEIJINHO",
            "TRUFADO DE CHOCOLATE AO LEITE",
            "TRES LEITE",
            "DOCE DE LEITE COM AΜΕΙΧΑ",
            "FLOCOS",
            "PRESTIGIO",
            "TRUFADO DE CHOCOLATE BRANCO",
            "BRIGADEIRO GOURMET AO LEITE",
            "FLORESTA NEGRA",
            "LAKA",
            "GALAK",
            "CHICABON",
            "SONHO DE VALSA",
            "DOCE DE LEITE",
            "COM AMEIΧΑ",
            "BRIGADEIRO GOURMET AO BRANCO"});
            this.cbBolos.Location = new System.Drawing.Point(362, 369);
            this.cbBolos.Name = "cbBolos";
            this.cbBolos.Size = new System.Drawing.Size(163, 24);
            this.cbBolos.TabIndex = 36;
            // 
            // BolosQuatidade
            // 
            this.BolosQuatidade.Location = new System.Drawing.Point(531, 370);
            this.BolosQuatidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BolosQuatidade.Name = "BolosQuatidade";
            this.BolosQuatidade.Size = new System.Drawing.Size(48, 22);
            this.BolosQuatidade.TabIndex = 38;
            this.BolosQuatidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BolosQuatidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DocesQuantidade
            // 
            this.DocesQuantidade.Location = new System.Drawing.Point(207, 369);
            this.DocesQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DocesQuantidade.Name = "DocesQuantidade";
            this.DocesQuantidade.Size = new System.Drawing.Size(48, 22);
            this.DocesQuantidade.TabIndex = 40;
            this.DocesQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DocesQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbDoces
            // 
            this.cbDoces.AutoCompleteCustomSource.AddRange(new string[] {
            "ABACAXI COM DOCE DE LEITE",
            "MARACUJÁ",
            "DOCE DE LEITE",
            "PÊSSEGO",
            "ABACAXI COM CREME",
            "DOIS AMORES",
            "NINHO COM MORANGO",
            "BEIJINHO",
            "TRUFADO DE CHOCOLATE AO LEITE",
            "TRES LEITE",
            "DOCE DE LEITE COM AΜΕΙΧΑ",
            "FLOCOS",
            "PRESTIGIO",
            "TRUFADO DE CHOCOLATE BRANCO",
            "BRIGADEIRO GOURMET AO LEITE",
            "FLORESTA NEGRA",
            "LAKA",
            "GALAK",
            "CHICABON",
            "SONHO DE VALSA",
            "DOCE DE LEITE",
            "COM AMEIΧΑ",
            "BRIGADEIRO GOURMET AO BRANCO"});
            this.cbDoces.FormattingEnabled = true;
            this.cbDoces.Items.AddRange(new object[] {
            "ABACAXI COM DOCE DE LEITE",
            "MARACUJÁ",
            "DOCE DE LEITE",
            "PÊSSEGO",
            "ABACAXI COM CREME",
            "DOIS AMORES",
            "NINHO COM MORANGO",
            "BEIJINHO",
            "TRUFADO DE CHOCOLATE AO LEITE",
            "TRES LEITE",
            "DOCE DE LEITE COM AΜΕΙΧΑ",
            "FLOCOS",
            "PRESTIGIO",
            "TRUFADO DE CHOCOLATE BRANCO",
            "BRIGADEIRO GOURMET AO LEITE",
            "FLORESTA NEGRA",
            "LAKA",
            "GALAK",
            "CHICABON",
            "SONHO DE VALSA",
            "DOCE DE LEITE",
            "COM AMEIΧΑ",
            "BRIGADEIRO GOURMET AO BRANCO"});
            this.cbDoces.Location = new System.Drawing.Point(38, 368);
            this.cbDoces.Name = "cbDoces";
            this.cbDoces.Size = new System.Drawing.Size(163, 24);
            this.cbDoces.TabIndex = 39;
            // 
            // SazonaisQuantidade
            // 
            this.SazonaisQuantidade.Location = new System.Drawing.Point(864, 368);
            this.SazonaisQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SazonaisQuantidade.Name = "SazonaisQuantidade";
            this.SazonaisQuantidade.Size = new System.Drawing.Size(48, 22);
            this.SazonaisQuantidade.TabIndex = 42;
            this.SazonaisQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SazonaisQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbSazonais
            // 
            this.cbSazonais.AutoCompleteCustomSource.AddRange(new string[] {
            "ABACAXI COM DOCE DE LEITE",
            "MARACUJÁ",
            "DOCE DE LEITE",
            "PÊSSEGO",
            "ABACAXI COM CREME",
            "DOIS AMORES",
            "NINHO COM MORANGO",
            "BEIJINHO",
            "TRUFADO DE CHOCOLATE AO LEITE",
            "TRES LEITE",
            "DOCE DE LEITE COM AΜΕΙΧΑ",
            "FLOCOS",
            "PRESTIGIO",
            "TRUFADO DE CHOCOLATE BRANCO",
            "BRIGADEIRO GOURMET AO LEITE",
            "FLORESTA NEGRA",
            "LAKA",
            "GALAK",
            "CHICABON",
            "SONHO DE VALSA",
            "DOCE DE LEITE",
            "COM AMEIΧΑ",
            "BRIGADEIRO GOURMET AO BRANCO"});
            this.cbSazonais.FormattingEnabled = true;
            this.cbSazonais.Items.AddRange(new object[] {
            "ABACAXI COM DOCE DE LEITE",
            "MARACUJÁ",
            "DOCE DE LEITE",
            "PÊSSEGO",
            "ABACAXI COM CREME",
            "DOIS AMORES",
            "NINHO COM MORANGO",
            "BEIJINHO",
            "TRUFADO DE CHOCOLATE AO LEITE",
            "TRES LEITE",
            "DOCE DE LEITE COM AΜΕΙΧΑ",
            "FLOCOS",
            "PRESTIGIO",
            "TRUFADO DE CHOCOLATE BRANCO",
            "BRIGADEIRO GOURMET AO LEITE",
            "FLORESTA NEGRA",
            "LAKA",
            "GALAK",
            "CHICABON",
            "SONHO DE VALSA",
            "DOCE DE LEITE",
            "COM AMEIΧΑ",
            "BRIGADEIRO GOURMET AO BRANCO"});
            this.cbSazonais.Location = new System.Drawing.Point(695, 367);
            this.cbSazonais.Name = "cbSazonais";
            this.cbSazonais.Size = new System.Drawing.Size(163, 24);
            this.cbSazonais.TabIndex = 41;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KelleBolosUI.Properties.Resources._62;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 531);
            this.Controls.Add(this.SazonaisQuantidade);
            this.Controls.Add(this.cbSazonais);
            this.Controls.Add(this.DocesQuantidade);
            this.Controls.Add(this.cbDoces);
            this.Controls.Add(this.BolosQuatidade);
            this.Controls.Add(this.cbBolos);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnDoces);
            this.Controls.Add(this.btnSazonais);
            this.Controls.Add(this.btnBolos);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BolosQuatidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocesQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SazonaisQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBolos;
        private System.Windows.Forms.Button btnSazonais;
        private System.Windows.Forms.Button btnDoces;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.ComboBox cbBolos;
        private System.Windows.Forms.NumericUpDown BolosQuatidade;
        private System.Windows.Forms.NumericUpDown DocesQuantidade;
        private System.Windows.Forms.ComboBox cbDoces;
        private System.Windows.Forms.NumericUpDown SazonaisQuantidade;
        private System.Windows.Forms.ComboBox cbSazonais;
    }
}