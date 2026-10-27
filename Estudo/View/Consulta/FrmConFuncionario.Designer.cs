namespace Estudo
{
    partial class FrmConFuncionario
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
            this.Col_Mat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Cargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_NumCnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Validade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_SalBase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colN,
            this.Col_Codigo,
            this.Col_Mat,
            this.Col_Cargo,
            this.Col_Cidade,
            this.Col_NumCnh,
            this.Col_Validade,
            this.Col_SalBase});
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
            // Col_Mat
            // 
            this.Col_Mat.Text = "Matrícula";
            // 
            // Col_Cargo
            // 
            this.Col_Cargo.Text = "Cargo";
            // 
            // Col_Cidade
            // 
            this.Col_Cidade.Text = "Cidade";
            // 
            // Col_NumCnh
            // 
            this.Col_NumCnh.Text = "Nº CNH";
            // 
            // Col_Validade
            // 
            this.Col_Validade.Text = "Validade CNH";
            // 
            // Col_SalBase
            // 
            this.Col_SalBase.Text = "Sal. Base";
            // 
            // FrmConFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConFuncionario";
            this.Text = "Consulta de Funcionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colN;
        private System.Windows.Forms.ColumnHeader Col_Codigo;
        private System.Windows.Forms.ColumnHeader Col_Mat;
        private System.Windows.Forms.ColumnHeader Col_Cargo;
        private System.Windows.Forms.ColumnHeader Col_Cidade;
        private System.Windows.Forms.ColumnHeader Col_NumCnh;
        private System.Windows.Forms.ColumnHeader Col_Validade;
        private System.Windows.Forms.ColumnHeader Col_SalBase;
    }
}
