using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmCadastro : Estudo.FrmBase
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        public virtual void LimpaTxt()
        { 

        }

        public virtual void CarregaTxt()
        {

        }

        public virtual void BloquearTxt()
        {

        }

        public virtual void DesbloquearTxt()
        {
            
        }

        public virtual void setFrmConsulta(object obj, object OutroObj) // Vai receber um Form De Consulta para poder em Estado conseguir Consultar um pais por exemplo
        {
            
        }

        public virtual void Salvar()
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
