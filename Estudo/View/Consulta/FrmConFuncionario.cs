using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmConFuncionario : Estudo.FrmConsulta
    {
        private FrmCadFuncionarios oFrmCadFuncionarios;
        private Funcionario oFuncionario;

        public FrmConFuncionario()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oFuncionario = (Funcionario)obj;
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadFuncionarios = (FrmCadFuncionarios)obj;
        }

        public override void Incluir()
        {
            oFrmCadFuncionarios.ConhecaObjeto(oFuncionario, null);
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadFuncionarios.ConhecaObjeto(oFuncionario, null);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadFuncionarios.btnSalvar.Text;
            oFrmCadFuncionarios.btnSalvar.Text = "Excluir";
            oFrmCadFuncionarios.ConhecaObjeto(oFuncionario, null);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.BloquearTxt();
            oFrmCadFuncionarios.ShowDialog();
            oFrmCadFuncionarios.btnSalvar.Text = aux;
            oFrmCadFuncionarios.DesbloquearTxt();
        }

        public override void Pesquisar()
        {

        }


    }
}
