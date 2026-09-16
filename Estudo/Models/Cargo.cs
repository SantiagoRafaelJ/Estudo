using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Cargo : Pai
    {
        protected bool exigeCNH;
        protected double comiss;
        protected string nome;


        public Cargo()
        {
            exigeCNH = false;
            comiss = 0;
            nome = "";
        }

        public Cargo(bool exigeCNH, double comiss, string nome)
        {
            this.nome = nome;
            this.exigeCNH = exigeCNH;
            this.comiss = comiss;
        }

        public bool ExigeCNH
        { 
            get => exigeCNH;
            set => exigeCNH = value;
        }

        public double Comiss
        {
            get => comiss;
            set => comiss = value;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public Cargo Clone()
        {
            return new Cargo(exigeCNH, comiss, nome);
        }

    }
}
