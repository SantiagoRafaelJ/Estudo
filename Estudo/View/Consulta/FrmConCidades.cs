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
        public FrmConCidades()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oCidade = (Cidades)obj;
        }

        public override void Incluir()
        {
            oFrmCadCidades.ConhecaObjeto(oCidade, null);
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadCidades.ConhecaObjeto(oCidade, null);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";
            oFrmCadCidades.ConhecaObjeto(oCidade, null);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloquearTxt();
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.btnSalvar.Text = aux;
            oFrmCadCidades.DesbloquearTxt();
        }

        public override void Pesquisar()
        {

        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadCidades = (FrmCadCidades)obj;
        }
    }
}
