namespace Estudo
{
    partial class FrmConCargo
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
            this.Col_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Comiss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_ExigeCnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colN,
            this.Col_Codigo,
            this.Col_Nome,
            this.Col_Comiss,
            this.Col_ExigeCnh});
            this.LV.FullRowSelect = true;
            this.LV.GridLines = true;
            this.LV.MultiSelect = false;
            this.LV.View = System.Windows.Forms.View.Details;
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            // 
            // colN
            // 
            this.colN.Text = ".";
            this.colN.Width = 10;
            // 
            // Col_Codigo
            // 
            this.Col_Codigo.Text = "Codigo";
            // 
            // Col_Nome
            // 
            this.Col_Nome.Text = "Nome";
            // 
            // Col_Comiss
            // 
            this.Col_Comiss.Text = "Comissão";
            this.Col_Comiss.Width = 80;
            // 
            // Col_ExigeCnh
            // 
            this.Col_ExigeCnh.Text = "Exige CNH";
            this.Col_ExigeCnh.Width = 80;
            // 
            // FrmConCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConCargo";
            this.Text = "Consulta Cargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colN;
        private System.Windows.Forms.ColumnHeader Col_Codigo;
        private System.Windows.Forms.ColumnHeader Col_Nome;
        private System.Windows.Forms.ColumnHeader Col_Comiss;
        private System.Windows.Forms.ColumnHeader Col_ExigeCnh;
    }
}
