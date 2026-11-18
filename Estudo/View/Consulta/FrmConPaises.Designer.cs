namespace Estudo
{
    partial class FrmConPaises
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
            this.Col_Paises = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DDI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Moeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colN,
            this.Col_Codigo,
            this.Col_Paises,
            this.Sigla,
            this.DDI,
            this.Moeda});
            this.LV.FullRowSelect = true;
            this.LV.GridLines = true;
            this.LV.View = System.Windows.Forms.View.Details;
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // colN
            // 
            this.colN.DisplayIndex = 5;
            this.colN.Text = ".";
            this.colN.Width = 10;
            // 
            // Col_Codigo
            // 
            this.Col_Codigo.DisplayIndex = 0;
            this.Col_Codigo.Text = "Codigo";
            this.Col_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Col_Paises
            // 
            this.Col_Paises.DisplayIndex = 1;
            this.Col_Paises.Text = "Pais";
            this.Col_Paises.Width = 150;
            // 
            // Sigla
            // 
            this.Sigla.DisplayIndex = 2;
            this.Sigla.Text = "Sigla";
            this.Sigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sigla.Width = 80;
            // 
            // DDI
            // 
            this.DDI.DisplayIndex = 3;
            this.DDI.Text = "DDI";
            this.DDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Moeda
            // 
            this.Moeda.DisplayIndex = 4;
            this.Moeda.Text = "Moeda";
            this.Moeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmConPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConPaises";
            this.Text = "Consulta de Paises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colN;
        private System.Windows.Forms.ColumnHeader Col_Codigo;
        private System.Windows.Forms.ColumnHeader Col_Paises;
        private System.Windows.Forms.ColumnHeader Sigla;
        private System.Windows.Forms.ColumnHeader DDI;
        private System.Windows.Forms.ColumnHeader Moeda;
    }
}
