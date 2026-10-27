using Estudo.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class CtrlCargo : Controller
    {
        protected DaoCargo aDaoCargo;
        public CtrlCargo()
        {
            aDaoCargo = new DaoCargo();
        }
        public override string Salvar(object obj)
        {
            return null;
        }
        public override string CarregarObj(object obj)
        {
            return aDaoCargo.CarregarObj(obj);
        }
        public override List<object> Pesquisar(object obj)
        {
            return null;
        }
        public override string Excluir(object obj)
        {
            return aDaoCargo.Excluir(obj);
        }
        public override List<object> CarregarColecao()
        {
            return null;
        }
    }
}