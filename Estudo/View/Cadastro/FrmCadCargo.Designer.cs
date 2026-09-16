namespace Estudo
{
    partial class FrmCadCargo
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
            this.checkBoxExigeCNH = new System.Windows.Forms.CheckBox();
            this.txtComiss = new System.Windows.Forms.TextBox();
            this.lblComiss = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxExigeCNH
            // 
            this.checkBoxExigeCNH.AutoSize = true;
            this.checkBoxExigeCNH.Location = new System.Drawing.Point(385, 26);
            this.checkBoxExigeCNH.Name = "checkBoxExigeCNH";
            this.checkBoxExigeCNH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxExigeCNH.Size = new System.Drawing.Size(102, 20);
            this.checkBoxExigeCNH.TabIndex = 10;
            this.checkBoxExigeCNH.Text = "?Exige CNH";
            this.checkBoxExigeCNH.UseVisualStyleBackColor = true;
            // 
            // txtComiss
            // 
            this.txtComiss.Location = new System.Drawing.Point(247, 26);
            this.txtComiss.Name = "txtComiss";
            this.txtComiss.Size = new System.Drawing.Size(100, 22);
            this.txtComiss.TabIndex = 11;
            // 
            // lblComiss
            // 
            this.lblComiss.AutoSize = true;
            this.lblComiss.Location = new System.Drawing.Point(244, 7);
            this.lblComiss.Name = "lblComiss";
            this.lblComiss.Size = new System.Drawing.Size(68, 16);
            this.lblComiss.TabIndex = 12;
            this.lblComiss.Text = "Comissão";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(133, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 14;
            // 
            // FrmCadCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(852, 474);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblComiss);
            this.Controls.Add(this.txtComiss);
            this.Controls.Add(this.checkBoxExigeCNH);
            this.Name = "FrmCadCargo";
            this.Text = "Cadastro de Cargo";
            this.Controls.SetChildIndex(this.checkBoxExigeCNH, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.Controls.SetChildIndex(this.txtComiss, 0);
            this.Controls.SetChildIndex(this.lblComiss, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxExigeCNH;
        private System.Windows.Forms.TextBox txtComiss;
        private System.Windows.Forms.Label lblComiss;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}
