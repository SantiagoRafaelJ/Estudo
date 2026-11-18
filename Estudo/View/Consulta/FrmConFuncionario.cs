using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmConFuncionario : Estudo.FrmConsulta
    {
        private FrmCadFuncionarios oFrmCadFuncionarios;
        private Funcionario oFuncionario;
        private CtrlFunc aCtrlFunc;

        public FrmConFuncionario()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oFuncionario = (Funcionario)obj;
            aCtrlFunc = (CtrlFunc)ctrl;
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadFuncionarios = (FrmCadFuncionarios)obj;
        }

        public override void Incluir()
        {
            oFrmCadFuncionarios.ConhecaObjeto(oFuncionario, aCtrlFunc);
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
        }

        public override void Alterar()
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            string erro = aCtrlFunc.CarregarObj(oFuncionario);

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            oFrmCadFuncionarios.ConhecaObjeto(oFuncionario, aCtrlFunc);
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
            this.Pesquisar();
        }

        public override void Excluir()
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            DialogResult resp = MessageBox.Show(
                "Deseja excluir o funcionário de matrícula " + oFuncionario.Mat + "?",
                "Excluir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            string erro = aCtrlFunc.Excluir(oFuncionario);

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            this.Pesquisar();
        }

        public override void Pesquisar()
        {
            this.LV.Items.Clear();
            Funcionario oFuncionairoFiltro = new Funcionario();

            foreach (Funcionario o in aCtrlFunc.Pesquisar(oFuncionairoFiltro))
            {
                this.AdicionarLinhaLV(o);
            }

        }

        private void AdicionarLinhaLV(Funcionario oFuncionarioA)
        {
            ListViewItem item = new ListViewItem(".");

            item.SubItems.Add(oFuncionarioA.Codigo.ToString());
            item.SubItems.Add(oFuncionarioA.Mat);
            item.SubItems.Add(oFuncionarioA.OCargo.Nome);
            item.SubItems.Add(oFuncionarioA.ACidade.Cidade);
            item.SubItems.Add(oFuncionarioA.NumCnh);
            item.SubItems.Add(oFuncionarioA.DatCnhVal.ToString("dd/MM/yyyy"));
            item.SubItems.Add(oFuncionario.SalBase);
            item.SubItems.Add(".");
            item.Tag = oFuncionarioA;
            LV.Items.Add(item);
        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }
            if (this.LV.SelectedItems.Count > 0)
            {
                ListViewItem linha = LV.SelectedItems[0];
                Funcionario oFuncionarioSel = (Funcionario)linha.Tag;
                oFuncionario.Codigo = oFuncionarioSel.Codigo;
                oFuncionario.NumCnh = oFuncionarioSel.NumCnh;
                oFuncionario.Mat = oFuncionarioSel.Mat;
                oFuncionario.SalBase = oFuncionarioSel.SalBase;
                oFuncionario.NumDep = oFuncionarioSel.NumDep;
                oFuncionario.DatCnhVal = oFuncionarioSel.DatCnhVal;
                oFuncionario.Cep = oFuncionarioSel.Cep;
                oFuncionario.ACidade = oFuncionarioSel.ACidade;
                oFuncionario.OCargo = oFuncionarioSel.OCargo;
                oFuncionario.Nome = oFuncionarioSel.Nome;
                oFuncionario.Idade = oFuncionarioSel.Idade;
                oFuncionario.Endereco = oFuncionarioSel.Endereco;
                oFuncionario.Num = oFuncionarioSel.Num;
                oFuncionario.Bairro = oFuncionarioSel.Bairro;
                oFuncionario.Celular = oFuncionarioSel.Celular;
                oFuncionario.Cpf = oFuncionarioSel.Cpf;
                oFuncionario.Complemento = oFuncionarioSel.Complemento;
            }
        }
        public override void Sair()
        {
            if (btnSair.Text == "Selecionar")
            {
                Funcionario oFuncionarioSel = (Funcionario)LV.SelectedItems[0].Tag;

                oFuncionario.Codigo = oFuncionarioSel.Codigo;
                oFuncionario.NumCnh = oFuncionarioSel.NumCnh;
                oFuncionario.Mat = oFuncionarioSel.Mat;
                oFuncionario.SalBase = oFuncionarioSel.SalBase;
                oFuncionario.NumDep = oFuncionarioSel.NumDep;
                oFuncionario.DatCnhVal = oFuncionarioSel.DatCnhVal;
                oFuncionario.Cep = oFuncionarioSel.Cep;
                oFuncionario.ACidade = oFuncionarioSel.ACidade;
                oFuncionario.OCargo = oFuncionarioSel.OCargo;
                oFuncionario.Nome = oFuncionarioSel.Nome;
                oFuncionario.Idade = oFuncionarioSel.Idade;
                oFuncionario.Endereco = oFuncionarioSel.Endereco;
                oFuncionario.Num = oFuncionarioSel.Num;
                oFuncionario.Bairro = oFuncionarioSel.Bairro;
                oFuncionario.Celular = oFuncionarioSel.Celular;
                oFuncionario.Cpf = oFuncionarioSel.Cpf;
                oFuncionario.Complemento = oFuncionarioSel.Complemento;
                DialogResult = DialogResult.OK;
            }
            else
            {
                base.Sair();
            }
        }
    }
}
