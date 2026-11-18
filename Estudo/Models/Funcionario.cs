using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Funcionario : Pessoa
    {
        protected string numCnh;
        protected DateTime datCnhVal;
        protected string mat;
        protected string salBase;
        protected int numDep;
        protected Cargo oCargo;

        public Funcionario()
        {
            numCnh = "";
            datCnhVal = DateTime.Today;
            mat = "";
            salBase = "";
            numDep = 0;
            oCargo = new Cargo();
        }

        public Funcionario(string numCnh, DateTime datCnhVal, string mat, string salBase, int numDep, string num, string endereco, Cargo oCargo)
        {
            this.numCnh = numCnh;
            this.datCnhVal = datCnhVal;
            this.mat = mat;
            this.salBase = salBase;
            this.numDep = numDep;
            this.num = num;
            this.endereco = endereco;
            this.oCargo = oCargo;
        }

        public string NumCnh
        {
            get => numCnh;
            set => numCnh = value;
        }
        public DateTime DatCnhVal
        {
            get => datCnhVal;
            set => datCnhVal = value;
        }

        public string Mat
        {
            get => mat;
            set => mat = value;
        }

        public string SalBase
        {
            get => salBase;
            set => salBase = value;
        }


        public int NumDep
        {
            get => numDep;
            set => numDep = value;
        }


        public Cargo OCargo
        {
            get => oCargo;
            set => oCargo = value;
        }

        public Funcionario Clone()
        {
            return new Funcionario(numCnh, datCnhVal, mat, salBase, numDep, num, endereco, oCargo);
        }
    }
}