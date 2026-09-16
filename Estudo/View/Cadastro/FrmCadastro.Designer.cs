namespace Estudo
{
    partial class FrmCadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDatCadlbl = new System.Windows.Forms.Label();
            this.lblUltAltlbl = new System.Windows.Forms.Label();
            this.lblCodUsulbl = new System.Windows.Forms.Label();
            this.lblDatCad = new System.Windows.Forms.Label();
            this.lblUltAlt = new System.Windows.Forms.Label();
            this.lblCodUsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(599, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDatCadlbl
            // 
            this.lblDatCadlbl.AutoSize = true;
            this.lblDatCadlbl.Location = new System.Drawing.Point(12, 415);
            this.lblDatCadlbl.Name = "lblDatCadlbl";
            this.lblDatCadlbl.Size = new System.Drawing.Size(113, 16);
            this.lblDatCadlbl.TabIndex = 4;
            this.lblDatCadlbl.Text = "Data de Cadastro";
            // 
            // lblUltAltlbl
            // 
            this.lblUltAltlbl.AutoSize = true;
            this.lblUltAltlbl.Location = new System.Drawing.Point(182, 415);
            this.lblUltAltlbl.Name = "lblUltAltlbl";
            this.lblUltAltlbl.Size = new System.Drawing.Size(106, 16);
            this.lblUltAltlbl.TabIndex = 5;
            this.lblUltAltlbl.Text = "Ultima Alteração";
            // 
            // lblCodUsulbl
            // 
            this.lblCodUsulbl.AutoSize = true;
            this.lblCodUsulbl.Location = new System.Drawing.Point(351, 415);
            this.lblCodUsulbl.Name = "lblCodUsulbl";
            this.lblCodUsulbl.Size = new System.Drawing.Size(101, 16);
            this.lblCodUsulbl.TabIndex = 6;
            this.lblCodUsulbl.Text = "Código Usuário";
            // 
            // lblDatCad
            // 
            this.lblDatCad.AutoSize = true;
            this.lblDatCad.Location = new System.Drawing.Point(30, 440);
            this.lblDatCad.Name = "lblDatCad";
            this.lblDatCad.Size = new System.Drawing.Size(0, 16);
            this.lblDatCad.TabIndex = 7;
            // 
            // lblUltAlt
            // 
            this.lblUltAlt.AutoSize = true;
            this.lblUltAlt.Location = new System.Drawing.Point(204, 440);
            this.lblUltAlt.Name = "lblUltAlt";
            this.lblUltAlt.Size = new System.Drawing.Size(0, 16);
            this.lblUltAlt.TabIndex = 8;
            // 
            // lblCodUsu
            // 
            this.lblCodUsu.AutoSize = true;
            this.lblCodUsu.Location = new System.Drawing.Point(382, 440);
            this.lblCodUsu.Name = "lblCodUsu";
            this.lblCodUsu.Size = new System.Drawing.Size(0, 16);
            this.lblCodUsu.TabIndex = 9;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(852, 474);
            this.Controls.Add(this.lblCodUsu);
            this.Controls.Add(this.lblUltAlt);
            this.Controls.Add(this.lblDatCad);
            this.Controls.Add(this.lblCodUsulbl);
            this.Controls.Add(this.lblUltAltlbl);
            this.Controls.Add(this.lblDatCadlbl);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDatCadlbl, 0);
            this.Controls.SetChildIndex(this.lblUltAltlbl, 0);
            this.Controls.SetChildIndex(this.lblCodUsulbl, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatCadlbl;
        private System.Windows.Forms.Label lblUltAltlbl;
        private System.Windows.Forms.Label lblCodUsulbl;
        protected System.Windows.Forms.Label lblDatCad;
        protected System.Windows.Forms.Label lblUltAlt;
        protected System.Windows.Forms.Label lblCodUsu;
        public System.Windows.Forms.Button btnSalvar;
    }
}
