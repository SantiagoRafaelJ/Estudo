using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Interfaces
    {
        protected FrmConFuncionario oFrmConFuncionarios;
        protected FrmConPaises oFrmConPaises;
        protected FrmConEstados oFrmConEstados;
        protected FrmConCidades oFrmConCidades;
        protected FrmConCargo oFrmConCargo;

        protected Funcionario oFuncionario;
        protected Paises oPais;
        protected Cidades oCidade;
        protected Estados oEstado;
        protected Cargo oCargo;

        protected CtrlCargo oCtrlCargo;
        protected CtrlFunc oCtrlFunc;
        protected CtrlPaises oCtrlPaises;
        protected CtrlEstados oCtrlEstados;
        protected CtrlCidades oCtrlCidades;




        protected FrmCadFuncionarios oFrmCadFuncionarios;
        protected FrmCadPaises oFrmCadPaises;
        protected FrmCadEstados oFrmCadEstados;
        protected FrmCadCidades oFrmCadCidades;
        protected FrmCadCargo oFrmCadCargo;

        public Interfaces()
        {
            oFrmConFuncionarios = new FrmConFuncionario();
            oFrmConPaises = new FrmConPaises();
            oFrmConEstados = new FrmConEstados();
            oFrmConCidades = new FrmConCidades();
            oFrmConFuncionarios = new FrmConFuncionario();
            oFrmConCargo = new FrmConCargo();

            oFrmCadFuncionarios = new FrmCadFuncionarios();
            oFrmCadPaises = new FrmCadPaises();
            oFrmCadEstados = new FrmCadEstados();
            oFrmCadCidades = new FrmCadCidades();
            oFrmCadCargo = new FrmCadCargo();

            

            oFrmConPaises.setFrmCadastro(oFrmCadPaises);
            oFrmConEstados.setFrmCadastro(oFrmCadEstados);
            oFrmConCidades.setFrmCadastro(oFrmCadCidades);
            oFrmConFuncionarios.setFrmCadastro(oFrmCadFuncionarios);
            oFrmConCargo.setFrmCadastro(oFrmCadCargo);

            oFrmCadEstados.setFrmConsulta(oFrmConPaises, null);
            oFrmCadCidades.setFrmConsulta(oFrmConPaises, oFrmConEstados);
            oFrmCadFuncionarios.setFrmConsulta(oFrmConCargo, oFrmConCidades);
        }

        public void PecaPaises(Paises obj, CtrlPaises ctrl)
        {
            oFrmConPaises.ConhecaObjeto(obj, ctrl);
            oFrmConPaises.ShowDialog();
        }

        public void PecaEstados(Estados obj, object ctrl)
        {
            oFrmConEstados.ConhecaObjeto(obj, ctrl);
            oFrmConEstados.ShowDialog();
        }

        public void PecaCidades(Cidades obj, object ctrl)
        {
            oFrmConCidades.ConhecaObjeto(obj, ctrl);
            oFrmConCidades.ShowDialog();
        }

        public void PecaFuncionarios(Funcionario obj, object ctrl)
        {
            oFrmConFuncionarios.ConhecaObjeto(obj, ctrl);
            oFrmConFuncionarios.ShowDialog();
        }

        public void PecaCargos(Cargo obj, object ctrl)
        {
            oFrmConCargo.ConhecaObjeto(obj, ctrl);
            oFrmConCargo.ShowDialog();
        }
    }
}
