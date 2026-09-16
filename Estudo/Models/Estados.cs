using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Estados : Pai
    {
        protected string uf;
        protected string estado;
        protected Paises oPais;

        public Estados() : base()
        {
            estado = "";
            uf = "";
            oPais = new Paises();
        }
        public Estados(int codigo, int codUsu, DateTime datCad, DateTime ultAlt, string uf, string estado, Paises oPais) : base(codigo, codUsu, datCad, ultAlt)
        {
            this.uf = uf;
            this.estado = estado;
            this.oPais = oPais;
        }

        public string Estado
        {
            get => estado;
            set => estado = value;
        }

        public string Uf
        {
            get => uf;
            set => uf = value;
        }
        public Paises OPais
        {
            get => oPais;
            set => oPais = value;
        }
    }
}
