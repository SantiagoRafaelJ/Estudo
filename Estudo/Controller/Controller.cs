using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal abstract class Controller
    {
        public abstract string Salvar(object obj);
        public abstract string CarregarObj(object obj);
        public abstract List<object> CarregarColecao();
        public abstract List<object> Pesquisar(object obj);
        public abstract string Excluir(object obj);
    }
}