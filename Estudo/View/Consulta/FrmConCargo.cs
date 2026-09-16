using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmConCargo : Estudo.FrmConsulta
    {
        private FrmCadCargo oFrmCadCargo;
        private Cargo oCargo;
        public FrmConCargo()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oCargo = (Cargo)obj;
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadCargo = (FrmCadCargo)obj;
        }

        public override void Incluir()
        {
            oFrmCadCargo.ConhecaObjeto(oCargo, null);
            oFrmCadCargo.CarregaTxt();
            oFrmCadCargo.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadCargo.ConhecaObjeto(oCargo, null);
            oFrmCadCargo.LimpaTxt();
            oFrmCadCargo.CarregaTxt();
            oFrmCadCargo.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadCargo.btnSalvar.Text;
            oFrmCadCargo.btnSalvar.Text = "Excluir";
            oFrmCadCargo.ConhecaObjeto(oCargo, null);
            oFrmCadCargo.LimpaTxt();
            oFrmCadCargo.CarregaTxt();
            oFrmCadCargo.BloquearTxt();
            oFrmCadCargo.ShowDialog();
            oFrmCadCargo.btnSalvar.Text = aux;
            oFrmCadCargo.DesbloquearTxt();
        }

        public override void Pesquisar()
        {

        }

    }
}
