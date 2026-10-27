using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmCadFuncionarios : Estudo.FrmCadastro
    {

        private Funcionario oFuncionario;
        private FrmConCargo oFrmConCargo;
        private FrmConCidades oFrmConCidades;
        private CtrlFunc aCtrlFuncionarios;

        private CtrlCargo aCtrlCargo;

        private CtrlCidades aCtrlCidades;
        public FrmCadFuncionarios()
        {
            InitializeComponent();
        }

        public override void setFrmConsulta(object obj, object OutroObj)
        {
            oFrmConCargo = (FrmConCargo)obj;
            oFrmConCidades = (FrmConCidades)OutroObj;
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oFuncionario = (Funcionario)obj;
            aCtrlFuncionarios = (CtrlFunc)ctrl;
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtNumCnh.Enabled = false;
            this.txtDatCnh.Enabled = false;
            this.txtMat.Enabled = false;
            this.txtSalBase.Enabled = false;
            this.numNumDep.Enabled = false;
            this.txtCep.Enabled = false;
            this.dateTimeDataValidade.Enabled = false;
            this.txtCodCargo.Enabled = false;
            this.txtCargo.Enabled = false;
            this.txtCodCidade.Enabled = false;
            this.txtCidade.Enabled = false;
            this.btnPesquisarCargo.Enabled = false;
            this.btnPesquisarCidade.Enabled = false;
        }

        public override void CarregaTxt()
        {
            txtCodigo.Text = Convert.ToString(oFuncionario.Codigo);
            txtNumCnh.Text = Convert.ToString(oFuncionario.NumCnh);
            txtMat.Text = Convert.ToString(oFuncionario.Mat);
            txtSalBase.Text = Convert.ToString(oFuncionario.SalBase);
            numNumDep.Value = oFuncionario.NumDep;
            txtCep.Text = Convert.ToString(oFuncionario.Cpf);
            dateTimeDataValidade.Value = oFuncionario.DataValidade;
            txtCodCargo.Text = Convert.ToString(oFuncionario.OCargo.Codigo);
            txtCargo.Text = Convert.ToString(oFuncionario.OCargo.Nome);
            txtCodCidade.Text = Convert.ToString(oFuncionario.ACidade.Codigo);
            txtCidade.Text = Convert.ToString(oFuncionario.ACidade.Cidade);
            this.lblCodUsu.Text = oFuncionario.CodUsu.ToString();
            this.lblDatCad.Text = oFuncionario.DatCad.ToString();
            this.lblUltAlt.Text = oFuncionario.UltAlt.ToString();
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtNumCnh.Clear();
            this.txtDatCnh.Clear();
            this.txtMat.Clear();
            this.txtSalBase.Clear();
            this.numNumDep.Value = 0;
            this.txtCep.Clear();
            this.dateTimeDataValidade.Value = DateTime.Now;
            this.txtCodCargo.Clear();
            this.txtCargo.Clear();
            this.txtCodCidade.Clear();
            this.txtCidade.Clear();
            this.lblCodUsu.Text = "";
            this.lblDatCad.Text = "";
            this.lblUltAlt.Text = "";
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtNumCnh.Enabled = true;
            this.txtDatCnh.Enabled = true;
            this.txtMat.Enabled = true;
            this.txtSalBase.Enabled = true;
            this.numNumDep.Enabled = true;
            this.txtCep.Enabled = true;
            this.dateTimeDataValidade.Enabled = true;
            this.txtCodCargo.Enabled = true;
            this.txtCargo.Enabled = true;
            this.txtCodCidade.Enabled = true;
            this.txtCidade.Enabled = true;
            this.btnPesquisarCargo.Enabled = true;
            this.btnPesquisarCidade.Enabled = true;
        }

        private void btnPesquisarCargo_Click(object sender, EventArgs e)
        {
            string aux = oFrmConCargo.btnSair.Text;
            oFrmConCargo.btnSair.Text = "Selecionar";
            oFrmConCargo.ConhecaObjeto(oFuncionario.OCargo, aCtrlCargo);
            oFrmConCargo.ShowDialog();
            this.txtCodCargo.Text = Convert.ToString(oFuncionario.OCargo.Codigo);
            this.txtCargo.Text = oFuncionario.OCargo.Nome;
            oFrmConCargo.btnSair.Text = aux;
        }

        private void btnPesquisarCidade_Click(object sender, EventArgs e)
        {
            string aux = oFrmConCidades.btnSair.Text;
            oFrmConCidades.btnSair.Text = "Selecionar";
            oFrmConCidades.ConhecaObjeto(oFuncionario.ACidade, aCtrlCidades);
            oFrmConCidades.ShowDialog();
            this.txtCodCargo.Text = Convert.ToString(oFuncionario.ACidade.Cidade);
            this.txtCargo.Text = oFuncionario.ACidade.Cidade;
            oFrmConCargo.btnSair.Text = aux;
        }

        public override void Salvar()
        {
            oFuncionario.Codigo = Convert.ToInt32(txtCodigo.Text);
            oFuncionario.NumCnh = txtNumCnh.Text;
            oFuncionario.DatCnh = txtDatCnh.Text;
            oFuncionario.Mat = txtMat.Text;
            oFuncionario.SalBase = txtSalBase.Text;
            oFuncionario.NumDep = Convert.ToInt32(numNumDep.Value);
            oFuncionario.DataValidade = dateTimeDataValidade.Value;
            oFuncionario.Cep = txtCep.Text;
            this.Sair();
        }
    }
}
