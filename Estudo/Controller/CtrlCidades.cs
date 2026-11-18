using Estudo.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class CtrlCidades : Controller
    {
        protected DaoCidades aDaoCidades;
        protected CtrlEstados aCtrlEstados;
        public CtrlCidades()
        {
            aDaoCidades = new DaoCidades();
            aCtrlEstados = new CtrlEstados();
        }
        public override string Salvar(object obj)
        {
            aDaoCidades.Salvar(obj);
            return null;
        }
        public override string CarregarObj(object obj)
        {
            return aDaoCidades.CarregarObj(obj);
        }
        public override List<object> Pesquisar(object obj)
        {
            return aDaoCidades.Pesquisar(obj);
        }
        public override string Excluir(object obj)
        {
            return aDaoCidades.Excluir(obj);
        }
        public override List<object> CarregarColecao()
        {
            return null;
        }

        public CtrlEstados ACtrlEstados
        {
            get => aCtrlEstados;
            set => aCtrlEstados = value;
        }
    }
}