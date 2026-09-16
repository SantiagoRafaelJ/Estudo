using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmCadCargo : Estudo.FrmCadastro
    {
        public FrmCadCargo()
        {
            InitializeComponent();
        }
        private Cargo oCargo;
        private CtrlCargo aCtrlCargo;

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oCargo = (Cargo)obj;
            aCtrlCargo = (CtrlCargo)ctrl;
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtNome.Enabled = false;
            this.txtComiss.Enabled = false;
            this.checkBoxExigeCNH.Enabled = false;
        }

        public override void CarregaTxt()
        {
            txtCodigo.Text = Convert.ToString(oCargo.Codigo);
            txtNome.Text = Convert.ToString(oCargo.Nome);
            txtComiss.Text = Convert.ToString(oCargo.Comiss);
            checkBoxExigeCNH.Checked = oCargo.ExigeCNH;
            this.lblCodUsu.Text = oCargo.CodUsu.ToString();
            this.lblDatCad.Text = oCargo.DatCad.ToString();
            this.lblUltAlt.Text = oCargo.UltAlt.ToString();
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtNome.Clear();
            this.txtComiss.Clear();
            this.checkBoxExigeCNH.Checked = false;
            this.lblCodUsu.Text = "";
            this.lblDatCad.Text = "";
            this.lblUltAlt.Text = "";
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtNome.Enabled = true;
            this.txtComiss.Enabled = true;
            this.checkBoxExigeCNH.Enabled = true;

        }
        public override void Salvar()
        {
            oCargo.Codigo = Convert.ToInt32(txtCodigo.Text);
            oCargo.Nome = txtNome.Text;
            oCargo.Comiss = Convert.ToDouble(txtComiss.Text);
            oCargo.ExigeCNH = checkBoxExigeCNH.Checked;
            this.Sair();
        }
    }
}
