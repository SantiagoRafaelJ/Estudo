using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmConEstados : Estudo.FrmConsulta
    {
        private Estados oEstado;
        private FrmCadEstados oFrmCadEstados;
        private CtrlEstados aCtrlEstados;
        public FrmConEstados()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
            aCtrlEstados = (CtrlEstados)ctrl;
        }

        public override void Incluir()
        {
            oFrmCadEstados.ConhecaObjeto(oEstado, aCtrlEstados);
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }

        public override void Alterar()
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            string erro = aCtrlEstados.CarregarObj(oEstado);

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            oFrmCadEstados.ConhecaObjeto(oEstado, aCtrlEstados);
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
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
                "Deseja excluir o estado " + oEstado.Estado + "?",
                "Excluir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            string erro = aCtrlEstados.Excluir(oEstado);

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            this.Pesquisar();
        }

        public override void Pesquisar()
        {
            this.LV.Items.Clear();
            Estados oEstadoFiltro = new Estados();

            oEstadoFiltro.Estado = txtCodigo.Text.Trim().ToUpper();
            // var listaResultado = new List<Paises>();
            foreach (Estados o in aCtrlEstados.Pesquisar(oEstadoFiltro))
            {
                AdicionarLinhaLV(o);
            }
        }

        private void AdicionarLinhaLV(Estados oEstadoA)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(oEstado.Codigo.ToString());
            item.SubItems.Add(oEstado.Estado);
            item.SubItems.Add(oEstado.OPais.Pais);
            item.SubItems.Add(oEstado.Uf);
            item.Tag = oEstadoA;
            LV.Items.Add(item);
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadEstados = (FrmCadEstados)obj;
            oFrmCadEstados.ConhecaObjeto(oEstado, aCtrlEstados);
        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }
            if (this.LV.SelectedItems.Count > 0)
            {
                ListViewItem linha = LV.SelectedItems[0];
                Estados oEstadoSel = (Estados)linha.Tag;
                oEstado.Codigo = oEstadoSel.Codigo;
                oEstado.Estado = oEstadoSel.Estado;
                oEstado.Uf = oEstadoSel.Uf;
                oEstado.OPais = oEstadoSel.OPais;
            }
        }
        public override void Sair()
        {
            if (btnSair.Text == "Selecionar")
            {
                Estados oEstadoSel = (Estados)LV.SelectedItems[0].Tag;

                oEstado.Codigo = oEstadoSel.Codigo;
                oEstado.Estado = oEstadoSel.Estado;
                oEstado.Uf = oEstadoSel.Uf;
                oEstado.OPais = oEstadoSel.OPais;
                DialogResult = DialogResult.OK;
            }
            else
            {
                base.Sair();
            }
        }
    }
}
