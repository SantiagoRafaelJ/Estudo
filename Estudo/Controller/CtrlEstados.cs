using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class CtrlEstados : Controller
    {
        CtrlFunc aCtrlFunc;
        public CtrlEstados()
        {
            aCtrlFunc = new CtrlFunc();
        }
        public override string Salvar(object obj)
        {
            return null;
        }
        public override string CarregarObj(object obj)
        {
            return null;
        }
        public override List<object> Pesquisar(object obj)
        {
            return null;
        }
        public override string Excluir(object obj)
        {
            return null;
        }
    }
}