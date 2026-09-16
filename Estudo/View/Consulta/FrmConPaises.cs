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
        public FrmConPaises()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oPais = (Paises)obj; 
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadPaises = (FrmCadPaises)obj;
        }

        public override void Incluir()
        {
            oFrmCadPaises.ConhecaObjeto(oPais, null);
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadPaises.ConhecaObjeto(oPais, null);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "Excluir";
            oFrmCadPaises.ConhecaObjeto(oPais, null);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloquearTxt();
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.btnSalvar.Text = aux;
            oFrmCadPaises.DesbloquearTxt();
        }

        public override void Pesquisar()
        {

        }
    }
}
