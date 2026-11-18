using Estudo.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
    internal class CtrlPaises : Controller
    {
        protected DaoPaises aDaoPais;
        public CtrlPaises()
        {
           aDaoPais = new DaoPaises();
        }
        public override string Salvar(object obj)
        {
            aDaoPais.Salvar(obj);
            return null;
        }
        public override string CarregarObj(object obj)
        {
            return aDaoPais.CarregarObj(obj);
        }
        public override List<object> Pesquisar(object obj)
        {
            return aDaoPais.Pesquisar(obj);
        }
        public override string Excluir(object obj)
        {
            return aDaoPais.Excluir(obj);
        }
        public override List<object> CarregarColecao()
        {
            return null;
        }
    }
}