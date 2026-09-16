using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        public virtual void ConhecaObjeto(object obj, object ctrl)
        {
            
        }

        public virtual void Sair()
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }

}
