using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cadastro_de_Intenção_de_Matrícula
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o sistema?", "Confirmação de Saída",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Application.Exit();
        }

        private void responsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
  		    FrmCadResp frm = new FrmCadResp();
    		frm.MdiParent = this; 
    		frm.Show(); 
        }

        private void segmentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            FrmCadSegmento frm = new FrmCadSegmento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sérieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            FrmCadSerie frm = new FrmCadSerie();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
