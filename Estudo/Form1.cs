using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmPrincipal : Form
    {
        private Cargo oCargo;
        private Interfaces aInter;
        private Paises oPais;
        private Estados oEstado;
        private Cidades oCidade;
        private Funcionario oFuncionario;
        private CtrlCargo oCtrlCargo;
        private CtrlCidades oCtrlCidades;

        private CtrlEstados oCtrlEstados;
        private CtrlFunc oCtrlFunc;

        private CtrlPaises oCtrlPaises;
        public FrmPrincipal()
        {
            InitializeComponent();
            aInter = new Interfaces();
            oPais = new Paises();
            oEstado = new Estados();
            oCidade = new Cidades();
            oFuncionario = new Funcionario();
            oCargo = new Cargo();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais, oCtrlPaises);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado, oCtrlEstados);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades(oCidade, oCtrlCidades);
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaFuncionarios(oFuncionario, oCtrlFunc);
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCargos(oCargo, oCtrlCargo);
        }
    }
}
