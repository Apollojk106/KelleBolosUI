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
            this.btnSelecionar2 = new System.Windows.Forms.Button();
            this.btnSelecionar3 = new System.Windows.Forms.Button();
            this.btnSelecionar1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar2
            // 
            this.btnSelecionar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnSelecionar2.FlatAppearance.BorderSize = 0;
            this.btnSelecionar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar2.Location = new System.Drawing.Point(396, 435);
            this.btnSelecionar2.Name = "btnSelecionar2";
            this.btnSelecionar2.Size = new System.Drawing.Size(129, 42);
            this.btnSelecionar2.TabIndex = 4;
            this.btnSelecionar2.TabStop = false;
            this.btnSelecionar2.Text = "Selecionar";
            this.btnSelecionar2.UseVisualStyleBackColor = false;
            this.btnSelecionar2.Click += new System.EventHandler(this.btnSelecionar2_Click);
            // 
            // btnSelecionar3
            // 
            this.btnSelecionar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnSelecionar3.FlatAppearance.BorderSize = 0;
            this.btnSelecionar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar3.Location = new System.Drawing.Point(729, 435);
            this.btnSelecionar3.Name = "btnSelecionar3";
            this.btnSelecionar3.Size = new System.Drawing.Size(129, 42);
            this.btnSelecionar3.TabIndex = 5;
            this.btnSelecionar3.TabStop = false;
            this.btnSelecionar3.Text = "Selecionar";
            this.btnSelecionar3.UseVisualStyleBackColor = false;
            this.btnSelecionar3.Click += new System.EventHandler(this.btnSelecionar3_Click);
            // 
            // btnSelecionar1
            // 
            this.btnSelecionar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btnSelecionar1.FlatAppearance.BorderSize = 0;
            this.btnSelecionar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar1.Location = new System.Drawing.Point(72, 435);
            this.btnSelecionar1.Name = "btnSelecionar1";
            this.btnSelecionar1.Size = new System.Drawing.Size(129, 42);
            this.btnSelecionar1.TabIndex = 6;
            this.btnSelecionar1.TabStop = false;
            this.btnSelecionar1.Text = "Selecionar";
            this.btnSelecionar1.UseVisualStyleBackColor = false;
            this.btnSelecionar1.Click += new System.EventHandler(this.btnSelecionar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KelleBolosUI.Properties.Resources._14;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(953, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KelleBolosUI.Properties.Resources._15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 531);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnSelecionar1);
            this.Controls.Add(this.btnSelecionar3);
            this.Controls.Add(this.btnSelecionar2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelecionar2;
        private System.Windows.Forms.Button btnSelecionar3;
        private System.Windows.Forms.Button btnSelecionar1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnPedido;
    }
}