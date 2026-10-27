using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmCadPaises : Estudo.FrmCadastro
    {
        private Paises oPais;
        private CtrlPaises aCtrlPaises;
        public FrmCadPaises()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oPais = (Paises)obj;
            aCtrlPaises = (CtrlPaises)ctrl;
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtCodigo.Text = "0";
            this.txtPais.Clear();
            this.txtSigla.Clear();
            this.txtDdi.Clear();
            this.txtMoeda.Clear();
            this.lblCodUsu.Text = "";
            this.lblDatCad.Text = "";
            this.lblUltAlt.Text = "";
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oPais.Codigo);
            this.txtPais.Text = oPais.Pais;
            this.txtSigla.Text = oPais.Sigla;
            this.txtDdi.Text = Convert.ToString(oPais.Ddi);
            this.txtMoeda.Text = oPais.Moeda;
            this.lblCodUsu.Text = oPais.CodUsu.ToString();
            this.lblDatCad.Text = oPais.DatCad.ToString();
            this.lblUltAlt.Text = oPais.UltAlt.ToString();
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtPais.Enabled = false;
            this.txtSigla.Enabled = false;
            this.txtMoeda.Enabled = false;
            this.txtDdi.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtPais.Enabled = true;
            this.txtSigla.Enabled = true;
            this.txtMoeda.Enabled = true;
            this.txtDdi.Enabled = true;

        }

        public override void Salvar()
        {
            string msg;
            oPais.Codigo = Convert.ToInt32(txtCodigo.Text);
            oPais.Pais = txtPais.Text;
            oPais.Sigla = txtSigla.Text;
            oPais.Ddi = txtDdi.Text;
            oPais.Moeda = txtMoeda.Text;
            if (btnSalvar.Text == "Sal&var")
                msg = aCtrlPaises.Salvar(oPais);
            else
                msg = aCtrlPaises.Excluir(oPais);
            if(msg != null)
            {
                MessageBox.Show( msg );
            }
            this.Sair();
        }
    }
}
