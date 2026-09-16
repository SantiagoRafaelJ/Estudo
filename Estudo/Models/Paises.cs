using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Paises : Pai
    {
        protected string pais;
        protected string sigla;
        protected string ddi;
        protected string moeda;

        public Paises() : base()
        {
            pais = "";
            sigla = "";
            ddi = "";
            moeda = "";
        }

        public Paises(int codigo, int codUsu, DateTime datCad, DateTime ultAlt, string pais, string sigla, string ddi, string moeda) : base(codigo, codUsu, datCad, ultAlt)
        {
            this.pais = pais;
            this.sigla = sigla;
            this.ddi = ddi;
            this.moeda = moeda;
        }

        public string Pais
        {
            get => pais;
            set => pais = value;
        }

        public string Sigla
        {
            get => pais;
            set => pais = value;
        }

        public string Ddi
        { 
            get => ddi;
            set => ddi = value;
        }

        public string Moeda
        {
            get => pais;
            set => pais = value;
        }

        public Paises Clone()
        {
            return new Paises(codigo, codUsu, datCad, ultAlt, pais, sigla, ddi, moeda);
        }
    }
}
