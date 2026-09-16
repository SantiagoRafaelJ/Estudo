using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Controller
    {
        public abstract virtual string Salvar(object obj)
        {
            return null;
        }
        public abstract virtual string CarregarObj(object obj)
        {
            return null;
        }
        public abstract virtual List<object> CarregarColecao()
        {
            return null;
        }
        public abstract virtual List<object> Pesquisar(object obj)
        {
            return null;
        }
        public abstract virtual string Excluir(object obj)
        {
            return null;
        }
    }
}