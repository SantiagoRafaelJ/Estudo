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
            this.txtMat.Enabled = false;
            this.txtSalBase.Enabled = false;
            this.numNumDep.Enabled = false;
            this.txtCep.Enabled = false;
            this.dateTimeDatCnhVal.Enabled = false;
            this.txtCodCargo.Enabled = false;
            this.txtCargo.Enabled = false;
            this.txtCodCidade.Enabled = false;
            this.txtCidade.Enabled = false;
            this.btnPesquisarCargo.Enabled = false;
            this.btnPesquisarCidade.Enabled = false;
            this.txtNome.Enabled = false;
            this.numIdade.Enabled = false;
            this.txtSexo.Enabled = false;
            this.txtEndereco.Enabled = false;
            this.txtNum.Enabled = false;
            this.txtBairro.Enabled = false;
            this.txtCelular.Enabled = false;
            this.txtCpf.Enabled = false;
            this.txtComplemento.Enabled = false;

        }

        public override void CarregaTxt()
        {
            txtCodigo.Text = Convert.ToString(oFuncionario.Codigo);
            txtNumCnh.Text = Convert.ToString(oFuncionario.NumCnh);
            txtMat.Text = Convert.ToString(oFuncionario.Mat);
            txtSalBase.Text = Convert.ToString(oFuncionario.SalBase);
            numNumDep.Value = oFuncionario.NumDep;
            txtCep.Text = Convert.ToString(oFuncionario.Cep);
            dateTimeDatCnhVal.Value = oFuncionario.DatCnhVal;
            txtCodCargo.Text = Convert.ToString(oFuncionario.OCargo.Codigo);
            txtCargo.Text = Convert.ToString(oFuncionario.OCargo.Nome);
            txtCodCidade.Text = Convert.ToString(oFuncionario.ACidade.Codigo);
            txtCidade.Text = Convert.ToString(oFuncionario.ACidade.Cidade);
            txtNome.Text = Convert.ToString(oFuncionario.Nome);
            numIdade.Value = oFuncionario.Idade;
            txtSexo.Text = Convert.ToString(oFuncionario.Sexo);
            txtEndereco.Text = Convert.ToString(oFuncionario.Endereco);
            txtNum.Text = Convert.ToString(oFuncionario.Num);
            txtBairro.Text = Convert.ToString(oFuncionario.Bairro);
            txtCelular.Text = Convert.ToString(oFuncionario.Celular);
            txtCpf.Text = Convert.ToString(oFuncionario.Cpf);
            txtComplemento.Text = Convert.ToString(oFuncionario.Complemento);
            this.lblCodUsu.Text = oFuncionario.CodUsu.ToString();
            this.lblDatCad.Text = oFuncionario.DatCad.ToString();
            this.lblUltAlt.Text = oFuncionario.UltAlt.ToString();
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtNumCnh.Clear();
            this.txtMat.Clear();
            this.txtSalBase.Clear();
            this.numNumDep.Value = 0;
            this.txtCep.Clear();
            this.dateTimeDatCnhVal.Value = DateTime.Now;
            this.txtCodCargo.Clear();
            this.txtCargo.Clear();
            this.txtCodCidade.Clear();
            this.txtCidade.Clear();
            this.txtNome.Clear();
            this.numIdade.Value = 0;
            this.txtSexo.Clear();
            this.txtEndereco.Clear();
            this.txtNum.Clear();
            this.txtBairro.Clear();
            this.txtCelular.Clear();
            this.txtCpf.Clear();
            this.txtComplemento.Clear();
            this.lblCodUsu.Text = "";
            this.lblDatCad.Text = "";
            this.lblUltAlt.Text = "";
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtNumCnh.Enabled = true;
            this.txtMat.Enabled = true;
            this.txtSalBase.Enabled = true;
            this.numNumDep.Enabled = true;
            this.txtCep.Enabled = true;
            this.dateTimeDatCnhVal.Enabled = true;
            this.txtCodCargo.Enabled = true;
            this.txtCargo.Enabled = true;
            this.txtCodCidade.Enabled = true;
            this.txtCidade.Enabled = true;
            this.btnPesquisarCargo.Enabled = true;
            this.btnPesquisarCidade.Enabled = true;
            this.txtNome.Enabled = true;
            this.numIdade.Enabled = true;
            this.txtSexo.Enabled = true;
            this.txtEndereco.Enabled = true;
            this.txtNum.Enabled = true;
            this.txtBairro.Enabled = true;
            this.txtCelular.Enabled = true;
            this.txtCpf.Enabled = true;
            this.txtComplemento.Enabled = true;

        }

        private void btnPesquisarCargo_Click(object sender, EventArgs e)
        {
            string aux = oFrmConCargo.btnSair.Text;
            oFrmConCargo.btnSair.Text = "Selecionar";
            oFrmConCargo.ConhecaObjeto(oFuncionario.OCargo, aCtrlFuncionarios.ACtrlCargo);
            oFrmConCargo.ShowDialog();
            this.txtCodCargo.Text = Convert.ToString(oFuncionario.OCargo.Codigo);
            this.txtCargo.Text = oFuncionario.OCargo.Nome;
            oFrmConCargo.btnSair.Text = aux;
        }

        private void btnPesquisarCidade_Click(object sender, EventArgs e)
        {
            string aux = oFrmConCidades.btnSair.Text;
            oFrmConCidades.btnSair.Text = "Selecionar";
            oFrmConCidades.ConhecaObjeto(oFuncionario.ACidade, aCtrlFuncionarios.ACtrlCidades);
            oFrmConCidades.ShowDialog();
            this.txtCodCidade.Text = Convert.ToString(oFuncionario.ACidade.Cidade);
            this.txtCidade.Text = oFuncionario.ACidade.Cidade;
            oFrmConCargo.btnSair.Text = aux;
        }

        public override void Salvar()
        {
            oFuncionario.Codigo = Convert.ToInt32(txtCodigo.Text);
            oFuncionario.NumCnh = txtNumCnh.Text;
            oFuncionario.Mat = txtMat.Text;
            oFuncionario.SalBase = txtSalBase.Text;
            oFuncionario.NumDep = Convert.ToInt32(numNumDep.Value);
            oFuncionario.DatCnhVal = dateTimeDatCnhVal.Value;
            oFuncionario.Cep = txtCep.Text;
            this.Sair();
        }
    }
}
