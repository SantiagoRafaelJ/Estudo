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
        public FrmConEstados()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
        }

        public override void Incluir()
        {
            oFrmCadEstados.ConhecaObjeto(oEstado, null);
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadEstados.ConhecaObjeto(oEstado, null);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";
            oFrmCadEstados.ConhecaObjeto(oEstado, null);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloquearTxt();
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.btnSalvar.Text = aux;
            oFrmCadEstados.DesbloquearTxt();
        }

        public override void Pesquisar()
        {

        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadEstados = (FrmCadEstados)obj;
        }
    }
}
