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
        protected string datCnh;
        protected string mat;
        protected string salBase;
        protected Cidades aCidade;
        protected int numDep;
        protected DateTime dataValidade;
        protected string cep;
        protected Cargo oCargo;

        public Funcionario()
        {
            numCnh = "";
            datCnh = "";
            mat = "";
            salBase = "";
            aCidade = new Cidades();
            numDep = 0;
            dataValidade = DateTime.Today;
            cep = "";
            oCargo = new Cargo();
        }

        public Funcionario(string numCnh, string datCnh, string mat, string salBase, Cidades aCidade, int numDep, DateTime dataValidade, string cep, string num, string endereco, Cargo oCargo)
        {
            this.numCnh = numCnh;
            this.datCnh = datCnh;
            this.mat = mat;
            this.salBase = salBase;
            this.aCidade = aCidade;
            this.numDep = numDep;
            this.dataValidade = dataValidade;
            this.cep = cep;
            this.num = num;
            this.endereco = endereco;
            this.oCargo = oCargo;
        }

        public string NumCnh
        {
            get => numCnh;
            set => numCnh = value;
        }
        public string DatCnh
        {
            get => datCnh;
            set => datCnh = value;
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

        public Cidades ACidade
        {
            get => aCidade;
            set => aCidade = value;
        }

        public int NumDep
        {
            get => numDep;
            set => numDep = value;
        }

        public DateTime DataValidade
        {
            get => dataValidade;
            set => dataValidade = value;
        }

        public string Cep
        {
            get => cep;
            set => cep = value;
        }

        public Cargo OCargo
        {
            get => oCargo;
            set => oCargo = value;
        }

        public Funcionario Clone()
        {
            return new Funcionario(numCnh, datCnh, mat, salBase, aCidade, numDep, dataValidade, cep, num, endereco, oCargo);
        }
    }
}