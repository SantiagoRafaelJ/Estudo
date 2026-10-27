using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmCadEstados : Estudo.FrmCadastro
    {
        FrmConPaises oFrmConPaises;
        private Estados oEstado;
        private CtrlEstados aCtrlEstados;

        private CtrlPaises aCtrlPaises;
        public FrmCadEstados()
        {
            InitializeComponent();
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtEstado.Clear();
            this.txtUf.Clear();
            this.txtCodPais.Clear();
            this.txtPais.Clear();
            this.lblCodUsu.Text = "";
            this.lblDatCad.Text = "";
            this.lblUltAlt.Text = "";
        }

        public override void CarregaTxt()
        {
            txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            txtEstado.Text = oEstado.Estado;
            txtUf.Text = oEstado.Uf;
            txtCodPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            txtPais.Text = oEstado.OPais.Pais;
            this.lblCodUsu.Text = oEstado.CodUsu.ToString();
            this.lblDatCad.Text = oEstado.DatCad.ToString();
            this.lblUltAlt.Text = oEstado.UltAlt.ToString();
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtEstado.Enabled = false;
            this.txtCodPais.Enabled = false;
            this.txtPais.Enabled = false;
            this.txtUf.Enabled = false;
            this.btnPesquisar.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtEstado.Enabled = true;
            this.txtCodPais.Enabled = true;
            this.txtPais.Enabled = true;
            this.txtUf.Enabled = true;
            this.btnPesquisar.Enabled = true;
        }

        public override void setFrmConsulta(object obj, object OutroObj) // Vai receber um Form De Consulta para poder em Estado conseguir Consultar um pais por exemplo
        {
            oFrmConPaises = (FrmConPaises)obj;
            
        }

        public override void Salvar()
        {
            if ((this.txtEstado.Text == "") || (this.txtEstado.Text == null))
            { 
                this.txtEstado.Focus();
            }
            if (txtCodPais == null)
                this.txtCodPais.Focus();
            oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
            oEstado.Estado = txtEstado.Text;
            oEstado.Uf = txtUf.Text;
            oEstado.OPais.Pais = txtPais.Text;
            oEstado.OPais.Codigo = Convert.ToInt32(txtCodPais.Text);
            this.Sair();
        }


        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
            aCtrlEstados = (CtrlEstados)ctrl;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string aux = oFrmConPaises.btnSair.Text;
            string aux2 = this.lblUf.Text;
            oFrmConPaises.btnSair.Text = "Selecionar";
            oFrmConPaises.ConhecaObjeto(oEstado.OPais, aCtrlEstados.ACtrlPaises); //aCtrlEstados.aCtrlPaises não está indo
            oFrmConPaises.ShowDialog();
            this.txtCodPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais; 
            if (oEstado.OPais.Sigla == "BR")
                this.lblUf.Text = this.lblUf.Text + '*';
            oFrmConPaises.btnSair.Text = aux;
        //  this.lblUf.Text = aux2;
        }
    }
}
