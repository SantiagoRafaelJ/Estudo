namespace Estudo
{
    partial class FrmConEstados
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
            this.colN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Pais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_UF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Codigo,
            this.Col_Estado,
            this.Col_UF,
            this.Col_Pais,
            this.colN});
            this.LV.FullRowSelect = true;
            this.LV.GridLines = true;
            this.LV.MultiSelect = false;
            this.LV.View = System.Windows.Forms.View.Details;
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            // 
            // colN
            // 
            this.colN.DisplayIndex = 0;
            this.colN.Text = ".";
            this.colN.Width = 10;
            // 
            // Col_Codigo
            // 
            this.Col_Codigo.DisplayIndex = 1;
            this.Col_Codigo.Text = "Codigo";
            // 
            // Col_Estado
            // 
            this.Col_Estado.DisplayIndex = 2;
            this.Col_Estado.Text = "Estado";
            // 
            // Col_Pais
            // 
            this.Col_Pais.DisplayIndex = 4;
            this.Col_Pais.Text = "Pais";
            // 
            // Col_UF
            // 
            this.Col_UF.DisplayIndex = 3;
            this.Col_UF.Text = "UF";
            // 
            // FrmConEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConEstados";
            this.Text = "Consulta de Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colN;
        private System.Windows.Forms.ColumnHeader Col_Codigo;
        private System.Windows.Forms.ColumnHeader Col_Estado;
        private System.Windows.Forms.ColumnHeader Col_Pais;
        private System.Windows.Forms.ColumnHeader Col_UF;
    }
}
