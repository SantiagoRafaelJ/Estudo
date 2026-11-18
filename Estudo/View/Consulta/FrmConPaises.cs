using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmConPaises : Estudo.FrmConsulta
    {
        protected FrmCadPaises oFrmCadPaises;
        private Paises oPais;
        private CtrlPaises aCtrlPaises;
        public FrmConPaises()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oPais = (Paises)obj;
            aCtrlPaises = (CtrlPaises)ctrl;
            this.Pesquisar();
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadPaises = (FrmCadPaises)obj;
            oFrmCadPaises.ConhecaObjeto(oPais, aCtrlPaises);
        }

        public override void Incluir()
        {
            oFrmCadPaises.ConhecaObjeto(oPais, aCtrlPaises);
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            this.Pesquisar();
        }

        public override void Alterar()
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            string erro = aCtrlPaises.CarregarObj(oPais);

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            oFrmCadPaises.ConhecaObjeto(oPais, aCtrlPaises);
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
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
                "Deseja excluir o país " + oPais.Pais + "?",
                "Excluir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            string erro = aCtrlPaises.Excluir(oPais);

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
            Paises oPaisFiltro = new Paises();
            
            //var listaResultado = new List<Paises>();
            foreach (Paises pais in aCtrlPaises.Pesquisar(oPaisFiltro))
            {
                this.AdicionarLinhaLV(pais);
            }
        }
            
        private void AdicionarLinhaLV(Paises oPaisA)
        {
                ListViewItem item = new ListViewItem(".");
                item.SubItems.Add(oPaisA.Codigo.ToString());
                item.SubItems.Add(oPaisA.Pais);
                item.SubItems.Add(oPaisA.Sigla);
                item.SubItems.Add(oPaisA.Ddi);
                item.SubItems.Add(oPaisA.Moeda);
                item.Tag = oPaisA;
                LV.Items.Add(item);
}

        public override void Sair()
        {
            if (btnSair.Text == "Selecionar")
            {

                ListViewItem item = LV.SelectedItems[0];

                oPais.Codigo = Convert.ToInt32(item.SubItems[1].Text);
                oPais.Pais = item.SubItems[2].Text;
                oPais.Sigla = item.SubItems[3].Text;
                oPais.Ddi = item.SubItems[4].Text;
                oPais.Moeda = item.SubItems[5].Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                base.Sair();
            }
        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.LV.SelectedItems.Count > 0)
            {
                ListViewItem linha = LV.SelectedItems[0];
                Paises oPaisSel = (Paises)linha.Tag;
                oPais.Codigo = oPaisSel.Codigo;
                oPais.Pais = oPaisSel.Pais;
                oPais.Sigla = oPaisSel.Sigla;
                oPais.Ddi = oPaisSel.Ddi;
                oPais.Moeda = oPaisSel.Moeda;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar();
        }
    }
}
