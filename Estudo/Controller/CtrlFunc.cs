using Estudo.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class CtrlFunc : Controller
    {

        protected DaoFuncionario aDaoFuncionario;
        protected CtrlCargo aCtrlCargo;
        protected CtrlCidades aCtrlCidades;

        public CtrlFunc()
        {
            aDaoFuncionario = new DaoFuncionario();
            aCtrlCargo = new CtrlCargo();
            aCtrlCidades = new CtrlCidades();
        }
        public override string Salvar(object obj)
        {
            return null;
        }
        public override string CarregarObj(object obj)
        {
            return aDaoFuncionario.CarregarObj(obj);
        }
        public override List<object> Pesquisar(object obj)
        {
            return null;
        }
        public override string Excluir(object obj)
        {
            return aDaoFuncionario.Excluir(obj);
        }
        public override List<object> CarregarColecao()
        {
            return null;
        }

        public CtrlCidades ACtrlCidades
        {
            get => aCtrlCidades;
            set => aCtrlCidades = value;
        }

        public CtrlCargo ACtrlCargo
        {
            get => aCtrlCargo;
            set => aCtrlCargo = value;
        }
    }
}