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
            this.txtMat = new System.Windows.Forms.TextBox();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblSalBase = new System.Windows.Forms.Label();
            this.txtSalBase = new System.Windows.Forms.TextBox();
            this.lblNumDep = new System.Windows.Forms.Label();
            this.numNumDep = new System.Windows.Forms.NumericUpDown();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.dateTimeDatCnhVal = new System.Windows.Forms.DateTimePicker();
            this.lblDatCnhVal = new System.Windows.Forms.Label();
            this.txtCodCargo = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnPesquisarCargo = new System.Windows.Forms.Button();
            this.txtCodCidade = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarCidade = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
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
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(430, 136);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(100, 22);
            this.txtMat.TabIndex = 14;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(427, 117);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(79, 16);
            this.lblMat.TabIndex = 16;
            this.lblMat.Text = "Nº matrícula";
            // 
            // lblSalBase
            // 
            this.lblSalBase.AutoSize = true;
            this.lblSalBase.Location = new System.Drawing.Point(288, 117);
            this.lblSalBase.Name = "lblSalBase";
            this.lblSalBase.Size = new System.Drawing.Size(65, 16);
            this.lblSalBase.TabIndex = 17;
            this.lblSalBase.Text = "Sál. Base";
            // 
            // txtSalBase
            // 
            this.txtSalBase.Location = new System.Drawing.Point(291, 136);
            this.txtSalBase.Name = "txtSalBase";
            this.txtSalBase.Size = new System.Drawing.Size(121, 22);
            this.txtSalBase.TabIndex = 18;
            // 
            // lblNumDep
            // 
            this.lblNumDep.AutoSize = true;
            this.lblNumDep.Location = new System.Drawing.Point(204, 117);
            this.lblNumDep.Name = "lblNumDep";
            this.lblNumDep.Size = new System.Drawing.Size(70, 16);
            this.lblNumDep.TabIndex = 19;
            this.lblNumDep.Text = "Num. Dep.";
            // 
            // numNumDep
            // 
            this.numNumDep.Location = new System.Drawing.Point(207, 137);
            this.numNumDep.Name = "numNumDep";
            this.numNumDep.Size = new System.Drawing.Size(49, 22);
            this.numNumDep.TabIndex = 20;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(537, 118);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 16);
            this.lblCep.TabIndex = 21;
            this.lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(537, 137);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 22);
            this.txtCep.TabIndex = 22;
            // 
            // dateTimeDatCnhVal
            // 
            this.dateTimeDatCnhVal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDatCnhVal.Location = new System.Drawing.Point(661, 137);
            this.dateTimeDatCnhVal.Name = "dateTimeDatCnhVal";
            this.dateTimeDatCnhVal.Size = new System.Drawing.Size(109, 22);
            this.dateTimeDatCnhVal.TabIndex = 23;
            // 
            // lblDatCnhVal
            // 
            this.lblDatCnhVal.AutoSize = true;
            this.lblDatCnhVal.Location = new System.Drawing.Point(658, 118);
            this.lblDatCnhVal.Name = "lblDatCnhVal";
            this.lblDatCnhVal.Size = new System.Drawing.Size(153, 16);
            this.lblDatCnhVal.TabIndex = 24;
            this.lblDatCnhVal.Text = "Data de Validade (CNH)";
            // 
            // txtCodCargo
            // 
            this.txtCodCargo.Location = new System.Drawing.Point(19, 212);
            this.txtCodCargo.Name = "txtCodCargo";
            this.txtCodCargo.Size = new System.Drawing.Size(33, 22);
            this.txtCodCargo.TabIndex = 25;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(58, 212);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 22);
            this.txtCargo.TabIndex = 26;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(55, 191);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 16);
            this.lblCargo.TabIndex = 27;
            this.lblCargo.Text = "Cargo*";
            // 
            // btnPesquisarCargo
            // 
            this.btnPesquisarCargo.Location = new System.Drawing.Point(164, 211);
            this.btnPesquisarCargo.Name = "btnPesquisarCargo";
            this.btnPesquisarCargo.Size = new System.Drawing.Size(83, 23);
            this.btnPesquisarCargo.TabIndex = 28;
            this.btnPesquisarCargo.Text = "Pesquisar";
            this.btnPesquisarCargo.UseVisualStyleBackColor = true;
            this.btnPesquisarCargo.Click += new System.EventHandler(this.btnPesquisarCargo_Click);
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.Location = new System.Drawing.Point(294, 210);
            this.txtCodCidade.Name = "txtCodCidade";
            this.txtCodCidade.Size = new System.Drawing.Size(29, 22);
            this.txtCodCidade.TabIndex = 29;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(329, 210);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 22);
            this.txtCidade.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cidade*";
            // 
            // btnPesquisarCidade
            // 
            this.btnPesquisarCidade.Location = new System.Drawing.Point(438, 209);
            this.btnPesquisarCidade.Name = "btnPesquisarCidade";
            this.btnPesquisarCidade.Size = new System.Drawing.Size(83, 23);
            this.btnPesquisarCidade.TabIndex = 32;
            this.btnPesquisarCidade.Text = "Pesquisar";
            this.btnPesquisarCidade.UseVisualStyleBackColor = true;
            this.btnPesquisarCidade.Click += new System.EventHandler(this.btnPesquisarCidade_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(304, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 22);
            this.txtNome.TabIndex = 33;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(301, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(44, 16);
            this.Nome.TabIndex = 34;
            this.Nome.Text = "Nome";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(563, 9);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(42, 16);
            this.lblIdade.TabIndex = 35;
            this.lblIdade.Text = "Idade";
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(566, 29);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(46, 22);
            this.numIdade.TabIndex = 36;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(640, 9);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 16);
            this.lblSexo.TabIndex = 37;
            this.lblSexo.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(643, 29);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(63, 22);
            this.txtSexo.TabIndex = 38;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(19, 64);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(66, 16);
            this.lblEndereco.TabIndex = 39;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(22, 83);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(150, 22);
            this.txtEndereco.TabIndex = 40;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(182, 64);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(110, 16);
            this.lblNum.TabIndex = 41;
            this.lblNum.Text = "Núm. Residência";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(185, 83);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(107, 22);
            this.txtNum.TabIndex = 42;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(310, 64);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(43, 16);
            this.lblBairro.TabIndex = 43;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(313, 83);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(162, 22);
            this.txtBairro.TabIndex = 44;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(661, 83);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(174, 22);
            this.txtCelular.TabIndex = 45;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(658, 64);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(49, 16);
            this.lblCelular.TabIndex = 46;
            this.lblCelular.Text = "Celular";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(19, 117);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(33, 16);
            this.lblCpf.TabIndex = 47;
            this.lblCpf.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(22, 136);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(170, 22);
            this.txtCpf.TabIndex = 48;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(494, 83);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(143, 22);
            this.txtComplemento.TabIndex = 49;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(491, 64);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(91, 16);
            this.lblComplemento.TabIndex = 50;
            this.lblComplemento.Text = "Complemento";
            // 
            // FrmCadFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(852, 474);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.numIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnPesquisarCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCodCidade);
            this.Controls.Add(this.btnPesquisarCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCodCargo);
            this.Controls.Add(this.lblDatCnhVal);
            this.Controls.Add(this.dateTimeDatCnhVal);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.numNumDep);
            this.Controls.Add(this.lblNumDep);
            this.Controls.Add(this.txtSalBase);
            this.Controls.Add(this.lblSalBase);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.lblNumCnh);
            this.Controls.Add(this.txtNumCnh);
            this.Name = "FrmCadFuncionarios";
            this.Text = "Cadastro de Funcionario";
            this.Controls.SetChildIndex(this.txtNumCnh, 0);
            this.Controls.SetChildIndex(this.lblNumCnh, 0);
            this.Controls.SetChildIndex(this.txtMat, 0);
            this.Controls.SetChildIndex(this.lblMat, 0);
            this.Controls.SetChildIndex(this.lblSalBase, 0);
            this.Controls.SetChildIndex(this.txtSalBase, 0);
            this.Controls.SetChildIndex(this.lblNumDep, 0);
            this.Controls.SetChildIndex(this.numNumDep, 0);
            this.Controls.SetChildIndex(this.lblCep, 0);
            this.Controls.SetChildIndex(this.txtCep, 0);
            this.Controls.SetChildIndex(this.dateTimeDatCnhVal, 0);
            this.Controls.SetChildIndex(this.lblDatCnhVal, 0);
            this.Controls.SetChildIndex(this.txtCodCargo, 0);
            this.Controls.SetChildIndex(this.txtCargo, 0);
            this.Controls.SetChildIndex(this.lblCargo, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCargo, 0);
            this.Controls.SetChildIndex(this.txtCodCidade, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCidade, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.Nome, 0);
            this.Controls.SetChildIndex(this.lblIdade, 0);
            this.Controls.SetChildIndex(this.numIdade, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.txtSexo, 0);
            this.Controls.SetChildIndex(this.lblEndereco, 0);
            this.Controls.SetChildIndex(this.txtEndereco, 0);
            this.Controls.SetChildIndex(this.lblNum, 0);
            this.Controls.SetChildIndex(this.txtNum, 0);
            this.Controls.SetChildIndex(this.lblBairro, 0);
            this.Controls.SetChildIndex(this.txtBairro, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.lblCelular, 0);
            this.Controls.SetChildIndex(this.lblCpf, 0);
            this.Controls.SetChildIndex(this.txtCpf, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.Controls.SetChildIndex(this.txtComplemento, 0);
            this.Controls.SetChildIndex(this.lblComplemento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numNumDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumCnh;
        private System.Windows.Forms.Label lblNumCnh;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblSalBase;
        private System.Windows.Forms.TextBox txtSalBase;
        private System.Windows.Forms.Label lblNumDep;
        private System.Windows.Forms.NumericUpDown numNumDep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.DateTimePicker dateTimeDatCnhVal;
        private System.Windows.Forms.Label lblDatCnhVal;
        private System.Windows.Forms.TextBox txtCodCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnPesquisarCargo;
        private System.Windows.Forms.TextBox txtCodCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
    }
}
