using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
    internal class Pessoa : Pai
    {
        protected string nome; //adicionar
        protected int idade; //adicionar
        protected char sexo; //adicionar
        protected string endereco; //adicionar
        protected string num; //adicionar
        protected string bairro; //adicionar
        protected string complemento; //adicionar
        protected string celular; //adicionar
        protected string cpf; //adicionar
        protected Cidades aCidade;
        protected string cep;

        public Pessoa()
        {
            aCidade = new Cidades();
            cep = "";
            nome = "";
            idade = 0;
            sexo = ' ';
            endereco = "";
            num = "";
            bairro = "";
            complemento = "";
            celular = "";
            cpf = "";
        }

        public string Cpf
        {
            get => cpf;
            set => cpf = value;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public int Idade
        {
            get => idade;
            set => idade = value;
        }

        public char Sexo
        {
            get => sexo;
            set => sexo = value;
        }

        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }

        public string Num
        {
            get => num;
            set => num = value;
        }

        public string Bairro
        {
            get => bairro;
            set => bairro = value;
        }

        public string Complemento
        {
            get => complemento;
            set => complemento = value;
        }

        public string Celular
        {
            get => celular;
            set => celular = value;
        }

        public Cidades ACidade
        {
            get => aCidade;
            set => aCidade = value;
        }

        public string Cep
        {
            get => cep;
            set => cep = value;
        }
    }
}