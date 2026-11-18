using Estudo.DAO;
using Estudo.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class CtrlEstados : Controller
    {
        protected DaoEstados aDaoEstados;
        public CtrlPaises aCtrlPaises;
        public CtrlEstados()
        {
            aDaoEstados = new DaoEstados();
            aCtrlPaises = new CtrlPaises();
        }

        public override string Salvar(object obj)
        {
            aDaoEstados.Salvar(obj);
            return null;
        }
        public override string CarregarObj(object obj)
        {
            return aDaoEstados.CarregarObj(obj);
        }
        public override List<object> Pesquisar(object obj)
        {
            return aDaoEstados.Pesquisar(obj);
        }
        public override string Excluir(object obj)
        {
            return aDaoEstados.Excluir(obj);
        }
        public override List<object> CarregarColecao()
        {
            return null;
        }

        public CtrlPaises ACtrlPaises
        {
            get => aCtrlPaises;
            set => aCtrlPaises = value;
        }
    }
}