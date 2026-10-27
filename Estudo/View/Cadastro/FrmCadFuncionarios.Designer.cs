namespace Estudo
{
    partial class FrmCadFuncionarios
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
            this.txtNumCnh = new System.Windows.Forms.TextBox();
            this.lblNumCnh = new System.Windows.Forms.Label();
            this.txtDatCnh = new System.Windows.Forms.TextBox();
            this.lblDatCnh = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblSalBase = new System.Windows.Forms.Label();
            this.txtSalBase = new System.Windows.Forms.TextBox();
            this.lblNumDep = new System.Windows.Forms.Label();
            this.numNumDep = new System.Windows.Forms.NumericUpDown();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.dateTimeDataValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.txtCodCargo = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnPesquisarCargo = new System.Windows.Forms.Button();
            this.txtCodCidade = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarCidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumDep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumCnh
            // 
            this.txtNumCnh.Location = new System.Drawing.Point(137, 28);
            this.txtNumCnh.Name = "txtNumCnh";
            this.txtNumCnh.Size = new System.Drawing.Size(151, 22);
            this.txtNumCnh.TabIndex = 10;
            // 
            // lblNumCnh
            // 
            this.lblNumCnh.AutoSize = true;
            this.lblNumCnh.Location = new System.Drawing.Point(134, 9);
            this.lblNumCnh.Name = "lblNumCnh";
            this.lblNumCnh.Size = new System.Drawing.Size(87, 16);
            this.lblNumCnh.TabIndex = 11;
            this.lblNumCnh.Text = "Número CNH";
            // 
            // txtDatCnh
            // 
            this.txtDatCnh.Location = new System.Drawing.Point(297, 28);
            this.txtDatCnh.Name = "txtDatCnh";
            this.txtDatCnh.Size = new System.Drawing.Size(93, 22);
            this.txtDatCnh.TabIndex = 12;
            // 
            // lblDatCnh
            // 
            this.lblDatCnh.AutoSize = true;
            this.lblDatCnh.Location = new System.Drawing.Point(294, 9);
            this.lblDatCnh.Name = "lblDatCnh";
            this.lblDatCnh.Size = new System.Drawing.Size(87, 16);
            this.lblDatCnh.TabIndex = 13;
            this.lblDatCnh.Text = "Data da CNH";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(411, 28);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(100, 22);
            this.txtMat.TabIndex = 14;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(408, 9);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(79, 16);
            this.lblMat.TabIndex = 16;
            this.lblMat.Text = "Nº matrícula";
            // 
            // lblSalBase
            // 
            this.lblSalBase.AutoSize = true;
            this.lblSalBase.Location = new System.Drawing.Point(539, 9);
            this.lblSalBase.Name = "lblSalBase";
            this.lblSalBase.Size = new System.Drawing.Size(65, 16);
            this.lblSalBase.TabIndex = 17;
            this.lblSalBase.Text = "Sál. Base";
            // 
            // txtSalBase
            // 
            this.txtSalBase.Location = new System.Drawing.Point(542, 28);
            this.txtSalBase.Name = "txtSalBase";
            this.txtSalBase.Size = new System.Drawing.Size(121, 22);
            this.txtSalBase.TabIndex = 18;
            // 
            // lblNumDep
            // 
            this.lblNumDep.AutoSize = true;
            this.lblNumDep.Location = new System.Drawing.Point(691, 9);
            this.lblNumDep.Name = "lblNumDep";
            this.lblNumDep.Size = new System.Drawing.Size(70, 16);
            this.lblNumDep.TabIndex = 19;
            this.lblNumDep.Text = "Num. Dep.";
            // 
            // numNumDep
            // 
            this.numNumDep.Location = new System.Drawing.Point(694, 29);
            this.numNumDep.Name = "numNumDep";
            this.numNumDep.Size = new System.Drawing.Size(49, 22);
            this.numNumDep.TabIndex = 20;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(12, 65);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 16);
            this.lblCep.TabIndex = 21;
            this.lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(12, 84);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 22);
            this.txtCep.TabIndex = 22;
            // 
            // dateTimeDataValidade
            // 
            this.dateTimeDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataValidade.Location = new System.Drawing.Point(137, 84);
            this.dateTimeDataValidade.Name = "dateTimeDataValidade";
            this.dateTimeDataValidade.Size = new System.Drawing.Size(109, 22);
            this.dateTimeDataValidade.TabIndex = 23;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Location = new System.Drawing.Point(134, 65);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(153, 16);
            this.lblDataValidade.TabIndex = 24;
            this.lblDataValidade.Text = "Data de Validade (CNH)";
            // 
            // txtCodCargo
            // 
            this.txtCodCargo.Location = new System.Drawing.Point(297, 84);
            this.txtCodCargo.Name = "txtCodCargo";
            this.txtCodCargo.Size = new System.Drawing.Size(33, 22);
            this.txtCodCargo.TabIndex = 25;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(336, 84);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 22);
            this.txtCargo.TabIndex = 26;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(337, 65);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 16);
            this.lblCargo.TabIndex = 27;
            this.lblCargo.Text = "Cargo*";
            // 
            // btnPesquisarCargo
            // 
            this.btnPesquisarCargo.Location = new System.Drawing.Point(442, 83);
            this.btnPesquisarCargo.Name = "btnPesquisarCargo";
            this.btnPesquisarCargo.Size = new System.Drawing.Size(83, 23);
            this.btnPesquisarCargo.TabIndex = 28;
            this.btnPesquisarCargo.Text = "Pesquisar";
            this.btnPesquisarCargo.UseVisualStyleBackColor = true;
            this.btnPesquisarCargo.Click += new System.EventHandler(this.btnPesquisarCargo_Click);
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.Location = new System.Drawing.Point(542, 83);
            this.txtCodCidade.Name = "txtCodCidade";
            this.txtCodCidade.Size = new System.Drawing.Size(29, 22);
            this.txtCodCidade.TabIndex = 29;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(577, 83);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 22);
            this.txtCidade.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cidade*";
            // 
            // btnPesquisarCidade
            // 
            this.btnPesquisarCidade.Location = new System.Drawing.Point(686, 82);
            this.btnPesquisarCidade.Name = "btnPesquisarCidade";
            this.btnPesquisarCidade.Size = new System.Drawing.Size(83, 23);
            this.btnPesquisarCidade.TabIndex = 32;
            this.btnPesquisarCidade.Text = "Pesquisar";
            this.btnPesquisarCidade.UseVisualStyleBackColor = true;
            this.btnPesquisarCidade.Click += new System.EventHandler(this.btnPesquisarCidade_Click);
            // 
            // FrmCadFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(852, 474);
            this.Controls.Add(this.btnPesquisarCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCodCidade);
            this.Controls.Add(this.btnPesquisarCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCodCargo);
            this.Controls.Add(this.lblDataValidade);
            this.Controls.Add(this.dateTimeDataValidade);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.numNumDep);
            this.Controls.Add(this.lblNumDep);
            this.Controls.Add(this.txtSalBase);
            this.Controls.Add(this.lblSalBase);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.lblDatCnh);
            this.Controls.Add(this.txtDatCnh);
            this.Controls.Add(this.lblNumCnh);
            this.Controls.Add(this.txtNumCnh);
            this.Name = "FrmCadFuncionarios";
            this.Text = "Cadastro de Funcionario";
            this.Controls.SetChildIndex(this.txtNumCnh, 0);
            this.Controls.SetChildIndex(this.lblNumCnh, 0);
            this.Controls.SetChildIndex(this.txtDatCnh, 0);
            this.Controls.SetChildIndex(this.lblDatCnh, 0);
            this.Controls.SetChildIndex(this.txtMat, 0);
            this.Controls.SetChildIndex(this.lblMat, 0);
            this.Controls.SetChildIndex(this.lblSalBase, 0);
            this.Controls.SetChildIndex(this.txtSalBase, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.Controls.SetChildIndex(this.lblNumDep, 0);
            this.Controls.SetChildIndex(this.numNumDep, 0);
            this.Controls.SetChildIndex(this.lblCep, 0);
            this.Controls.SetChildIndex(this.txtCep, 0);
            this.Controls.SetChildIndex(this.dateTimeDataValidade, 0);
            this.Controls.SetChildIndex(this.lblDataValidade, 0);
            this.Controls.SetChildIndex(this.txtCodCargo, 0);
            this.Controls.SetChildIndex(this.txtCargo, 0);
            this.Controls.SetChildIndex(this.lblCargo, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCargo, 0);
            this.Controls.SetChildIndex(this.txtCodCidade, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCidade, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numNumDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumCnh;
        private System.Windows.Forms.Label lblNumCnh;
        private System.Windows.Forms.TextBox txtDatCnh;
        private System.Windows.Forms.Label lblDatCnh;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblSalBase;
        private System.Windows.Forms.TextBox txtSalBase;
        private System.Windows.Forms.Label lblNumDep;
        private System.Windows.Forms.NumericUpDown numNumDep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.DateTimePicker dateTimeDataValidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.TextBox txtCodCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnPesquisarCargo;
        private System.Windows.Forms.TextBox txtCodCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarCidade;
    }
}
