using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmConsulta : Estudo.FrmBase
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        public virtual void Incluir()
        { 
            
        }

        public virtual void Alterar()
        {

        }

        public virtual void Excluir()
        {

        }

        public virtual void Pesquisar()
        {
            
        }

        public virtual void setFrmCadastro(object obj)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

    }
}
