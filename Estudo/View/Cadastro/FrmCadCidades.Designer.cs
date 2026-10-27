namespace Estudo
{
    partial class FrmCadCidades
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
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCodEstado = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblDdd = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnPesquisarEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 11;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(146, 9);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 16);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade*";
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(354, 28);
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(71, 22);
            this.txtDdd.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(149, 28);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(173, 22);
            this.txtCidade.TabIndex = 2;
            // 
            // txtCodEstado
            // 
            this.txtCodEstado.Location = new System.Drawing.Point(500, 28);
            this.txtCodEstado.Name = "txtCodEstado";
            this.txtCodEstado.Size = new System.Drawing.Size(46, 22);
            this.txtCodEstado.TabIndex = 7;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(552, 28);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(137, 22);
            this.txtEstado.TabIndex = 8;
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.Location = new System.Drawing.Point(351, 9);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(37, 16);
            this.lblDdd.TabIndex = 17;
            this.lblDdd.Text = "DDD";
            // 
            // lblPais
            // 
            this.lblPais.Location = new System.Drawing.Point(68, 158);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(100, 23);
            this.lblPais.TabIndex = 20;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(554, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 16);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado*";
            // 
            // btnPesquisarEstado
            // 
            this.btnPesquisarEstado.Location = new System.Drawing.Point(700, 28);
            this.btnPesquisarEstado.Name = "btnPesquisarEstado";
            this.btnPesquisarEstado.Size = new System.Drawing.Size(85, 23);
            this.btnPesquisarEstado.TabIndex = 9;
            this.btnPesquisarEstado.Text = "Pesquisar";
            this.btnPesquisarEstado.UseVisualStyleBackColor = true;
            this.btnPesquisarEstado.Click += new System.EventHandler(this.btnPesquisarEstado_Click);
            // 
            // FrmCadCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(852, 474);
            this.Controls.Add(this.btnPesquisarEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblDdd);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtDdd);
            this.Controls.Add(this.lblCidade);
            this.Name = "FrmCadCidades";
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.txtDdd, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtCodEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.lblDdd, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.btnPesquisarEstado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCodEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnPesquisarEstado;
    }
}
