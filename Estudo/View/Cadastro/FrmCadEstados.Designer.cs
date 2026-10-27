namespace Estudo
{
    partial class FrmCadEstados
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCodPais = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(142, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado*";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(782, 28);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(41, 22);
            this.txtUf.TabIndex = 4;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(779, 9);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(25, 16);
            this.lblUf.TabIndex = 12;
            this.lblUf.Text = "UF";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(543, 9);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 16);
            this.lblPais.TabIndex = 13;
            this.lblPais.Text = "Pais*";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(543, 28);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(131, 22);
            this.txtPais.TabIndex = 6;
            // 
            // txtCodPais
            // 
            this.txtCodPais.Location = new System.Drawing.Point(489, 28);
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Size = new System.Drawing.Size(48, 22);
            this.txtCodPais.TabIndex = 5;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(145, 28);
            this.txtEstado.MaxLength = 30;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(221, 22);
            this.txtEstado.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(680, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmCadEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(964, 474);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.lblEstado);
            this.Name = "FrmCadEstados";
            this.Text = "Cadastro Estados";
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtUf, 0);
            this.Controls.SetChildIndex(this.lblUf, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCodPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnPesquisar;
    }
}
