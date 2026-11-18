using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmConCidades : Estudo.FrmConsulta
    {
        protected FrmCadCidades oFrmCadCidades;
        private Cidades oCidade;
        private CtrlCidades aCtrlCidades;
        public FrmConCidades()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oCidade = (Cidades)obj;
            aCtrlCidades = (CtrlCidades)ctrl;
            this.Pesquisar();
        }

        public override void Incluir()
        {
            oFrmCadCidades.ConhecaObjeto(oCidade, aCtrlCidades);
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
            this.Pesquisar();
        }

        public override void Alterar()
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            string erro = aCtrlCidades.CarregarObj(oCidade);

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            oFrmCadCidades.ConhecaObjeto(oCidade, aCtrlCidades);
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
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
                "Deseja excluir a cidade " + oCidade.Cidade + "?",
                "Excluir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            string erro = aCtrlCidades.Excluir(oCidade);

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
            Cidades aCidadeFiltro = new Cidades();

            foreach (Cidades o in aCtrlCidades.Pesquisar(aCidadeFiltro))
            {
                this.AdicionarLinhaLV(o);
            }
        }
        private void AdicionarLinhaLV(Cidades aCidadeA)
        {
            ListViewItem item = new ListViewItem(".");

            item.SubItems.Add(aCidadeA.Codigo.ToString());
            item.SubItems.Add(aCidadeA.Cidade);
            item.SubItems.Add(aCidadeA.Ddd);
            item.SubItems.Add(aCidadeA.OEstado.Estado);
            item.SubItems.Add(".");
            item.Tag = aCidadeA;
            LV.Items.Add(item);
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadCidades = (FrmCadCidades)obj;
            oFrmCadCidades.ConhecaObjeto(oCidade, aCtrlCidades);
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
                Cidades oCidadeSel = (Cidades)linha.Tag;
                oCidade.Codigo = oCidadeSel.Codigo;
                oCidade.Cidade = oCidadeSel.Cidade;
                oCidade.Ddd = oCidadeSel.Ddd;
                oCidade.OEstado = oCidadeSel.OEstado;
            }
        }
        public override void Sair()
        {
            if (btnSair.Text == "Selecionar")
            {
                Cidades oCidadeSel = (Cidades)LV.SelectedItems[0].Tag;

                oCidade.Codigo = oCidadeSel.Codigo;
                oCidade.Cidade = oCidadeSel.Cidade;
                oCidade.Ddd = oCidadeSel.Ddd;
                oCidade.OEstado = oCidadeSel.OEstado;
                DialogResult = DialogResult.OK;
            }
            else
            {
                base.Sair();
            }
        }
    }
}
