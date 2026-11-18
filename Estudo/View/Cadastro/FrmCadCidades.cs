using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmCadCidades : Estudo.FrmCadastro
    {
        FrmConEstados oFrmConEstados;
        FrmConPaises oFrmConPaises;
        private Cidades oCidade;
        private CtrlCidades aCtrlCidades; 
        public FrmCadCidades()
        {
            InitializeComponent();
        }
        public override void LimpaTxt()
        {
            txtCodigo.Clear();
            txtCidade.Clear();
            txtDdd.Clear();
            txtCodEstado.Clear();
            txtEstado.Clear();
            this.lblCodUsu.Text = "";
            this.lblDatCad.Text = "";
            this.lblUltAlt.Text = "";
        }

        public override void CarregaTxt()
        {
            txtCodigo.Text = Convert.ToString(oCidade.Codigo);
            txtCidade.Text = oCidade.Cidade;
            txtDdd.Text = oCidade.Ddd;
            txtCodEstado.Text = Convert.ToString(oCidade.OEstado.Codigo);
            txtEstado.Text = oCidade.OEstado.Estado;
            this.lblCodUsu.Text = oCidade.CodUsu.ToString();
            this.lblDatCad.Text = oCidade.DatCad.ToString();
            this.lblUltAlt.Text = oCidade.UltAlt.ToString();
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtEstado.Enabled = false;
            this.txtCodEstado.Enabled = false;
            this.txtDdd.Enabled = false;
            this.btnPesquisarEstado.Enabled = false;
            this.txtCidade.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtEstado.Enabled = true;
            this.txtCodEstado.Enabled = true;
            this.txtDdd.Enabled = true;
            this.btnPesquisarEstado.Enabled = true;
            this.txtCidade.Enabled = true;
        }

        public override void setFrmConsulta(object obj, object OutroObj) // Vai receber um Form De Consulta para poder em Estado conseguir Consultar um pais por exemplo
        {
            oFrmConPaises = (FrmConPaises)obj;
            oFrmConEstados = (FrmConEstados)OutroObj;
        }

        public override void Salvar()
        {
            if ((this.txtCidade.Text == "") || (this.txtCidade.Text == null))
            {
                this.txtCidade.Focus();
            }
            if (txtCodEstado == null)
                this.txtCodEstado.Focus();
            oCidade.Codigo = Convert.ToInt32(txtCodigo.Text);
            oCidade.Cidade = txtCidade.Text;
            oCidade.Ddd = txtDdd.Text;
            oCidade.OEstado.Estado = txtEstado.Text;
            oCidade.OEstado.Codigo = Convert.ToInt32(txtCodEstado.Text);
            aCtrlCidades.Salvar(oCidade);
            this.Sair();
        }


        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oCidade = (Cidades)obj;
            aCtrlCidades = (CtrlCidades)ctrl;
        }

        private void btnPesquisarEstado_Click(object sender, EventArgs e)
        {
            string aux = oFrmConEstados.btnSair.Text;
            string aux2 = this.lblEstado.Text;
            oFrmConEstados.btnSair.Text = "Selecionar";
            oFrmConEstados.ConhecaObjeto(oCidade.OEstado, aCtrlCidades.ACtrlEstados);
            oFrmConEstados.ShowDialog();
            this.txtCodEstado.Text = Convert.ToString(oCidade.OEstado.Codigo);
            this.txtEstado.Text = oCidade.OEstado.Estado;
            oFrmConEstados.btnSair.Text = aux;
        }

    }
}
