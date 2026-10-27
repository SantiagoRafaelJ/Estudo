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
        private CtrlCargo aCtrlCargo;
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
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            string erro = aCtrlCargo.CarregarObj(oCargo);

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            oFrmCadCargo.ConhecaObjeto(oCargo, aCtrlCargo);
            oFrmCadCargo.CarregaTxt();
            oFrmCadCargo.ShowDialog();
            this.Pesquisar();
        }

        public override void Excluir()
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            DialogResult resp = MessageBox.Show(
                "Deseja excluir o cargo " + oCargo.Nome + "?",
                "Excluir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            string erro = aCtrlCargo.Excluir(oCargo);

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            this.Pesquisar();
        }

        public override void Pesquisar()
        {

        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.LV.SelectedItems.Count > 0)
            {
                ListViewItem linha = LV.SelectedItems[0];
                Cargo oCargoSel = (Cargo)linha.Tag;
                oCargo.Codigo = oCargoSel.Codigo;
                oCargo.Nome = oCargoSel.Nome;
                oCargo.Comiss = oCargoSel.Comiss;
                oCargo.ExigeCNH = oCargoSel.ExigeCNH;
            }
        }
        public override void Sair()
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }
            if (btnSair.Text == "Selecionar")
            {
                Cargo oCargoSel = (Cargo)LV.SelectedItems[0].Tag;

                oCargo.Codigo = oCargoSel.Codigo;
                oCargo.Nome = oCargoSel.Nome;
                oCargo.Comiss = oCargoSel.Comiss;
                oCargo.ExigeCNH = oCargoSel.ExigeCNH;
                DialogResult = DialogResult.OK;
            }
            else
            {
                base.Sair();
            }
        }
    }
}
