using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Pai
    {
        protected int codigo;
        protected int codUsu;
        protected DateTime datCad;
        protected DateTime ultAlt;

        public Pai()
        {
            codigo = 0;
            codUsu = 0;
            datCad = DateTime.Now; 
            ultAlt = DateTime.Now;
        }

        public Pai(int codigo, int codUsu, DateTime datCad, DateTime ultAlt)
        {
            this.codigo = codigo;
            this.codUsu = codUsu;
            this.datCad = datCad;
            this.ultAlt = ultAlt;
        }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        public int CodUsu
        {
            get => codUsu;
            set => codUsu = value;
        }
        
        public DateTime DatCad
        {
            get => datCad;
            set => datCad = value;
        }

        public DateTime UltAlt
        {
            get => ultAlt;
            set => ultAlt = value;
        }

        public Pai Clone()
        {
            return new Pai(codigo, codUsu, datCad, ultAlt);
        }
    }
}
