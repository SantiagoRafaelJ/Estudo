using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Cidades : Pai
    {
        protected string cidade;
        protected string ddd;
        protected Estados oEstado;


        public Cidades() : base()
        {
            cidade = "";
            ddd = "";
            oEstado = new Estados();
        }

        public Cidades(int codigo, int codUsu, DateTime datCad, DateTime ultAlt, string cidade, string ddd, Estados oEstado) : base(codigo, codUsu, datCad, ultAlt)
        {
            this.cidade = cidade;
            this.ddd = ddd;
            this.oEstado = oEstado;
        }

        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }

        public string Ddd
        {
            get => ddd; 
            set => ddd = value;
        }

        public Estados OEstado
        {
            get => oEstado; 
            set => oEstado = value;
        }



    }

}
